namespace ADateAtTheRacesV2
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
            this.components = new System.ComponentModel.Container();
            this.bettingParlorBox = new System.Windows.Forms.GroupBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bettingParlorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingParlorBox
            // 
            this.bettingParlorBox.Controls.Add(this.minimumBetLabel);
            this.bettingParlorBox.Controls.Add(this.joeBetLabel);
            this.bettingParlorBox.Controls.Add(this.bobBetLabel);
            this.bettingParlorBox.Controls.Add(this.joeRadioButton);
            this.bettingParlorBox.Controls.Add(this.alBetLabel);
            this.bettingParlorBox.Controls.Add(this.dogNumber);
            this.bettingParlorBox.Controls.Add(this.bobRadioButton);
            this.bettingParlorBox.Controls.Add(this.label1);
            this.bettingParlorBox.Controls.Add(this.raceButton);
            this.bettingParlorBox.Controls.Add(this.alRadioButton);
            this.bettingParlorBox.Controls.Add(this.nameLabel);
            this.bettingParlorBox.Controls.Add(this.betAmount);
            this.bettingParlorBox.Controls.Add(this.betButton);
            this.bettingParlorBox.Location = new System.Drawing.Point(11, 321);
            this.bettingParlorBox.Name = "bettingParlorBox";
            this.bettingParlorBox.Size = new System.Drawing.Size(737, 174);
            this.bettingParlorBox.TabIndex = 24;
            this.bettingParlorBox.TabStop = false;
            this.bettingParlorBox.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(57, 43);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(35, 13);
            this.minimumBetLabel.TabIndex = 18;
            this.minimumBetLabel.Text = "label1";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(186, 73);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(35, 13);
            this.joeBetLabel.TabIndex = 22;
            this.joeBetLabel.Text = "label1";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(186, 96);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(35, 13);
            this.bobBetLabel.TabIndex = 23;
            this.bobBetLabel.Text = "label2";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(60, 71);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 19;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(186, 119);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(35, 13);
            this.alBetLabel.TabIndex = 24;
            this.alBetLabel.Text = "label3";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(343, 145);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(50, 20);
            this.dogNumber.TabIndex = 29;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(60, 94);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 20;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "bucks on dog number";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(550, 71);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(102, 63);
            this.raceButton.TabIndex = 25;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(60, 117);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 21;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(57, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "name";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(181, 145);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(40, 20);
            this.betAmount.TabIndex = 28;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(100, 143);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 27;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // dog4
            // 
            this.dog4.Image = global::ADateAtTheRacesV2.Properties.Resources.images;
            this.dog4.Location = new System.Drawing.Point(71, 224);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(100, 50);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 22;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::ADateAtTheRacesV2.Properties.Resources.images;
            this.dog3.Location = new System.Drawing.Point(71, 158);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(100, 50);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 21;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::ADateAtTheRacesV2.Properties.Resources.images;
            this.dog2.Location = new System.Drawing.Point(71, 91);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(100, 50);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 20;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::ADateAtTheRacesV2.Properties.Resources.images;
            this.dog1.Location = new System.Drawing.Point(71, 21);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(100, 50);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 19;
            this.dog1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::ADateAtTheRacesV2.Properties.Resources.gross;
            this.racetrackPictureBox.Location = new System.Drawing.Point(71, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(677, 276);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 23;
            this.racetrackPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 490);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.bettingParlorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.bettingParlorBox.ResumeLayout(false);
            this.bettingParlorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.GroupBox bettingParlorBox;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Timer timer1;
    }
}

