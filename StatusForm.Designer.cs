namespace FastConfig
{
    partial class StatusForm
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
            this.rtbProgress = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbProgress
            // 
            this.rtbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProgress.Location = new System.Drawing.Point(12, 12);
            this.rtbProgress.Name = "rtbProgress";
            this.rtbProgress.Size = new System.Drawing.Size(496, 249);
            this.rtbProgress.TabIndex = 0;
            this.rtbProgress.Text = "";
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 273);
            this.Controls.Add(this.rtbProgress);
            this.Name = "StatusForm";
            this.Text = "Progress";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbProgress;
    }
}