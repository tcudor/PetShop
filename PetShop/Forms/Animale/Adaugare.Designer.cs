namespace PetShop.Forms.Animale
{
    partial class Adaugare
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
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_dataN = new System.Windows.Forms.DateTimePicker();
            this.button_adauga = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_sex.Location = new System.Drawing.Point(108, 224);
            this.comboBox_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(36, 23);
            this.comboBox_sex.TabIndex = 67;
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(142, 196);
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
            this.numericUpDown_id.TabIndex = 66;
            this.numericUpDown_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // dateTimePicker_dataN
            // 
            this.dateTimePicker_dataN.Location = new System.Drawing.Point(142, 256);
            this.dateTimePicker_dataN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_dataN.Name = "dateTimePicker_dataN";
            this.dateTimePicker_dataN.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker_dataN.TabIndex = 65;
            // 
            // button_adauga
            // 
            this.button_adauga.Location = new System.Drawing.Point(144, 329);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(82, 22);
            this.button_adauga.TabIndex = 64;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // textBox_descriere
            // 
            this.textBox_descriere.Location = new System.Drawing.Point(108, 128);
            this.textBox_descriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_descriere.Multiline = true;
            this.textBox_descriere.Name = "textBox_descriere";
            this.textBox_descriere.Size = new System.Drawing.Size(253, 56);
            this.textBox_descriere.TabIndex = 63;
            // 
            // textBox_rasa
            // 
            this.textBox_rasa.Location = new System.Drawing.Point(108, 98);
            this.textBox_rasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_rasa.Name = "textBox_rasa";
            this.textBox_rasa.Size = new System.Drawing.Size(253, 23);
            this.textBox_rasa.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 60;
            this.label7.Text = "Data Nasterii :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Sex : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "IdCumparator :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Descriere :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Rasa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 55;
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
            this.comboBox_categorie.Location = new System.Drawing.Point(108, 70);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(121, 23);
            this.comboBox_categorie.TabIndex = 68;
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 419);
            this.Controls.Add(this.comboBox_categorie);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.dateTimePicker_dataN);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.textBox_descriere);
            this.Controls.Add(this.textBox_rasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Adaugare";
            this.Text = "Adaugare";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_sex;
        private NumericUpDown numericUpDown_id;
        private DateTimePicker dateTimePicker_dataN;
        private Button button_adauga;
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