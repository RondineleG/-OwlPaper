namespace WindowsApp
{
    partial class frmPrincipal
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
            this.brtClick = new System.Windows.Forms.Button();
            this.btnEx01 = new System.Windows.Forms.Button();
            this.btnEx02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brtClick
            // 
            this.brtClick.Location = new System.Drawing.Point(178, 29);
            this.brtClick.Name = "brtClick";
            this.brtClick.Size = new System.Drawing.Size(75, 23);
            this.brtClick.TabIndex = 0;
            this.brtClick.Text = "Click";
            this.brtClick.UseVisualStyleBackColor = true;
            this.brtClick.Click += new System.EventHandler(this.brtClick_Click);
            // 
            // btnEx01
            // 
            this.btnEx01.Location = new System.Drawing.Point(1, 0);
            this.btnEx01.Name = "btnEx01";
            this.btnEx01.Size = new System.Drawing.Size(75, 23);
            this.btnEx01.TabIndex = 0;
            this.btnEx01.Text = "EX 01";
            this.btnEx01.UseVisualStyleBackColor = true;
            this.btnEx01.Click += new System.EventHandler(this.btnEx01_Click);
            // 
            // btnEx02
            // 
            this.btnEx02.Location = new System.Drawing.Point(1, 29);
            this.btnEx02.Name = "btnEx02";
            this.btnEx02.Size = new System.Drawing.Size(75, 23);
            this.btnEx02.TabIndex = 0;
            this.btnEx02.Text = "EX 02";
            this.btnEx02.UseVisualStyleBackColor = true;
            this.btnEx02.Click += new System.EventHandler(this.btnEx02_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 184);
            this.Controls.Add(this.btnEx02);
            this.Controls.Add(this.btnEx01);
            this.Controls.Add(this.brtClick);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brtClick;
        private System.Windows.Forms.Button btnEx01;
        private System.Windows.Forms.Button btnEx02;
    }
}

