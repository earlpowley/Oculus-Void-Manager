namespace Oculus_Void_Manager
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
            this.DefaultBtn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Text2112 = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CurrentLbl = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.CurrentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultBtn
            // 
            this.DefaultBtn.AutoSize = true;
            this.DefaultBtn.Location = new System.Drawing.Point(108, 70);
            this.DefaultBtn.Name = "DefaultBtn";
            this.DefaultBtn.Size = new System.Drawing.Size(183, 24);
            this.DefaultBtn.TabIndex = 0;
            this.DefaultBtn.TabStop = true;
            this.DefaultBtn.Text = "Default (White Lines)";
            this.DefaultBtn.UseVisualStyleBackColor = true;
            this.DefaultBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(108, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Grey Dots";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(108, 170);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Black Lines";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Text2112
            // 
            this.Text2112.AutoSize = true;
            this.Text2112.Location = new System.Drawing.Point(355, 26);
            this.Text2112.Name = "Text2112";
            this.Text2112.Size = new System.Drawing.Size(70, 20);
            this.Text2112.TabIndex = 3;
            this.Text2112.Text = "Current: ";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(108, 25);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(161, 20);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Oculus Void Manager";
            this.TitleLbl.Click += new System.EventHandler(this.TitleLbl_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(108, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Black Dots";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CurrentLbl
            // 
            this.CurrentLbl.AutoSize = true;
            this.CurrentLbl.Location = new System.Drawing.Point(416, 26);
            this.CurrentLbl.Name = "CurrentLbl";
            this.CurrentLbl.Size = new System.Drawing.Size(129, 20);
            this.CurrentLbl.TabIndex = 6;
            this.CurrentLbl.Text = "<Current theme>";
            // 
            // DoneBtn
            // 
            this.DoneBtn.Location = new System.Drawing.Point(128, 260);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(130, 32);
            this.DoneBtn.TabIndex = 7;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            // 
            // CurrentImage
            // 
            this.CurrentImage.Location = new System.Drawing.Point(359, 70);
            this.CurrentImage.Name = "CurrentImage";
            this.CurrentImage.Size = new System.Drawing.Size(186, 174);
            this.CurrentImage.TabIndex = 8;
            this.CurrentImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 319);
            this.Controls.Add(this.CurrentImage);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.CurrentLbl);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Text2112);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.DefaultBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DefaultBtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label Text2112;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label CurrentLbl;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.PictureBox CurrentImage;
    }
}

