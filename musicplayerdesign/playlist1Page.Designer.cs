namespace musicplayerdesign
{
    partial class playlist1Page
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist1Page));
            PlayButton = new customButton.buttonCus();
            OpenFile = new customButton.buttonCus();
            NextButton = new customButton.buttonCus();
            PreviousButton = new customButton.buttonCus();
            SearchBox = new TextBox();
            SearchIcon = new PictureBox();
            MusicBar = new TrackBar();
            SpeakerBar = new TrackBar();
            Speaker = new PictureBox();
            AutoNextMusic = new customButton.buttonCus();
            PlayPanel = new Panel();
            OnRepeating = new PictureBox();
            OnAutoNext = new PictureBox();
            Repeating = new customButton.buttonCus();
            TotalTime = new ReaLTaiizor.Controls.MaterialLabel();
            CurrentTime = new ReaLTaiizor.Controls.MaterialLabel();
            ImageMusicPlaying2 = new PictureBox();
            MusicName = new ReaLTaiizor.Controls.MaterialLabel();
            CoverImage = new PictureBox();
            ImageMusicPlaying1 = new PictureBox();
            Trash = new customButton.buttonCus();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MusicBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeakerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Speaker).BeginInit();
            PlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OnRepeating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OnAutoNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageMusicPlaying2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoverImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageMusicPlaying1).BeginInit();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.Transparent;
            PlayButton.BackgroundColor = Color.Transparent;
            PlayButton.BackgroundImage = (Image)resources.GetObject("PlayButton.BackgroundImage");
            PlayButton.BackgroundImageLayout = ImageLayout.Zoom;
            PlayButton.BorderColor = Color.PaleVioletRed;
            PlayButton.BorderRadius = 36;
            PlayButton.BorderSize = 0;
            PlayButton.FlatAppearance.BorderSize = 0;
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.ForeColor = Color.White;
            PlayButton.Location = new Point(531, 622);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(76, 64);
            PlayButton.TabIndex = 0;
            PlayButton.TextColor = Color.White;
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click_1;
            // 
            // OpenFile
            // 
            OpenFile.BackColor = Color.Transparent;
            OpenFile.BackgroundColor = Color.Transparent;
            OpenFile.BackgroundImage = (Image)resources.GetObject("OpenFile.BackgroundImage");
            OpenFile.BackgroundImageLayout = ImageLayout.Center;
            OpenFile.BorderColor = Color.PaleVioletRed;
            OpenFile.BorderRadius = 40;
            OpenFile.BorderSize = 0;
            OpenFile.FlatAppearance.BorderSize = 0;
            OpenFile.FlatStyle = FlatStyle.Flat;
            OpenFile.ForeColor = Color.White;
            OpenFile.Location = new Point(21, 31);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(114, 78);
            OpenFile.TabIndex = 1;
            OpenFile.TextColor = Color.White;
            OpenFile.UseVisualStyleBackColor = false;
            OpenFile.Click += OpenFile_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Transparent;
            NextButton.BackgroundColor = Color.Transparent;
            NextButton.BackgroundImage = (Image)resources.GetObject("NextButton.BackgroundImage");
            NextButton.BackgroundImageLayout = ImageLayout.Center;
            NextButton.BorderColor = Color.PaleVioletRed;
            NextButton.BorderRadius = 40;
            NextButton.BorderSize = 0;
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(613, 621);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(76, 65);
            NextButton.TabIndex = 2;
            NextButton.TextColor = Color.White;
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click_1;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.Transparent;
            PreviousButton.BackgroundColor = Color.Transparent;
            PreviousButton.BackgroundImage = (Image)resources.GetObject("PreviousButton.BackgroundImage");
            PreviousButton.BackgroundImageLayout = ImageLayout.Center;
            PreviousButton.BorderColor = Color.PaleVioletRed;
            PreviousButton.BorderRadius = 10;
            PreviousButton.BorderSize = 0;
            PreviousButton.FlatAppearance.BorderSize = 0;
            PreviousButton.FlatStyle = FlatStyle.Flat;
            PreviousButton.ForeColor = Color.White;
            PreviousButton.Location = new Point(433, 613);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(92, 83);
            PreviousButton.TabIndex = 3;
            PreviousButton.TextColor = Color.White;
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click_1;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(303, 57);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(535, 27);
            SearchBox.TabIndex = 4;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // SearchIcon
            // 
            SearchIcon.BackgroundImage = Properties.Resources.search__1_;
            SearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            SearchIcon.Location = new Point(259, 45);
            SearchIcon.Name = "SearchIcon";
            SearchIcon.Size = new Size(38, 49);
            SearchIcon.TabIndex = 5;
            SearchIcon.TabStop = false;
            // 
            // MusicBar
            // 
            MusicBar.Location = new Point(290, 20);
            MusicBar.Name = "MusicBar";
            MusicBar.Size = new Size(625, 56);
            MusicBar.TabIndex = 6;
            MusicBar.TickStyle = TickStyle.None;
            MusicBar.Scroll += MusicBar_Scroll;
            // 
            // SpeakerBar
            // 
            SpeakerBar.Location = new Point(939, 648);
            SpeakerBar.Name = "SpeakerBar";
            SpeakerBar.Size = new Size(151, 56);
            SpeakerBar.TabIndex = 7;
            SpeakerBar.TickStyle = TickStyle.None;
            SpeakerBar.Scroll += SpeakerBar_Scroll;
            // 
            // Speaker
            // 
            Speaker.BackgroundImage = Properties.Resources.volume__1_;
            Speaker.BackgroundImageLayout = ImageLayout.Zoom;
            Speaker.Location = new Point(892, 640);
            Speaker.Name = "Speaker";
            Speaker.Size = new Size(41, 36);
            Speaker.TabIndex = 8;
            Speaker.TabStop = false;
            Speaker.Click += Speaker_Click;
            // 
            // AutoNextMusic
            // 
            AutoNextMusic.BackColor = Color.Transparent;
            AutoNextMusic.BackgroundColor = Color.Transparent;
            AutoNextMusic.BackgroundImage = Properties.Resources.fast_forward;
            AutoNextMusic.BackgroundImageLayout = ImageLayout.Zoom;
            AutoNextMusic.BorderColor = Color.PaleVioletRed;
            AutoNextMusic.BorderRadius = 40;
            AutoNextMusic.BorderSize = 0;
            AutoNextMusic.FlatAppearance.BorderSize = 0;
            AutoNextMusic.FlatStyle = FlatStyle.Flat;
            AutoNextMusic.ForeColor = Color.White;
            AutoNextMusic.Location = new Point(726, 77);
            AutoNextMusic.Name = "AutoNextMusic";
            AutoNextMusic.Size = new Size(51, 41);
            AutoNextMusic.TabIndex = 9;
            AutoNextMusic.TextColor = Color.White;
            AutoNextMusic.UseVisualStyleBackColor = false;
            AutoNextMusic.Click += AutoNextMusic_Click;
            // 
            // PlayPanel
            // 
            PlayPanel.Controls.Add(OnRepeating);
            PlayPanel.Controls.Add(OnAutoNext);
            PlayPanel.Controls.Add(AutoNextMusic);
            PlayPanel.Controls.Add(Repeating);
            PlayPanel.Controls.Add(MusicBar);
            PlayPanel.Controls.Add(TotalTime);
            PlayPanel.Controls.Add(CurrentTime);
            PlayPanel.Controls.Add(ImageMusicPlaying2);
            PlayPanel.Location = new Point(0, 553);
            PlayPanel.Name = "PlayPanel";
            PlayPanel.Size = new Size(1193, 310);
            PlayPanel.TabIndex = 10;
            // 
            // OnRepeating
            // 
            OnRepeating.BackgroundImage = Properties.Resources.Line;
            OnRepeating.BackgroundImageLayout = ImageLayout.Stretch;
            OnRepeating.Location = new Point(344, 119);
            OnRepeating.Name = "OnRepeating";
            OnRepeating.Size = new Size(60, 14);
            OnRepeating.TabIndex = 17;
            OnRepeating.TabStop = false;
            // 
            // OnAutoNext
            // 
            OnAutoNext.BackgroundImage = Properties.Resources.Line;
            OnAutoNext.BackgroundImageLayout = ImageLayout.Stretch;
            OnAutoNext.Location = new Point(726, 119);
            OnAutoNext.Name = "OnAutoNext";
            OnAutoNext.Size = new Size(51, 14);
            OnAutoNext.TabIndex = 16;
            OnAutoNext.TabStop = false;
            OnAutoNext.Click += OnAutoNext_Click;
            // 
            // Repeating
            // 
            Repeating.BackColor = Color.Transparent;
            Repeating.BackgroundColor = Color.Transparent;
            Repeating.BackgroundImage = Properties.Resources.repeat;
            Repeating.BackgroundImageLayout = ImageLayout.Zoom;
            Repeating.BorderColor = Color.PaleVioletRed;
            Repeating.BorderRadius = 10;
            Repeating.BorderSize = 0;
            Repeating.FlatAppearance.BorderSize = 0;
            Repeating.FlatStyle = FlatStyle.Flat;
            Repeating.ForeColor = Color.White;
            Repeating.Location = new Point(344, 82);
            Repeating.Name = "Repeating";
            Repeating.Size = new Size(60, 36);
            Repeating.TabIndex = 13;
            Repeating.TextColor = Color.White;
            Repeating.UseVisualStyleBackColor = false;
            Repeating.Click += Repeating_Click;
            // 
            // TotalTime
            // 
            TotalTime.AutoSize = true;
            TotalTime.Depth = 0;
            TotalTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TotalTime.Location = new Point(921, 29);
            TotalTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TotalTime.Name = "TotalTime";
            TotalTime.Size = new Size(41, 19);
            TotalTime.TabIndex = 14;
            TotalTime.Text = "00:00";
            // 
            // CurrentTime
            // 
            CurrentTime.AutoSize = true;
            CurrentTime.Depth = 0;
            CurrentTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            CurrentTime.Location = new Point(243, 29);
            CurrentTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CurrentTime.Name = "CurrentTime";
            CurrentTime.Size = new Size(41, 19);
            CurrentTime.TabIndex = 13;
            CurrentTime.Text = "00:00";
            // 
            // ImageMusicPlaying2
            // 
            ImageMusicPlaying2.Location = new Point(65, 20);
            ImageMusicPlaying2.Name = "ImageMusicPlaying2";
            ImageMusicPlaying2.Size = new Size(107, 103);
            ImageMusicPlaying2.TabIndex = 13;
            ImageMusicPlaying2.TabStop = false;
            // 
            // MusicName
            // 
            MusicName.AutoSize = true;
            MusicName.Depth = 0;
            MusicName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            MusicName.Location = new Point(303, 540);
            MusicName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MusicName.Name = "MusicName";
            MusicName.Size = new Size(43, 19);
            MusicName.TabIndex = 15;
            MusicName.Text = "Name";
            MusicName.Click += MusicName_Click;
            // 
            // CoverImage
            // 
            CoverImage.Dock = DockStyle.Top;
            CoverImage.Location = new Point(0, 0);
            CoverImage.Name = "CoverImage";
            CoverImage.Size = new Size(1193, 120);
            CoverImage.TabIndex = 11;
            CoverImage.TabStop = false;
            // 
            // ImageMusicPlaying1
            // 
            ImageMusicPlaying1.Location = new Point(743, 147);
            ImageMusicPlaying1.Name = "ImageMusicPlaying1";
            ImageMusicPlaying1.Size = new Size(390, 377);
            ImageMusicPlaying1.TabIndex = 12;
            ImageMusicPlaying1.TabStop = false;
            // 
            // Trash
            // 
            Trash.BackColor = Color.Transparent;
            Trash.BackgroundColor = Color.Transparent;
            Trash.BackgroundImage = Properties.Resources.trash_bin;
            Trash.BackgroundImageLayout = ImageLayout.Zoom;
            Trash.BorderColor = Color.PaleVioletRed;
            Trash.BorderRadius = 40;
            Trash.BorderSize = 0;
            Trash.FlatAppearance.BorderSize = 0;
            Trash.FlatStyle = FlatStyle.Flat;
            Trash.ForeColor = Color.White;
            Trash.Location = new Point(34, 473);
            Trash.Name = "Trash";
            Trash.Size = new Size(64, 51);
            Trash.TabIndex = 13;
            Trash.TextColor = Color.White;
            Trash.UseVisualStyleBackColor = false;
            Trash.Click += Trash_Click;
            // 
            // playlist1Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 240);
            Controls.Add(Trash);
            Controls.Add(NextButton);
            Controls.Add(PreviousButton);
            Controls.Add(PlayButton);
            Controls.Add(MusicName);
            Controls.Add(ImageMusicPlaying1);
            Controls.Add(Speaker);
            Controls.Add(SpeakerBar);
            Controls.Add(SearchIcon);
            Controls.Add(SearchBox);
            Controls.Add(OpenFile);
            Controls.Add(PlayPanel);
            Controls.Add(CoverImage);
            Name = "playlist1Page";
            Size = new Size(1193, 863);
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)MusicBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeakerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Speaker).EndInit();
            PlayPanel.ResumeLayout(false);
            PlayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OnRepeating).EndInit();
            ((System.ComponentModel.ISupportInitialize)OnAutoNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageMusicPlaying2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoverImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageMusicPlaying1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customButton.buttonCus PlayButton;
        private customButton.buttonCus OpenFile;
        private customButton.buttonCus NextButton;
        private customButton.buttonCus PreviousButton;
        private TextBox SearchBox;
        private PictureBox SearchIcon;
        private TrackBar MusicBar;
        private TrackBar SpeakerBar;
        private PictureBox Speaker;
        private customButton.buttonCus AutoNextMusic;
        private Panel PlayPanel;
        private PictureBox ImageMusicPlaying2;
        private PictureBox CoverImage;
        private PictureBox ImageMusicPlaying1;
        private customButton.buttonCus Repeating;
        private ReaLTaiizor.Controls.MaterialLabel MusicName;
        private ReaLTaiizor.Controls.MaterialLabel TotalTime;
        private ReaLTaiizor.Controls.MaterialLabel CurrentTime;
        private PictureBox OnRepeating;
        private PictureBox OnAutoNext;
        private customButton.buttonCus Trash;
    }
}
