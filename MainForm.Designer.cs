namespace Ethernal_Return_Match_Seacher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextLabel1 = new Label();
            Input_nick = new TextBox();
            Btn_Search = new Button();
            groupBox1 = new GroupBox();
            User_Info = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("Maplestory", 9F, FontStyle.Bold);
            TextLabel1.Location = new Point(41, 16);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(101, 13);
            TextLabel1.TabIndex = 0;
            TextLabel1.Text = "Input NickName";
            // 
            // Input_nick
            // 
            Input_nick.Font = new Font("Maplestory", 9F);
            Input_nick.Location = new Point(148, 11);
            Input_nick.Name = "Input_nick";
            Input_nick.Size = new Size(100, 21);
            Input_nick.TabIndex = 1;
            Input_nick.TextChanged += txtbox_TextChanged;
            // 
            // Btn_Search
            // 
            Btn_Search.Font = new Font("Maplestory", 9F);
            Btn_Search.Location = new Point(254, 11);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(75, 23);
            Btn_Search.TabIndex = 2;
            Btn_Search.Text = "Search";
            Btn_Search.UseVisualStyleBackColor = true;
            Btn_Search.Click += SearchBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(User_Info);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 398);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // User_Info
            // 
            User_Info.AutoSize = true;
            User_Info.Location = new Point(29, 30);
            User_Info.Name = "User_Info";
            User_Info.Size = new Size(0, 15);
            User_Info.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Search);
            Controls.Add(Input_nick);
            Controls.Add(TextLabel1);
            Name = "MainForm";
            Text = "Ethernal Return: Match Seacher";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel1;
        private TextBox Input_nick;
        private Button Btn_Search;
        private GroupBox groupBox1;
        private Label User_Info;
    }
}
