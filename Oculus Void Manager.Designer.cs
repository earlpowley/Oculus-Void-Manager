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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DefaultBtn = new System.Windows.Forms.RadioButton();
            this.GreyBtn = new System.Windows.Forms.RadioButton();
            this.BlackLineBtn = new System.Windows.Forms.RadioButton();
            this.Text2112 = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.BlackDotsBtn = new System.Windows.Forms.RadioButton();
            this.CurrentLbl = new System.Windows.Forms.Label();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.gifBox = new System.Windows.Forms.PictureBox();
            this.CurrentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultBtn
            // 
            this.DefaultBtn.AutoSize = true;
            this.DefaultBtn.Location = new System.Drawing.Point(80, 70);
            this.DefaultBtn.Name = "DefaultBtn";
            this.DefaultBtn.Size = new System.Drawing.Size(183, 24);
            this.DefaultBtn.TabIndex = 0;
            this.DefaultBtn.TabStop = true;
            this.DefaultBtn.Text = "Default (White Lines)";
            this.DefaultBtn.UseVisualStyleBackColor = true;
            this.DefaultBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DefaultBtn_MouseClick);
            // 
            // GreyBtn
            // 
            this.GreyBtn.AutoSize = true;
            this.GreyBtn.Location = new System.Drawing.Point(80, 119);
            this.GreyBtn.Name = "GreyBtn";
            this.GreyBtn.Size = new System.Drawing.Size(106, 24);
            this.GreyBtn.TabIndex = 1;
            this.GreyBtn.TabStop = true;
            this.GreyBtn.Text = "Grey Dots";
            this.GreyBtn.UseVisualStyleBackColor = true;
            this.GreyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GreyBtn_MouseClick);
            // 
            // BlackLineBtn
            // 
            this.BlackLineBtn.AutoSize = true;
            this.BlackLineBtn.Location = new System.Drawing.Point(80, 170);
            this.BlackLineBtn.Name = "BlackLineBtn";
            this.BlackLineBtn.Size = new System.Drawing.Size(115, 24);
            this.BlackLineBtn.TabIndex = 2;
            this.BlackLineBtn.TabStop = true;
            this.BlackLineBtn.Text = "Black Lines";
            this.BlackLineBtn.UseVisualStyleBackColor = true;
            this.BlackLineBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlackLineBtn_MouseClick);
            // 
            // Text2112
            // 
            this.Text2112.AutoSize = true;
            this.Text2112.Location = new System.Drawing.Point(325, 26);
            this.Text2112.Name = "Text2112";
            this.Text2112.Size = new System.Drawing.Size(70, 20);
            this.Text2112.TabIndex = 3;
            this.Text2112.Text = "Current: ";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(56, 19);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(263, 29);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Oculus Void Manager";
            // 
            // BlackDotsBtn
            // 
            this.BlackDotsBtn.AutoSize = true;
            this.BlackDotsBtn.Location = new System.Drawing.Point(80, 220);
            this.BlackDotsBtn.Name = "BlackDotsBtn";
            this.BlackDotsBtn.Size = new System.Drawing.Size(111, 24);
            this.BlackDotsBtn.TabIndex = 5;
            this.BlackDotsBtn.TabStop = true;
            this.BlackDotsBtn.Text = "Black Dots";
            this.BlackDotsBtn.UseVisualStyleBackColor = true;
            this.BlackDotsBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlackDotsBtn_MouseClick);
            // 
            // CurrentLbl
            // 
            this.CurrentLbl.AutoSize = true;
            this.CurrentLbl.Location = new System.Drawing.Point(386, 26);
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
            this.DoneBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DoneBtn_MouseClick);
            // 
            // gifBox
            // 
            this.gifBox.Image = global::Oculus_Void_Manager.Properties.Resources.blackdot;
            this.gifBox.Location = new System.Drawing.Point(405, 70);
            this.gifBox.Name = "gifBox";
            this.gifBox.Size = new System.Drawing.Size(110, 174);
            this.gifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifBox.TabIndex = 9;
            this.gifBox.TabStop = false;
            // 
            // CurrentImage
            // 
            this.CurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentImage.Image = ((System.Drawing.Image)(resources.GetObject("CurrentImage.Image")));
            this.CurrentImage.Location = new System.Drawing.Point(318, 70);
            this.CurrentImage.Name = "CurrentImage";
            this.CurrentImage.Size = new System.Drawing.Size(197, 174);
            this.CurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentImage.TabIndex = 8;
            this.CurrentImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 321);
            this.Controls.Add(this.gifBox);
            this.Controls.Add(this.CurrentImage);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.CurrentLbl);
            this.Controls.Add(this.BlackDotsBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.Text2112);
            this.Controls.Add(this.BlackLineBtn);
            this.Controls.Add(this.GreyBtn);
            this.Controls.Add(this.DefaultBtn);
            this.Name = "Form1";
            this.Text = "OVM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DefaultBtn;
        private System.Windows.Forms.RadioButton GreyBtn;
        private System.Windows.Forms.RadioButton BlackLineBtn;
        private System.Windows.Forms.Label Text2112;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.RadioButton BlackDotsBtn;
        private System.Windows.Forms.Label CurrentLbl;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.PictureBox CurrentImage;
        private System.Windows.Forms.PictureBox gifBox;
    }
}

