namespace Digital_Clock_Tinker
{
    partial class DigitalClock
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
            clockLabel = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            redButton = new Button();
            blueButton = new Button();
            greenButton = new Button();
            yellowButton = new Button();
            orangeButton = new Button();
            styleButton1 = new Button();
            styleButton3 = new Button();
            styleButton2 = new Button();
            SuspendLayout();
            // 
            // clockLabel
            // 
            clockLabel.BackColor = Color.Black;
            clockLabel.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point);
            clockLabel.ForeColor = Color.Red;
            clockLabel.Location = new Point(2, -3);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(796, 381);
            clockLabel.TabIndex = 0;
            clockLabel.Text = "Loading...\r\n\r\n";
            clockLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Location = new Point(12, 409);
            redButton.Name = "redButton";
            redButton.Size = new Size(33, 29);
            redButton.TabIndex = 1;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.Blue;
            blueButton.Location = new Point(168, 409);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(33, 29);
            blueButton.TabIndex = 3;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += blueButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.ForestGreen;
            greenButton.Location = new Point(129, 409);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(33, 29);
            greenButton.TabIndex = 4;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += greenButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Yellow;
            yellowButton.Location = new Point(90, 409);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(33, 29);
            yellowButton.TabIndex = 5;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += yellowButton_Click;
            // 
            // orangeButton
            // 
            orangeButton.BackColor = Color.Orange;
            orangeButton.Location = new Point(51, 409);
            orangeButton.Name = "orangeButton";
            orangeButton.Size = new Size(33, 29);
            orangeButton.TabIndex = 6;
            orangeButton.UseVisualStyleBackColor = false;
            orangeButton.Click += orangeButton_Click;
            // 
            // styleButton1
            // 
            styleButton1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton1.Location = new Point(207, 409);
            styleButton1.Name = "styleButton1";
            styleButton1.Size = new Size(94, 29);
            styleButton1.TabIndex = 7;
            styleButton1.Text = "style1";
            styleButton1.UseVisualStyleBackColor = true;
            styleButton1.Click += styleButton1_Click;
            // 
            // styleButton3
            // 
            styleButton3.Font = new Font("Ink Free", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton3.Location = new Point(407, 408);
            styleButton3.Name = "styleButton3";
            styleButton3.Size = new Size(94, 29);
            styleButton3.TabIndex = 8;
            styleButton3.Text = "style3";
            styleButton3.UseVisualStyleBackColor = true;
            styleButton3.Click += styleButton3_Click;
            // 
            // styleButton2
            // 
            styleButton2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            styleButton2.Location = new Point(307, 408);
            styleButton2.Name = "styleButton2";
            styleButton2.Size = new Size(94, 29);
            styleButton2.TabIndex = 9;
            styleButton2.Text = "style2";
            styleButton2.UseVisualStyleBackColor = true;
            styleButton2.Click += styleButton2_Click;
            // 
            // DigitalClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(styleButton2);
            Controls.Add(styleButton3);
            Controls.Add(styleButton1);
            Controls.Add(orangeButton);
            Controls.Add(yellowButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);
            Controls.Add(redButton);
            Controls.Add(clockLabel);
            Name = "DigitalClock";
            Text = "Digital Clock";
            Load += DigitalClock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Button redButton;
        private Button blueButton;
        private Button greenButton;
        private Button yellowButton;
        private Button orangeButton;
        private Button styleButton1;
        private Button styleButton3;
        private Button styleButton2;
    }
}