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
            buttonCus1 = new customButton.buttonCus();
            buttonCus2 = new customButton.buttonCus();
            buttonCus3 = new customButton.buttonCus();
            buttonCus4 = new customButton.buttonCus();
            SuspendLayout();
            // 
            // buttonCus1
            // 
            buttonCus1.BackColor = Color.Transparent;
            buttonCus1.BackgroundColor = Color.Transparent;
            buttonCus1.BackgroundImage = (Image)resources.GetObject("buttonCus1.BackgroundImage");
            buttonCus1.BackgroundImageLayout = ImageLayout.Center;
            buttonCus1.BorderColor = Color.PaleVioletRed;
            buttonCus1.BorderRadius = 36;
            buttonCus1.BorderSize = 0;
            buttonCus1.FlatAppearance.BorderSize = 0;
            buttonCus1.FlatStyle = FlatStyle.Flat;
            buttonCus1.ForeColor = Color.White;
            buttonCus1.Location = new Point(531, 622);
            buttonCus1.Name = "buttonCus1";
            buttonCus1.Size = new Size(76, 64);
            buttonCus1.TabIndex = 0;
            buttonCus1.TextColor = Color.White;
            buttonCus1.UseVisualStyleBackColor = false;
            buttonCus1.Click += buttonCus1_Click;
            // 
            // buttonCus2
            // 
            buttonCus2.BackColor = Color.Transparent;
            buttonCus2.BackgroundColor = Color.Transparent;
            buttonCus2.BackgroundImage = (Image)resources.GetObject("buttonCus2.BackgroundImage");
            buttonCus2.BackgroundImageLayout = ImageLayout.Center;
            buttonCus2.BorderColor = Color.PaleVioletRed;
            buttonCus2.BorderRadius = 40;
            buttonCus2.BorderSize = 0;
            buttonCus2.FlatAppearance.BorderSize = 0;
            buttonCus2.FlatStyle = FlatStyle.Flat;
            buttonCus2.ForeColor = Color.White;
            buttonCus2.Location = new Point(21, 31);
            buttonCus2.Name = "buttonCus2";
            buttonCus2.Size = new Size(114, 78);
            buttonCus2.TabIndex = 1;
            buttonCus2.TextColor = Color.White;
            buttonCus2.UseVisualStyleBackColor = false;
            // 
            // buttonCus3
            // 
            buttonCus3.BackColor = Color.Transparent;
            buttonCus3.BackgroundColor = Color.Transparent;
            buttonCus3.BackgroundImage = (Image)resources.GetObject("buttonCus3.BackgroundImage");
            buttonCus3.BackgroundImageLayout = ImageLayout.Center;
            buttonCus3.BorderColor = Color.PaleVioletRed;
            buttonCus3.BorderRadius = 40;
            buttonCus3.BorderSize = 0;
            buttonCus3.FlatAppearance.BorderSize = 0;
            buttonCus3.FlatStyle = FlatStyle.Flat;
            buttonCus3.ForeColor = Color.White;
            buttonCus3.Location = new Point(613, 621);
            buttonCus3.Name = "buttonCus3";
            buttonCus3.Size = new Size(76, 65);
            buttonCus3.TabIndex = 2;
            buttonCus3.TextColor = Color.White;
            buttonCus3.UseVisualStyleBackColor = false;
            // 
            // buttonCus4
            // 
            buttonCus4.BackColor = Color.Transparent;
            buttonCus4.BackgroundColor = Color.Transparent;
            buttonCus4.BackgroundImage = (Image)resources.GetObject("buttonCus4.BackgroundImage");
            buttonCus4.BackgroundImageLayout = ImageLayout.Center;
            buttonCus4.BorderColor = Color.PaleVioletRed;
            buttonCus4.BorderRadius = 10;
            buttonCus4.BorderSize = 0;
            buttonCus4.FlatAppearance.BorderSize = 0;
            buttonCus4.FlatStyle = FlatStyle.Flat;
            buttonCus4.ForeColor = Color.White;
            buttonCus4.Location = new Point(433, 613);
            buttonCus4.Name = "buttonCus4";
            buttonCus4.Size = new Size(92, 83);
            buttonCus4.TabIndex = 3;
            buttonCus4.TextColor = Color.White;
            buttonCus4.UseVisualStyleBackColor = false;
            // 
            // playlist1Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 240);
            Controls.Add(buttonCus4);
            Controls.Add(buttonCus3);
            Controls.Add(buttonCus2);
            Controls.Add(buttonCus1);
            Name = "playlist1Page";
            Size = new Size(1193, 863);
            ResumeLayout(false);
        }

        #endregion

        private customButton.buttonCus buttonCus1;
        private customButton.buttonCus buttonCus2;
        private customButton.buttonCus buttonCus3;
        private customButton.buttonCus buttonCus4;
    }
}
