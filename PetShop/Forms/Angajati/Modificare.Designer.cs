namespace PetShop.Forms.Angajati
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
            this.button_modifica = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_dataA = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dataN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_adresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_prenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // button_modifica
            // 
            this.button_modifica.Location = new System.Drawing.Point(165, 448);
            this.button_modifica.Name = "button_modifica";
            this.button_modifica.Size = new System.Drawing.Size(94, 29);
            this.button_modifica.TabIndex = 16;
            this.button_modifica.Text = "Modifica";
            this.button_modifica.UseVisualStyleBackColor = true;
            this.button_modifica.Click += new System.EventHandler(this.button_modifica_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dati id-ul :";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(133, 32);
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
            this.numericUpDown_id.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_id.TabIndex = 20;
            this.numericUpDown_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume :";
            // 
            // dateTimePicker_dataA
            // 
            this.dateTimePicker_dataA.Location = new System.Drawing.Point(165, 387);
            this.dateTimePicker_dataA.Name = "dateTimePicker_dataA";
            this.dateTimePicker_dataA.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_dataA.TabIndex = 18;
            // 
            // dateTimePicker_dataN
            // 
            this.dateTimePicker_dataN.Location = new System.Drawing.Point(163, 347);
            this.dateTimePicker_dataN.Name = "dateTimePicker_dataN";
            this.dateTimePicker_dataN.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_dataN.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Nasterii :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sex : ";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(133, 267);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(289, 27);
            this.textBox_email.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email :";
            // 
            // textBox_adresa
            // 
            this.textBox_adresa.Location = new System.Drawing.Point(133, 227);
            this.textBox_adresa.Name = "textBox_adresa";
            this.textBox_adresa.Size = new System.Drawing.Size(289, 27);
            this.textBox_adresa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa :";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(133, 187);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(289, 27);
            this.textBox_telefon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // textBox_prenume
            // 
            this.textBox_prenume.Location = new System.Drawing.Point(133, 147);
            this.textBox_prenume.Name = "textBox_prenume";
            this.textBox_prenume.Size = new System.Drawing.Size(289, 27);
            this.textBox_prenume.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume :";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(133, 107);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(290, 27);
            this.textBox_nume.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Data Angajarii :";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_sex.Location = new System.Drawing.Point(133, 307);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(41, 28);
            this.comboBox_sex.TabIndex = 80;
            // 
            // Modificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 559);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker_dataA);
            this.Controls.Add(this.dateTimePicker_dataN);
            this.Controls.Add(this.button_modifica);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_adresa);
            this.Controls.Add(this.textBox_telefon);
            this.Controls.Add(this.textBox_prenume);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Modificare";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_modifica;
        private Label label9;
        private NumericUpDown numericUpDown_id;
        private Label label1;
        private DateTimePicker dateTimePicker_dataA;
        private DateTimePicker dateTimePicker_dataN;
        private Label label7;
        private Label label6;
        private TextBox textBox_email;
        private Label label5;
        private TextBox textBox_adresa;
        private Label label4;
        private TextBox textBox_telefon;
        private Label label3;
        private TextBox textBox_prenume;
        private Label label2;
        private TextBox textBox_nume;
        private Label label8;
        private ComboBox comboBox_sex;
    }
}