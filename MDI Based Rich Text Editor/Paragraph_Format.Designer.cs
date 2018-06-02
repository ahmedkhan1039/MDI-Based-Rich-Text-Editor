namespace MDI_Based_Rich_Text_Editor
{
    partial class Paragraph_Format
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_IncreaseIndent = new System.Windows.Forms.Button();
            this.btn_DecreaseIndent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Bullet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Center = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_OK);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paragraph";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(220, 76);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Paragraph_Format_Submit);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(138, 75);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Paragraph_Format_Submit);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_IncreaseIndent);
            this.groupBox4.Controls.Add(this.btn_DecreaseIndent);
            this.groupBox4.Location = new System.Drawing.Point(260, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 51);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Indent";
            // 
            // btn_IncreaseIndent
            // 
            this.btn_IncreaseIndent.BackColor = System.Drawing.Color.LightGray;
            this.btn_IncreaseIndent.Location = new System.Drawing.Point(6, 19);
            this.btn_IncreaseIndent.Name = "btn_IncreaseIndent";
            this.btn_IncreaseIndent.Size = new System.Drawing.Size(66, 23);
            this.btn_IncreaseIndent.TabIndex = 5;
            this.btn_IncreaseIndent.Text = "Increase";
            this.btn_IncreaseIndent.UseVisualStyleBackColor = false;
            this.btn_IncreaseIndent.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // btn_DecreaseIndent
            // 
            this.btn_DecreaseIndent.BackColor = System.Drawing.Color.LightGray;
            this.btn_DecreaseIndent.Location = new System.Drawing.Point(78, 19);
            this.btn_DecreaseIndent.Name = "btn_DecreaseIndent";
            this.btn_DecreaseIndent.Size = new System.Drawing.Size(66, 23);
            this.btn_DecreaseIndent.TabIndex = 6;
            this.btn_DecreaseIndent.Text = "Decrease";
            this.btn_DecreaseIndent.UseVisualStyleBackColor = false;
            this.btn_DecreaseIndent.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Bullet);
            this.groupBox3.Location = new System.Drawing.Point(190, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(64, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bullet";
            // 
            // btn_Bullet
            // 
            this.btn_Bullet.BackColor = System.Drawing.Color.LightGray;
            this.btn_Bullet.Location = new System.Drawing.Point(6, 19);
            this.btn_Bullet.Name = "btn_Bullet";
            this.btn_Bullet.Size = new System.Drawing.Size(52, 23);
            this.btn_Bullet.TabIndex = 4;
            this.btn_Bullet.Text = "Bullet";
            this.btn_Bullet.UseVisualStyleBackColor = false;
            this.btn_Bullet.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Center);
            this.groupBox2.Controls.Add(this.btn_Right);
            this.groupBox2.Controls.Add(this.btn_Left);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alignment";
            // 
            // btn_Center
            // 
            this.btn_Center.BackColor = System.Drawing.Color.LightGray;
            this.btn_Center.Location = new System.Drawing.Point(56, 19);
            this.btn_Center.Name = "btn_Center";
            this.btn_Center.Size = new System.Drawing.Size(46, 23);
            this.btn_Center.TabIndex = 2;
            this.btn_Center.Text = "Center";
            this.btn_Center.UseVisualStyleBackColor = false;
            this.btn_Center.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // btn_Right
            // 
            this.btn_Right.BackColor = System.Drawing.Color.LightGray;
            this.btn_Right.Location = new System.Drawing.Point(108, 19);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(49, 23);
            this.btn_Right.TabIndex = 3;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = false;
            this.btn_Right.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // btn_Left
            // 
            this.btn_Left.BackColor = System.Drawing.Color.LightGray;
            this.btn_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Left.Location = new System.Drawing.Point(6, 19);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(44, 23);
            this.btn_Left.TabIndex = 1;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = false;
            this.btn_Left.Click += new System.EventHandler(this.Set_Button_State);
            // 
            // Paragraph_Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 129);
            this.Controls.Add(this.groupBox1);
            this.Name = "Paragraph_Format";
            this.Text = "Format Paragraph";
            this.Load += new System.EventHandler(this.Paragraph_Format_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_IncreaseIndent;
        private System.Windows.Forms.Button btn_DecreaseIndent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Bullet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Center;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}