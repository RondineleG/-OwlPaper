namespace WindowsApp
{
    partial class frmEx01
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
            this.btnCalculaMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculaMedia
            // 
            this.btnCalculaMedia.Location = new System.Drawing.Point(25, 67);
            this.btnCalculaMedia.Name = "btnCalculaMedia";
            this.btnCalculaMedia.Size = new System.Drawing.Size(103, 49);
            this.btnCalculaMedia.TabIndex = 0;
            this.btnCalculaMedia.Text = "Calcula Media";
            this.btnCalculaMedia.UseVisualStyleBackColor = true;
            this.btnCalculaMedia.Click += new System.EventHandler(this.btnCalculaMedia_Click);
            // 
            // frmEx01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 328);
            this.Controls.Add(this.btnCalculaMedia);
            this.Name = "frmEx01";
            this.Text = "frmEx01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaMedia;
    }
}