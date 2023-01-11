namespace PetShop.Forms.Clienti
{
    partial class Stergere
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
            this.button_stergere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Location = new System.Drawing.Point(126, 35);
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
            this.numericUpDown_id.TabIndex = 6;
            this.numericUpDown_id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_id.ValueChanged += new System.EventHandler(this.numericUpDown_id_ValueChanged);
            // 
            // button_stergere
            // 
            this.button_stergere.Location = new System.Drawing.Point(101, 109);
            this.button_stergere.Name = "button_stergere";
            this.button_stergere.Size = new System.Drawing.Size(94, 29);
            this.button_stergere.TabIndex = 5;
            this.button_stergere.Text = "Stergere";
            this.button_stergere.UseVisualStyleBackColor = true;
            this.button_stergere.Click += new System.EventHandler(this.button_stergere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dati id-ul :";
            // 
            // Stergere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 176);
            this.Controls.Add(this.numericUpDown_id);
            this.Controls.Add(this.button_stergere);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Stergere";
            this.Text = "Stergere";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown_id;
        private Button button_stergere;
        private Label label1;
    }
}