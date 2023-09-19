namespace ShotGunSpel
{
    partial class ShotgunSpel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShotgunSpel));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnMute = new Button();
            nameRequiredLabel = new Label();
            btnQuit = new Button();
            playerNameLabel = new Label();
            label4 = new Label();
            lblPlayerBullets2 = new Label();
            lblPlayerBullets = new Label();
            listBox1 = new ListBox();
            PlayAgainbtn = new Button();
            victorybtn = new Button();
            label2 = new Label();
            player2 = new Label();
            btnLoad = new Button();
            btnBlock = new Button();
            btnShoot = new Button();
            pictureBox2 = new PictureBox();
            txtPlayerName = new TextBox();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            InstructionstextBox = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 1);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1439, 861);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Khaki;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(btnMute);
            tabPage1.Controls.Add(nameRequiredLabel);
            tabPage1.Controls.Add(btnQuit);
            tabPage1.Controls.Add(playerNameLabel);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(lblPlayerBullets2);
            tabPage1.Controls.Add(lblPlayerBullets);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(PlayAgainbtn);
            tabPage1.Controls.Add(victorybtn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(player2);
            tabPage1.Controls.Add(btnLoad);
            tabPage1.Controls.Add(btnBlock);
            tabPage1.Controls.Add(btnShoot);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(txtPlayerName);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.ForeColor = SystemColors.Highlight;
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1431, 815);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ShotGun Game";
            // 
            // btnMute
            // 
            btnMute.BackColor = Color.Khaki;
            btnMute.BackgroundImage = (Image)resources.GetObject("btnMute.BackgroundImage");
            btnMute.BackgroundImageLayout = ImageLayout.Center;
            btnMute.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMute.ForeColor = SystemColors.InactiveCaptionText;
            btnMute.Location = new Point(1358, 21);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(46, 48);
            btnMute.TabIndex = 33;
            btnMute.UseVisualStyleBackColor = false;
            btnMute.Click += btnMute_Click;
            // 
            // nameRequiredLabel
            // 
            nameRequiredLabel.AutoSize = true;
            nameRequiredLabel.BackColor = Color.Khaki;
            nameRequiredLabel.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameRequiredLabel.ForeColor = Color.DarkGreen;
            nameRequiredLabel.Location = new Point(402, 52);
            nameRequiredLabel.Name = "nameRequiredLabel";
            nameRequiredLabel.Size = new Size(0, 31);
            nameRequiredLabel.TabIndex = 32;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.Khaki;
            btnQuit.Font = new Font("Algerian", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.DarkGreen;
            btnQuit.Location = new Point(579, 749);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(306, 52);
            btnQuit.TabIndex = 31;
            btnQuit.Text = "QUIT";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.BackColor = Color.Khaki;
            playerNameLabel.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            playerNameLabel.ForeColor = Color.DarkGreen;
            playerNameLabel.Location = new Point(109, 102);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(0, 34);
            playerNameLabel.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Khaki;
            label4.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(1125, 102);
            label4.Name = "label4";
            label4.Size = new Size(234, 34);
            label4.TabIndex = 29;
            label4.Text = "Thunder Bolt";
            // 
            // lblPlayerBullets2
            // 
            lblPlayerBullets2.AutoSize = true;
            lblPlayerBullets2.BackColor = Color.Khaki;
            lblPlayerBullets2.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayerBullets2.ForeColor = Color.DarkGreen;
            lblPlayerBullets2.Location = new Point(1148, 761);
            lblPlayerBullets2.Name = "lblPlayerBullets2";
            lblPlayerBullets2.Size = new Size(163, 34);
            lblPlayerBullets2.TabIndex = 28;
            lblPlayerBullets2.Text = "Bullet: 0";
            // 
            // lblPlayerBullets
            // 
            lblPlayerBullets.AutoSize = true;
            lblPlayerBullets.BackColor = Color.Khaki;
            lblPlayerBullets.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPlayerBullets.ForeColor = Color.DarkGreen;
            lblPlayerBullets.Location = new Point(109, 761);
            lblPlayerBullets.Name = "lblPlayerBullets";
            lblPlayerBullets.Size = new Size(163, 34);
            lblPlayerBullets.TabIndex = 27;
            lblPlayerBullets.Text = "Bullet: 0";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Khaki;
            listBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.DarkGreen;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(455, 228);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(577, 100);
            listBox1.TabIndex = 26;
            // 
            // PlayAgainbtn
            // 
            PlayAgainbtn.BackColor = Color.Khaki;
            PlayAgainbtn.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PlayAgainbtn.ForeColor = Color.DarkGreen;
            PlayAgainbtn.Location = new Point(608, 598);
            PlayAgainbtn.Name = "PlayAgainbtn";
            PlayAgainbtn.Size = new Size(244, 48);
            PlayAgainbtn.TabIndex = 23;
            PlayAgainbtn.Text = "Play again";
            PlayAgainbtn.UseVisualStyleBackColor = false;
            PlayAgainbtn.Click += PlayAgainbtn_Click;
            // 
            // victorybtn
            // 
            victorybtn.BackColor = Color.Khaki;
            victorybtn.Enabled = false;
            victorybtn.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            victorybtn.ForeColor = Color.DarkGreen;
            victorybtn.Location = new Point(608, 403);
            victorybtn.Name = "victorybtn";
            victorybtn.Size = new Size(244, 97);
            victorybtn.TabIndex = 22;
            victorybtn.Text = "ShotGun";
            victorybtn.UseVisualStyleBackColor = false;
            victorybtn.Click += victorybtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Khaki;
            label2.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(657, 191);
            label2.Name = "label2";
            label2.Size = new Size(144, 34);
            label2.TabIndex = 21;
            label2.Text = "Resullt";
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.BackColor = Color.Khaki;
            player2.Font = new Font("Algerian", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            player2.ForeColor = Color.DarkGreen;
            player2.Location = new Point(1071, 441);
            player2.Name = "player2";
            player2.Size = new Size(144, 34);
            player2.TabIndex = 19;
            player2.Text = "Resullt";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Khaki;
            btnLoad.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.DarkGreen;
            btnLoad.Location = new Point(250, 427);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(148, 48);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBlock
            // 
            btnBlock.BackColor = Color.Khaki;
            btnBlock.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBlock.ForeColor = Color.DarkGreen;
            btnBlock.Location = new Point(250, 519);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(148, 48);
            btnBlock.TabIndex = 9;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = false;
            btnBlock.Click += btnBlock_Click;
            // 
            // btnShoot
            // 
            btnShoot.BackColor = Color.Khaki;
            btnShoot.Font = new Font("Algerian", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnShoot.ForeColor = Color.DarkGreen;
            btnShoot.Location = new Point(250, 343);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(148, 48);
            btnShoot.TabIndex = 8;
            btnShoot.Text = "Shoot";
            btnShoot.UseVisualStyleBackColor = false;
            btnShoot.Click += btnShoot_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(1054, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 610);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtPlayerName
            // 
            txtPlayerName.BackColor = Color.Khaki;
            txtPlayerName.Font = new Font("Algerian", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPlayerName.ForeColor = Color.DarkGreen;
            txtPlayerName.Location = new Point(547, 6);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.PlaceholderText = "ENTER YOUR NAME";
            txtPlayerName.Size = new Size(348, 43);
            txtPlayerName.TabIndex = 2;
            txtPlayerName.TextAlign = HorizontalAlignment.Center;
            txtPlayerName.KeyDown += txtPlayerName_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 610);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Khaki;
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(InstructionstextBox);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1431, 815);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Instructions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Algerian", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(481, 24);
            label1.Name = "label1";
            label1.Size = new Size(434, 41);
            label1.TabIndex = 6;
            label1.Text = "How To Play ShotGun";
            // 
            // InstructionstextBox
            // 
            InstructionstextBox.BackColor = Color.Khaki;
            InstructionstextBox.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            InstructionstextBox.ForeColor = Color.DarkGreen;
            InstructionstextBox.Location = new Point(153, 86);
            InstructionstextBox.Name = "InstructionstextBox";
            InstructionstextBox.Size = new Size(1133, 681);
            InstructionstextBox.TabIndex = 5;
            InstructionstextBox.Text = "";
            // 
            // ShotgunSpel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1442, 863);
            Controls.Add(tabControl1);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "ShotgunSpel";
            Text = "ShotgunSpel";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private RichTextBox InstructionstextBox;
        private PictureBox pictureBox1;
        private TextBox txtPlayerName;
        private PictureBox pictureBox2;
        private Button btnLoad;
        private Button btnBlock;
        private Button btnShoot;
        private Label player2;
        private ListBox listBox1;
        private Button PlayAgainbtn;
        private Button victorybtn;
        private Label label2;
        private Label lblPlayerBullets;
        private Label lblPlayerBullets2;
        private Label label4;
        private Label playerNameLabel;
        private Button btnQuit;
        private Label nameRequiredLabel;
        private Button btnMute;
    }
}