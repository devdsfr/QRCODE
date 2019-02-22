namespace TestCreateQRCode
{
    partial class Form1
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.imgOut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOut)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(28, 12);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(223, 20);
            this.txtData.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(102, 38);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // imgOut
            // 
            this.imgOut.Location = new System.Drawing.Point(28, 67);
            this.imgOut.Name = "imgOut";
            this.imgOut.Size = new System.Drawing.Size(230, 183);
            this.imgOut.TabIndex = 2;
            this.imgOut.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.imgOut);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.PictureBox imgOut;
    }
}

