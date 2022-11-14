using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsGyumolcsok
{
    public partial class Form_gyumolcs : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form_gyumolcs()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";

            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {              
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
            gyumolcsok_lista_update();
        }

        private void gyumolcsok_lista_update()
        {
            listBox_gyumolcsok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyomolcsok` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    listBox_gyumolcsok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adja meg a gyümölcs nevét!");
                textBox_nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_egysegar.Text))
            {
                MessageBox.Show("Adjon meg egységárat!");
                textBox_egysegar.Focus();
                return;
            }
            if (numericUpDown_mennyiseg.Value  <= 0 )
            {
                MessageBox.Show("Érvénytelen mennyiség!");
                numericUpDown_mennyiseg.Focus();
                return;
            }
            cmd.CommandText = "INSERT INTO `gyomolcsok` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @egysegar, @mennyiseg);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", textBox_egysegar.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown_mennyiseg.Value.ToString());
            conn.Open();

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzitve!");
                    textBox_nev.Text = "";
                    textBox_egysegar.Text = "";
                    numericUpDown_mennyiseg.Value = numericUpDown_mennyiseg.Minimum;
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzités!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            conn.Close();
            gyumolcsok_lista_update();

        }
    }
}
