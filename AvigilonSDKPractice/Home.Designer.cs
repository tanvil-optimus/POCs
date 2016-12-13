namespace AvigilonSDKPractice
{
    partial class Home
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
            this.m_AutoDiscoverChecked = new System.Windows.Forms.CheckBox();
            this.m_CreateInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_AutoDiscoverChecked
            // 
            this.m_AutoDiscoverChecked.AutoSize = true;
            this.m_AutoDiscoverChecked.Location = new System.Drawing.Point(38, 41);
            this.m_AutoDiscoverChecked.Name = "m_AutoDiscoverChecked";
            this.m_AutoDiscoverChecked.Size = new System.Drawing.Size(114, 17);
            this.m_AutoDiscoverChecked.TabIndex = 0;
            this.m_AutoDiscoverChecked.Text = "Auto Discover Site";
            this.m_AutoDiscoverChecked.UseVisualStyleBackColor = true;
            // 
            // m_CreateInstance
            // 
            this.m_CreateInstance.Location = new System.Drawing.Point(107, 135);
            this.m_CreateInstance.Name = "m_CreateInstance";
            this.m_CreateInstance.Size = new System.Drawing.Size(75, 23);
            this.m_CreateInstance.TabIndex = 1;
            this.m_CreateInstance.Text = "Go";
            this.m_CreateInstance.UseVisualStyleBackColor = true;
            this.m_CreateInstance.Click += new System.EventHandler(this.m_CreateInstance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_CreateInstance);
            this.Controls.Add(this.m_AutoDiscoverChecked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox m_AutoDiscoverChecked;
        private System.Windows.Forms.Button m_CreateInstance;
    }
}

