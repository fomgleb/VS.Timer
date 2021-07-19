namespace Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonStartTimer = new System.Windows.Forms.Button();
            this.LabelHours = new System.Windows.Forms.Label();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonPauseTimer = new System.Windows.Forms.Button();
            this.ButtonStopTimer = new System.Windows.Forms.Button();
            this.TextBoxHours = new System.Windows.Forms.TextBox();
            this.TextBoxMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxSeconds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonStartTimer
            // 
            this.ButtonStartTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonStartTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonStartTimer.BackgroundImage")));
            this.ButtonStartTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStartTimer.Location = new System.Drawing.Point(387, 336);
            this.ButtonStartTimer.Name = "ButtonStartTimer";
            this.ButtonStartTimer.Size = new System.Drawing.Size(48, 58);
            this.ButtonStartTimer.TabIndex = 1;
            this.ButtonStartTimer.UseVisualStyleBackColor = false;
            this.ButtonStartTimer.Click += new System.EventHandler(this.ButtonStartTimer_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHours.Location = new System.Drawing.Point(136, 21);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(99, 108);
            this.LabelHours.TabIndex = 2;
            this.LabelHours.Text = "0";
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMinutes.Location = new System.Drawing.Point(354, 21);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(99, 108);
            this.LabelMinutes.TabIndex = 3;
            this.LabelMinutes.Text = "0";
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSeconds.Location = new System.Drawing.Point(567, 21);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(99, 108);
            this.LabelSeconds.TabIndex = 4;
            this.LabelSeconds.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(475, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 108);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(257, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 108);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // ButtonPauseTimer
            // 
            this.ButtonPauseTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonPauseTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPauseTimer.BackgroundImage")));
            this.ButtonPauseTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonPauseTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPauseTimer.Location = new System.Drawing.Point(471, 336);
            this.ButtonPauseTimer.Name = "ButtonPauseTimer";
            this.ButtonPauseTimer.Size = new System.Drawing.Size(39, 58);
            this.ButtonPauseTimer.TabIndex = 7;
            this.ButtonPauseTimer.UseVisualStyleBackColor = false;
            this.ButtonPauseTimer.Click += new System.EventHandler(this.ButtonPauseTimer_Click);
            // 
            // ButtonStopTimer
            // 
            this.ButtonStopTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonStopTimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonStopTimer.BackgroundImage")));
            this.ButtonStopTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStopTimer.Location = new System.Drawing.Point(302, 336);
            this.ButtonStopTimer.Name = "ButtonStopTimer";
            this.ButtonStopTimer.Size = new System.Drawing.Size(50, 58);
            this.ButtonStopTimer.TabIndex = 8;
            this.ButtonStopTimer.UseVisualStyleBackColor = false;
            this.ButtonStopTimer.Click += new System.EventHandler(this.ButtonStopTimer_Click);
            // 
            // TextBoxHours
            // 
            this.TextBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxHours.Location = new System.Drawing.Point(113, 212);
            this.TextBoxHours.Name = "TextBoxHours";
            this.TextBoxHours.Size = new System.Drawing.Size(137, 44);
            this.TextBoxHours.TabIndex = 9;
            // 
            // TextBoxMinutes
            // 
            this.TextBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxMinutes.Location = new System.Drawing.Point(333, 212);
            this.TextBoxMinutes.Name = "TextBoxMinutes";
            this.TextBoxMinutes.Size = new System.Drawing.Size(137, 44);
            this.TextBoxMinutes.TabIndex = 10;
            // 
            // TextBoxSeconds
            // 
            this.TextBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSeconds.Location = new System.Drawing.Point(546, 212);
            this.TextBoxSeconds.Name = "TextBoxSeconds";
            this.TextBoxSeconds.Size = new System.Drawing.Size(137, 44);
            this.TextBoxSeconds.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(344, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Минуты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(554, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Секунды";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(139, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Часы";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxSeconds);
            this.Controls.Add(this.TextBoxMinutes);
            this.Controls.Add(this.TextBoxHours);
            this.Controls.Add(this.ButtonStopTimer);
            this.Controls.Add(this.ButtonPauseTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.ButtonStartTimer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStartTimer;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonPauseTimer;
        private System.Windows.Forms.Button ButtonStopTimer;
        private System.Windows.Forms.TextBox TextBoxHours;
        private System.Windows.Forms.TextBox TextBoxMinutes;
        private System.Windows.Forms.TextBox TextBoxSeconds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}

