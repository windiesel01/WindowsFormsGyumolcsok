namespace WindowsFormsGyumolcsok
{
    partial class Form_gyumolcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gyumolcs));
            this.listBox_gyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBox_gyumolcsok = new System.Windows.Forms.GroupBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.textBox_egysegar = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_gyumolcsok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_gyumolcsok
            // 
            this.listBox_gyumolcsok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_gyumolcsok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_gyumolcsok.FormattingEnabled = true;
            this.listBox_gyumolcsok.ItemHeight = 20;
            this.listBox_gyumolcsok.Location = new System.Drawing.Point(0, 0);
            this.listBox_gyumolcsok.Name = "listBox_gyumolcsok";
            this.listBox_gyumolcsok.Size = new System.Drawing.Size(238, 450);
            this.listBox_gyumolcsok.TabIndex = 0;
            this.listBox_gyumolcsok.SelectedIndexChanged += new System.EventHandler(this.listBox_gyumolcsok_SelectedIndexChanged);
            // 
            // groupBox_gyumolcsok
            // 
            this.groupBox_gyumolcsok.Controls.Add(this.button_delete);
            this.groupBox_gyumolcsok.Controls.Add(this.button_update);
            this.groupBox_gyumolcsok.Controls.Add(this.button_hozzaad);
            this.groupBox_gyumolcsok.Controls.Add(this.numericUpDown_mennyiseg);
            this.groupBox_gyumolcsok.Controls.Add(this.textBox_egysegar);
            this.groupBox_gyumolcsok.Controls.Add(this.textBox_nev);
            this.groupBox_gyumolcsok.Controls.Add(this.textBox_id);
            this.groupBox_gyumolcsok.Controls.Add(this.label4);
            this.groupBox_gyumolcsok.Controls.Add(this.label3);
            this.groupBox_gyumolcsok.Controls.Add(this.label2);
            this.groupBox_gyumolcsok.Controls.Add(this.label1);
            this.groupBox_gyumolcsok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_gyumolcsok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_gyumolcsok.Location = new System.Drawing.Point(238, 0);
            this.groupBox_gyumolcsok.Name = "groupBox_gyumolcsok";
            this.groupBox_gyumolcsok.Size = new System.Drawing.Size(271, 450);
            this.groupBox_gyumolcsok.TabIndex = 1;
            this.groupBox_gyumolcsok.TabStop = false;
            this.groupBox_gyumolcsok.Text = "Gyümölcs adatok:";
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(24, 188);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(222, 49);
            this.button_hozzaad.TabIndex = 8;
            this.button_hozzaad.Text = "Hozzáadás";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(106, 132);
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_mennyiseg.TabIndex = 7;
            // 
            // textBox_egysegar
            // 
            this.textBox_egysegar.Location = new System.Drawing.Point(106, 97);
            this.textBox_egysegar.Name = "textBox_egysegar";
            this.textBox_egysegar.Size = new System.Drawing.Size(100, 26);
            this.textBox_egysegar.TabIndex = 6;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(106, 64);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 26);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(106, 32);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(100, 26);
            this.textBox_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egységár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(25, 243);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(221, 51);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Módositás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(24, 300);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(221, 51);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_gyumolcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.groupBox_gyumolcsok);
            this.Controls.Add(this.listBox_gyumolcsok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_gyumolcs";
            this.Text = "Gyümölcs nyilvántartás";
            this.Load += new System.EventHandler(this.Form_gyumolcs_Load);
            this.groupBox_gyumolcsok.ResumeLayout(false);
            this.groupBox_gyumolcsok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_gyumolcsok;
        private System.Windows.Forms.GroupBox groupBox_gyumolcsok;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.TextBox textBox_egysegar;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
    }
}

