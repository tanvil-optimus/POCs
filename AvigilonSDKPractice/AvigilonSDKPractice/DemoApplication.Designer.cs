namespace AvigilonSDKPractice
{
    partial class DemoApplication
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
            this.listNvrSites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NVR Sites";
            // 
            // listNvrSites
            // 
            this.listNvrSites.FormattingEnabled = true;
            this.listNvrSites.Location = new System.Drawing.Point(16, 42);
            this.listNvrSites.Name = "listNvrSites";
            this.listNvrSites.Size = new System.Drawing.Size(116, 134);
            this.listNvrSites.TabIndex = 1;
            // 
            // DemoApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 407);
            this.Controls.Add(this.listNvrSites);
            this.Controls.Add(this.label1);
            this.Name = "DemoApplication";
            this.Text = "DemoApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listNvrSites;
    }
}