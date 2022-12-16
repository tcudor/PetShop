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
            this.components = new System.ComponentModel.Container();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.button_modifica = new System.Windows.Forms.Button();
            this.button_adauga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_panel = new System.Windows.Forms.Panel();
            this.button_view_clienti = new System.Windows.Forms.Button();
            this.button_view_angajati = new System.Windows.Forms.Button();
            this.button_view_animale = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Lime;
            this.dataGridView1.Location = new System.Drawing.Point(128, 447);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 361);
            this.dataGridView1.TabIndex = 7;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(PetShop.Models.Client);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetShop.Properties.Resources.fundal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(128, 0);
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
            this.side_panel.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.button_view_clienti.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_clienti.FlatAppearance.BorderSize = 0;
            this.button_view_clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_clienti.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_clienti.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.button_view_angajati.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_angajati.FlatAppearance.BorderSize = 0;
            this.button_view_angajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_angajati.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_angajati.ForeColor = System.Drawing.SystemColors.InfoText;
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
            this.button_view_animale.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_animale.FlatAppearance.BorderSize = 0;
            this.button_view_animale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_animale.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_animale.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_view_animale.Location = new System.Drawing.Point(0, 153);
            this.button_view_animale.Name = "button_view_animale";
            this.button_view_animale.Size = new System.Drawing.Size(119, 53);
            this.button_view_animale.TabIndex = 1;
            this.button_view_animale.Text = "Vizualizare Animale";
            this.button_view_animale.UseVisualStyleBackColor = false;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_home.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_home.Location = new System.Drawing.Point(0, 101);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(119, 52);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "Acasa";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(127, 417);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(86, 34);
            this.button_refresh.TabIndex = 13;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click_1);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 808);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.button_modifica);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.side_panel);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private Button button_refresh;
        private DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private BindingSource clientBindingSource;
    }
}