namespace KeyboardTypingTest
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtInput = new TextBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            btnRestart = new Button();
            lblScore = new Label();
            flwPanelWords = new FlowLayoutPanel();
            picFinish = new PictureBox();
            lblRank = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFinish).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Cyan;
            btnStart.Image = Properties.Resources.start;
            btnStart.Location = new Point(555, 226);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(131, 63);
            btnStart.TabIndex = 0;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button1_Click_1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(47, 107);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(439, 36);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Location = new Point(12, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 36);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Teal;
            lblTime.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(486, 109);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 32);
            lblTime.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Teal;
            pictureBox2.Location = new Point(483, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 36);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnRestart
            // 
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.ForeColor = Color.Cyan;
            btnRestart.Image = Properties.Resources.restart;
            btnRestart.Location = new Point(694, 95);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(70, 69);
            btnRestart.TabIndex = 6;
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.FromArgb(0, 192, 192);
            lblScore.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Black;
            lblScore.Location = new Point(555, 110);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 29);
            lblScore.TabIndex = 7;
            // 
            // flwPanelWords
            // 
            flwPanelWords.BackColor = Color.White;
            flwPanelWords.Location = new Point(12, 12);
            flwPanelWords.Name = "flwPanelWords";
            flwPanelWords.Size = new Size(745, 77);
            flwPanelWords.TabIndex = 1;
            // 
            // picFinish
            // 
            picFinish.Image = Properties.Resources.trophy;
            picFinish.Location = new Point(0, 164);
            picFinish.Name = "picFinish";
            picFinish.Size = new Size(143, 125);
            picFinish.TabIndex = 8;
            picFinish.TabStop = false;
            picFinish.Visible = false;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRank.Location = new Point(116, 196);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(0, 42);
            lblRank.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(769, 301);
            Controls.Add(lblRank);
            Controls.Add(picFinish);
            Controls.Add(lblScore);
            Controls.Add(btnRestart);
            Controls.Add(lblTime);
            Controls.Add(pictureBox2);
            Controls.Add(txtInput);
            Controls.Add(btnStart);
            Controls.Add(flwPanelWords);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFinish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtInput;
        private PictureBox pictureBox1;
        private Label lblTime;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Button btnRestart;
        private ImageList imageList1;
        private Label lblScore;
        private FlowLayoutPanel flwPanelWords;
        private PictureBox picFinish;
        private Label lblRank;
    }
}
