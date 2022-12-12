namespace PetShop.Forms.Clienti
{
    partial class ClientiForm
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.button_modifica = new System.Windows.Forms.Button();
            this.button_adauga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_panel = new System.Windows.Forms.Panel();
            this.button_view_clienti = new System.Windows.Forms.Button();
            this.button_view_angajati = new System.Windows.Forms.Button();
            this.button_view_animale = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.RosyBrown;
            this.button_exit.Location = new System.Drawing.Point(0, 313);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(119, 53);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Iesire";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_stergere
            // 
            this.button_stergere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stergere.Location = new System.Drawing.Point(931, 131);
            this.button_stergere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(104, 76);
            this.button_stergere.TabIndex = 12;
            this.button_stergere.Text = "Stergere Client";
            this.button_stergere.UseVisualStyleBackColor = true;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
            // 
            // button_modifica
            // 
            this.button_modifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modifica.Location = new System.Drawing.Point(820, 131);
            this.button_modifica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Size = new System.Drawing.Size(104, 76);
            this.button_modifica.TabIndex = 11;
            this.button_modifica.Text = "Modificare Client";
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // button_adauga
            // 
            this.button_adauga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_adauga.Location = new System.Drawing.Point(709, 131);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(104, 76);
            this.button_adauga.TabIndex = 10;
            this.button_adauga.Text = "Adaugare Client";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 450);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 361);
            this.dataGridView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetShop.Properties.Resources.fundal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(127, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 815);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // side_panel
            // 
            this.side_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.side_panel.AutoSize = true;
            this.side_panel.BackColor = System.Drawing.Color.RosyBrown;
            this.side_panel.Controls.Add(this.button_view_clienti);
            this.side_panel.Controls.Add(this.button_exit);
            this.side_panel.Controls.Add(this.button_view_angajati);
            this.side_panel.Controls.Add(this.button_view_animale);
            this.side_panel.Controls.Add(this.button_home);
            this.side_panel.Location = new System.Drawing.Point(1, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(131, 891);
            this.side_panel.TabIndex = 8;
            // 
            // button_view_clienti
            // 
            this.button_view_clienti.BackColor = System.Drawing.Color.RosyBrown;
            this.button_view_clienti.Location = new System.Drawing.Point(0, 260);
            this.button_view_clienti.Name = "button_view_clienti";
            this.button_view_clienti.Size = new System.Drawing.Size(119, 53);
            this.button_view_clienti.TabIndex = 4;
            this.button_view_clienti.Text = "Vizualizare Clienti";
            this.button_view_clienti.UseVisualStyleBackColor = false;
            this.button_view_clienti.Click += new System.EventHandler(this.button_view_clienti_Click);
            // 
            // button_view_angajati
            // 
            this.button_view_angajati.BackColor = System.Drawing.Color.RosyBrown;
            this.button_view_angajati.Location = new System.Drawing.Point(0, 207);
            this.button_view_angajati.Name = "button_view_angajati";
            this.button_view_angajati.Size = new System.Drawing.Size(119, 53);
            this.button_view_angajati.TabIndex = 2;
            this.button_view_angajati.Text = "Vizualizare Angajati";
            this.button_view_angajati.UseVisualStyleBackColor = false;
            this.button_view_angajati.Click += new System.EventHandler(this.button_view_angajati_Click);
            // 
            // button_view_animale
            // 
            this.button_view_animale.BackColor = System.Drawing.Color.RosyBrown;
            this.button_view_animale.Location = new System.Drawing.Point(0, 153);
            this.button_view_animale.Name = "button_view_animale";
            this.button_view_animale.Size = new System.Drawing.Size(119, 53);
            this.button_view_animale.TabIndex = 1;
            this.button_view_animale.Text = "Vizualizare Animale";
            this.button_view_animale.UseVisualStyleBackColor = false;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.RosyBrown;
            this.button_home.Location = new System.Drawing.Point(0, 101);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(119, 52);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "Acasa";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 808);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.button_modifica);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.side_panel);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_exit;
        private Button button_stergere;
        private Button button_modifica;
        private Button button_adauga;
        public DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Panel side_panel;
        private Button button_view_clienti;
        private Button button_view_angajati;
        private Button button_view_animale;
        private Button button_home;
    }
}