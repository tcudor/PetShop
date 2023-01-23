namespace PetShop.Forms.Animale
{
    partial class Modificare
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
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button_modifica = new System.Windows.Forms.Button();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.numericUpDown_idcumparator = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_dataN = new System.Windows.Forms.DateTimePicker();
            this.textBox_descriere = new System.Windows.Forms.TextBox();
            this.textBox_rasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_categorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idcumparator)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(108, 45);
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
            this.numericUpDown_id.TabIndex = 58;
            this.numericUpDown_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "Dati id-ul :";
            // 
            // button_modifica
            // 
            this.button_modifica.Location = new System.Drawing.Point(140, 354);
            this.button_modifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Size = new System.Drawing.Size(82, 22);
            this.button_modifica.TabIndex = 54;
            this.button_modifica.Text = "Modifica";
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_sex.Location = new System.Drawing.Point(108, 230);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(36, 23);
            this.comboBox_sex.TabIndex = 79;
            // 
            // numericUpDown_idcumparator
            // 
            this.numericUpDown_idcumparator.Location = new System.Drawing.Point(142, 203);
            this.numericUpDown_idcumparator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_idcumparator.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_idcumparator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_idcumparator.Name = "numericUpDown_idcumparator";
            this.numericUpDown_idcumparator.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown_idcumparator.TabIndex = 78;
            this.numericUpDown_idcumparator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_idcumparator.ValueChanged += new System.EventHandler(this.numericUpDown_idcumparator_ValueChanged);
            // 
            // dateTimePicker_dataN
            // 
            this.dateTimePicker_dataN.Location = new System.Drawing.Point(142, 262);
            this.dateTimePicker_dataN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_dataN.Name = "dateTimePicker_dataN";
            this.dateTimePicker_dataN.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker_dataN.TabIndex = 77;
            // 
            // textBox_descriere
            // 
            this.textBox_descriere.Location = new System.Drawing.Point(108, 135);
            this.textBox_descriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_descriere.Multiline = true;
            this.textBox_descriere.Name = "textBox_descriere";
            this.textBox_descriere.Size = new System.Drawing.Size(253, 56);
            this.textBox_descriere.TabIndex = 76;
            // 
            // textBox_rasa
            // 
            this.textBox_rasa.Location = new System.Drawing.Point(108, 105);
            this.textBox_rasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_rasa.Name = "textBox_rasa";
            this.textBox_rasa.Size = new System.Drawing.Size(253, 23);
            this.textBox_rasa.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Data Nasterii :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "Sex : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "IdCumparator :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Descriere :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "Rasa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "Categorie :";
            // 
            // comboBox_categorie
            // 
            this.comboBox_categorie.FormattingEnabled = true;
            this.comboBox_categorie.Items.AddRange(new object[] {
            "Mamifer",
            "Pasare",
            "Reptila",
            "Peste"});
            this.comboBox_categorie.Location = new System.Drawing.Point(108, 75);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(121, 23);
            this.comboBox_categorie.TabIndex = 80;
            // 
            // Modificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 419);
            this.Controls.Add(this.comboBox_categorie);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.numericUpDown_idcumparator);
            this.Controls.Add(this.dateTimePicker_dataN);
            this.Controls.Add(this.textBox_descriere);
            this.Controls.Add(this.textBox_rasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_modifica);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Modificare";
            this.Text = "Modificare";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idcumparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown_id;
        private Label label9;
        private Button button_modifica;
        private ComboBox comboBox_sex;
        private NumericUpDown numericUpDown_idcumparator;
        private DateTimePicker dateTimePicker_dataN;
        private TextBox textBox_descriere;
        private TextBox textBox_rasa;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_categorie;
    }
}