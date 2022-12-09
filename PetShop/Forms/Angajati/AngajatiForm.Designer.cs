namespace PetShop.Forms
{
    partial class AngajatiForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.side_panel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_adauga = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 409);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 399);
            this.dataGridView1.TabIndex = 1;
            // 
            // side_panel
            // 
            this.side_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.side_panel.AutoSize = true;
            this.side_panel.BackColor = System.Drawing.Color.RosyBrown;
            this.side_panel.Controls.Add(this.button5);
            this.side_panel.Controls.Add(this.button4);
            this.side_panel.Controls.Add(this.button3);
            this.side_panel.Controls.Add(this.button2);
            this.side_panel.Controls.Add(this.button_home);
            this.side_panel.Location = new System.Drawing.Point(2, -3);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(131, 811);
            this.side_panel.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Location = new System.Drawing.Point(0, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Vizualizare Clienti";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Location = new System.Drawing.Point(0, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Iesire";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Location = new System.Drawing.Point(0, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vizualizare Angajati";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Location = new System.Drawing.Point(0, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Vizualizare Animale";
            this.button2.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop.Properties.Resources.fundal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(128, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 815);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_adauga
            // 
            this.button_adauga.Location = new System.Drawing.Point(795, 128);
            this.button_adauga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(104, 76);
            this.button_adauga.TabIndex = 4;
            this.button_adauga.Text = "Adaugare Angajat";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(906, 128);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 76);
            this.button7.TabIndex = 5;
            this.button7.Text = "Modificare Angajat";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1017, 128);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 76);
            this.button8.TabIndex = 6;
            this.button8.Text = "Stergere Angajat";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // AngajatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 808);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.side_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AngajatiForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DataGridView dataGridView1;
        private Panel side_panel;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button_home;
        private PictureBox pictureBox1;
        private Button button_adauga;
        private Button button7;
        private Button button8;
    }
}