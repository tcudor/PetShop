namespace PetShop.Forms
{
    partial class LoginForm
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
            this.Nume = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_admin = new System.Windows.Forms.Button();
            this.button_continua = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nume.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Nume.Location = new System.Drawing.Point(156, 120);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(69, 28);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parola.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Parola.Location = new System.Drawing.Point(156, 171);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(73, 28);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(250, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(250, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 34);
            this.textBox2.TabIndex = 3;
            // 
            // button_admin
            // 
            this.button_admin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_admin.FlatAppearance.BorderSize = 0;
            this.button_admin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_admin.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_admin.Location = new System.Drawing.Point(127, 43);
            this.button_admin.Margin = new System.Windows.Forms.Padding(2);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(392, 75);
            this.button_admin.TabIndex = 4;
            this.button_admin.Text = "Autentificare ca administrator";
            this.button_admin.UseVisualStyleBackColor = true;
           
            //
            // button_continua
            // 
            this.button_continua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_continua.FlatAppearance.BorderSize = 2;
            this.button_continua.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_continua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_continua.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_continua.Location = new System.Drawing.Point(486, 274);
            this.button_continua.Margin = new System.Windows.Forms.Padding(2);
            this.button_continua.Name = "button_continua";
            this.button_continua.Size = new System.Drawing.Size(172, 75);
            this.button_continua.TabIndex = 5;
            this.button_continua.Text = "Continua fara autentificare";
            this.button_continua.UseVisualStyleBackColor = true;
            this.button_continua.Click += new System.EventHandler(this.button_continua_Click);
            // 
            // button_login
            // 
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_login.FlatAppearance.BorderSize = 2;
            this.button_login.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login.Location = new System.Drawing.Point(250, 236);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(102, 34);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(658, 349);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_continua);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Nume);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nume;
        private Label Parola;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_admin;
        private Button button_continua;
        private Button button_login;
    }
}