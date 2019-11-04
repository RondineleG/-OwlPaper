namespace WindowsApp
{
    partial class frmEx02
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
            this.btnOperadorLogico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperadorLogico
            // 
            this.btnOperadorLogico.Location = new System.Drawing.Point(98, 69);
            this.btnOperadorLogico.Name = "btnOperadorLogico";
            this.btnOperadorLogico.Size = new System.Drawing.Size(142, 82);
            this.btnOperadorLogico.TabIndex = 0;
            this.btnOperadorLogico.Text = "Operador Logico";
            this.btnOperadorLogico.UseVisualStyleBackColor = true;
            this.btnOperadorLogico.Click += new System.EventHandler(this.btnOperadorLogico_Click);
            // 
            // frmEx02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 243);
            this.Controls.Add(this.btnOperadorLogico);
            this.Name = "frmEx02";
            this.Text = "frmEx02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperadorLogico;
    }
}