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

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listBox_gyumolcsok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }

            cmd.CommandText = "UPDATE `gyomolcsok` SET `nev`= @nev,`egysegar`= @egysegar,`mennyiseg`= mennyiseg WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", textBox_egysegar.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown_mennyiseg.Value);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módositás sikeres!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_egysegar.Text = "";
                numericUpDown_mennyiseg.Value = numericUpDown_mennyiseg.Minimum;
                gyumolcsok_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok módositása sikertelen;");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_gyumolcsok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `gyomolcsok` WHERE `id` = @id;";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_egysegar.Text = "";
                numericUpDown_mennyiseg.Value = numericUpDown_mennyiseg.Minimum;
                gyumolcsok_lista_update();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }

        private void Form_gyumolcs_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox_gyumolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_gyumolcsok.SelectedIndex < 0)
            {
                return;
            }

            gyumolcs kivalasztott_gyumolcs = (gyumolcs)listBox_gyumolcsok.SelectedItem;
            textBox_id.Text = kivalasztott_gyumolcs.Id.ToString();
            textBox_nev.Text = kivalasztott_gyumolcs.Nev;
            textBox_egysegar.Text = kivalasztott_gyumolcs.Egysegar.ToString();
            numericUpDown_mennyiseg.Value = Convert.ToDecimal(kivalasztott_gyumolcs.Mennyiseg);
        }
    }
}
