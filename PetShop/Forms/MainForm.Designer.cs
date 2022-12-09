namespace PetShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.side_panel = new System.Windows.Forms.Panel();
            this.button_view_clienti = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_view_angajati = new System.Windows.Forms.Button();
            this.button_view_animale = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(131, 811);
            this.side_panel.TabIndex = 1;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PetShop.Properties.Resources.fundal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(126, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 811);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 808);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.side_panel);
            this.Name = "MainForm";
            this.Text = "PetShop";          
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel side_panel;
        private Button button_home;
        private Button button_exit;
        private Button button_view_angajati;
        private Button button_view_animale;
        private Button button_view_clienti;
        private PictureBox pictureBox1;
    }
}