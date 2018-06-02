namespace MDI_Based_Rich_Text_Editor
{
    partial class Text_Viewer
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
            this.rtb_FileData = new System.Windows.Forms.RichTextBox();
            this.sfd_SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rtb_FileData
            // 
            this.rtb_FileData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_FileData.Location = new System.Drawing.Point(0, 0);
            this.rtb_FileData.Name = "rtb_FileData";
            this.rtb_FileData.Size = new System.Drawing.Size(459, 540);
            this.rtb_FileData.TabIndex = 0;
            this.rtb_FileData.Text = "";
            // 
            // Text_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 540);
            this.Controls.Add(this.rtb_FileData);
            this.Name = "Text_Viewer";
            this.Text = "Text Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Text_Viewer_FormClosed);
            this.Load += new System.EventHandler(this.Text_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_FileData;
        private System.Windows.Forms.SaveFileDialog sfd_SaveFile;
    }
}