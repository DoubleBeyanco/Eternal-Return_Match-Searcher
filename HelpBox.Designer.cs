namespace Ethernal_Return_Match_Searcher
{
    partial class HelpBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpBox));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            DC = new LinkLabel();
            Arca = new LinkLabel();
            Github = new LinkLabel();
            CloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(808, 289);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(458, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 496);
            label2.Name = "label2";
            label2.Size = new Size(90, 14);
            label2.TabIndex = 3;
            label2.Text = "인식 가능한 예시";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 496);
            label3.Name = "label3";
            label3.Size = new Size(90, 14);
            label3.TabIndex = 4;
            label3.Text = "인식 가능한 예시";
            // 
            // DC
            // 
            DC.AutoSize = true;
            DC.Location = new Point(871, 429);
            DC.Name = "DC";
            DC.Size = new Size(72, 14);
            DC.TabIndex = 5;
            DC.TabStop = true;
            DC.Text = "디시인사이드";
            // 
            // Arca
            // 
            Arca.AutoSize = true;
            Arca.Location = new Point(875, 459);
            Arca.Name = "Arca";
            Arca.Size = new Size(61, 14);
            Arca.TabIndex = 6;
            Arca.TabStop = true;
            Arca.Text = "아카라이브";
            // 
            // Github
            // 
            Github.AutoSize = true;
            Github.Location = new Point(879, 490);
            Github.Name = "Github";
            Github.Size = new Size(50, 14);
            Github.TabIndex = 7;
            Github.TabStop = true;
            Github.Text = "Github";
            Github.LinkClicked += Github_LinkClicked;
            // 
            // CloseBtn
            // 
            CloseBtn.Font = new Font("Maplestory", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            CloseBtn.Location = new Point(773, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(138, 44);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // HelpBox
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 519);
            Controls.Add(CloseBtn);
            Controls.Add(Github);
            Controls.Add(Arca);
            Controls.Add(DC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Maplestory", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HelpBox";
            Text = "HelpBox";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private LinkLabel DC;
        private LinkLabel Arca;
        private LinkLabel Github;
        private Button CloseBtn;
    }
}