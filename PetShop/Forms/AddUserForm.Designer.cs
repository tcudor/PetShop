namespace PetShop.Forms
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.button_adauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(133, 85);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(125, 27);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_parola
            // 
            this.textBox_parola.Location = new System.Drawing.Point(133, 144);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '•';
            this.textBox_parola.Size = new System.Drawing.Size(125, 27);
            this.textBox_parola.TabIndex = 4;
            // 
            // button_adauga
            // 
            this.button_adauga.Location = new System.Drawing.Point(133, 205);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(94, 29);
            this.button_adauga.TabIndex = 6;
            this.button_adauga.Text = "Adauga";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 311);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_username;
        private TextBox textBox_parola;
        private Button button_adauga;
    }
}