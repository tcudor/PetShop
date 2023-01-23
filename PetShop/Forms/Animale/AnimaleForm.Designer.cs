﻿namespace PetShop.Forms.Animale
{
    partial class AnimaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_up = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_adauga = new System.Windows.Forms.Button();
            this.button_modifica = new System.Windows.Forms.Button();
            this.button_stergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNastereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCumparatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.side_panel = new System.Windows.Forms.Panel();
            this.button_view_clienti = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_view_angajati = new System.Windows.Forms.Button();
            this.button_view_animale = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.panel_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_up.Controls.Add(this.pictureBox1);
            this.panel_up.Controls.Add(this.comboBox_ID);
            this.panel_up.Controls.Add(this.button_refresh);
            this.panel_up.Controls.Add(this.button1);
            this.panel_up.Controls.Add(this.numericUpDown_id);
            this.panel_up.Controls.Add(this.label2);
            this.panel_up.Controls.Add(this.comboBox1);
            this.panel_up.Controls.Add(this.label1);
            this.panel_up.Controls.Add(this.button_adauga);
            this.panel_up.Controls.Add(this.button_modifica);
            this.panel_up.Controls.Add(this.button_stergere);
            this.panel_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(1266, 71);
            this.panel_up.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Items.AddRange(new object[] {
            "IdAnimal",
            "IdCumparator"});
            this.comboBox_ID.Location = new System.Drawing.Point(409, 40);
            this.comboBox_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(133, 23);
            this.comboBox_ID.TabIndex = 25;
            // 
            // button_refresh
            // 
            this.button_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_refresh.Location = new System.Drawing.Point(650, 0);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(159, 71);
            this.button_refresh.TabIndex = 24;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "Aplica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(272, 42);
            this.numericUpDown_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_id.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_id.TabIndex = 21;
            this.numericUpDown_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cauta dupa id :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IdAnimal",
            "Categorie",
            "Rasa",
            "Descriere",
            "Sex",
            "Data nastere",
            "IdCumparator"});
            this.comboBox1.Location = new System.Drawing.Point(271, 3);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sorteaza dupa :";
            // 
            // button_adauga
            // 
            this.button_adauga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_adauga.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_adauga.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_adauga.FlatAppearance.BorderSize = 0;
            this.button_adauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adauga.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_adauga.Location = new System.Drawing.Point(809, 0);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(152, 71);
            this.button_adauga.TabIndex = 10;
            this.button_adauga.Text = "Adaugare Animal";
            this.button_adauga.UseVisualStyleBackColor = false;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button_modifica
            // 
            this.button_modifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_modifica.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_modifica.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_modifica.FlatAppearance.BorderSize = 0;
            this.button_modifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifica.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_modifica.Location = new System.Drawing.Point(961, 0);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Size = new System.Drawing.Size(165, 71);
            this.button_modifica.TabIndex = 11;
            this.button_modifica.Text = "Modificare Animal";
            this.button_modifica.UseVisualStyleBackColor = false;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // button_stergere
            // 
            this.button_stergere.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_stergere.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_stergere.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_stergere.FlatAppearance.BorderSize = 0;
            this.button_stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stergere.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_stergere.Location = new System.Drawing.Point(1126, 0);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(140, 71);
            this.button_stergere.TabIndex = 12;
            this.button_stergere.Text = "Stergere Animal";
            this.button_stergere.UseVisualStyleBackColor = false;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimalDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.rasaDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dataNastereDataGridViewTextBoxColumn,
            this.idCumparatorDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.DataSource = this.animalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Crimson;
            this.dataGridView1.Location = new System.Drawing.Point(112, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 65;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 535);
            this.dataGridView1.TabIndex = 17;
            // 
            // idAnimalDataGridViewTextBoxColumn
            // 
            this.idAnimalDataGridViewTextBoxColumn.DataPropertyName = "IdAnimal";
            this.idAnimalDataGridViewTextBoxColumn.HeaderText = "IdAnimal";
            this.idAnimalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAnimalDataGridViewTextBoxColumn.Name = "idAnimalDataGridViewTextBoxColumn";
            this.idAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rasaDataGridViewTextBoxColumn
            // 
            this.rasaDataGridViewTextBoxColumn.DataPropertyName = "Rasa";
            this.rasaDataGridViewTextBoxColumn.HeaderText = "Rasa";
            this.rasaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rasaDataGridViewTextBoxColumn.Name = "rasaDataGridViewTextBoxColumn";
            this.rasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNastereDataGridViewTextBoxColumn
            // 
            this.dataNastereDataGridViewTextBoxColumn.DataPropertyName = "DataNastere";
            this.dataNastereDataGridViewTextBoxColumn.HeaderText = "DataNastere";
            this.dataNastereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataNastereDataGridViewTextBoxColumn.Name = "dataNastereDataGridViewTextBoxColumn";
            this.dataNastereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCumparatorDataGridViewTextBoxColumn
            // 
            this.idCumparatorDataGridViewTextBoxColumn.DataPropertyName = "IdCumparator";
            this.idCumparatorDataGridViewTextBoxColumn.HeaderText = "IdCumparator";
            this.idCumparatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCumparatorDataGridViewTextBoxColumn.Name = "idCumparatorDataGridViewTextBoxColumn";
            this.idCumparatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(PetShop.Models.Animal);
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
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(121, 731);
            this.side_panel.TabIndex = 18;
            // 
            // button_view_clienti
            // 
            this.button_view_clienti.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_clienti.FlatAppearance.BorderSize = 0;
            this.button_view_clienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_clienti.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_clienti.Location = new System.Drawing.Point(0, 406);
            this.button_view_clienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view_clienti.Name = "button_view_clienti";
            this.button_view_clienti.Size = new System.Drawing.Size(113, 52);
            this.button_view_clienti.TabIndex = 4;
            this.button_view_clienti.Text = "Vizualizare Clienti";
            this.button_view_clienti.UseVisualStyleBackColor = false;
            this.button_view_clienti.Click += new System.EventHandler(this.button_view_clienti_Click_1);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(0, 516);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(113, 52);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Iesire";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // button_view_angajati
            // 
            this.button_view_angajati.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_angajati.FlatAppearance.BorderSize = 0;
            this.button_view_angajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_angajati.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_angajati.Location = new System.Drawing.Point(0, 296);
            this.button_view_angajati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view_angajati.Name = "button_view_angajati";
            this.button_view_angajati.Size = new System.Drawing.Size(113, 52);
            this.button_view_angajati.TabIndex = 2;
            this.button_view_angajati.Text = "Vizualizare Angajati";
            this.button_view_angajati.UseVisualStyleBackColor = false;
            this.button_view_angajati.Click += new System.EventHandler(this.button_view_angajati_Click_1);
            // 
            // button_view_animale
            // 
            this.button_view_animale.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_animale.FlatAppearance.BorderSize = 0;
            this.button_view_animale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_view_animale.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_view_animale.Location = new System.Drawing.Point(0, 186);
            this.button_view_animale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_view_animale.Name = "button_view_animale";
            this.button_view_animale.Size = new System.Drawing.Size(113, 52);
            this.button_view_animale.TabIndex = 1;
            this.button_view_animale.Text = "Vizualizare Animale";
            this.button_view_animale.UseVisualStyleBackColor = false;
            this.button_view_animale.Click += new System.EventHandler(this.button_view_animale_Click_1);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_home.Location = new System.Drawing.Point(0, 76);
            this.button_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(113, 52);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "Acasa";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click_1);
            // 
            // AnimaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_up);
            this.Controls.Add(this.side_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnimaleForm";
            this.Text = "AnimaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_up;
        private Button button_refresh;
        private Button button1;
        private NumericUpDown numericUpDown_id;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button button_adauga;
        private Button button_modifica;
        private Button button_stergere;
        private PictureBox pictureBox1;
        private Panel side_panel;
        private Button button_view_clienti;
        private Button button_exit;
        private Button button_view_angajati;
        private Button button_view_animale;
        private Button button_home;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idAnimalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rasaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNastereDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCumparatorDataGridViewTextBoxColumn;
        private BindingSource animalBindingSource;
        private ComboBox comboBox_ID;
    }
}