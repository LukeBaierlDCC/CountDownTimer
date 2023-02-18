
namespace CountdownTimer
{
    partial class CountDownTimer
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
            this.TopLabel = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLabel
            // 
            this.TopLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopLabel.Font = new System.Drawing.Font("Pretendo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.Color.White;
            this.TopLabel.Location = new System.Drawing.Point(122, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(550, 57);
            this.TopLabel.TabIndex = 0;
            this.TopLabel.Text = "Count Down Timer";
            this.TopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerlabel
            // 
            this.timerlabel.BackColor = System.Drawing.Color.Transparent;
            this.timerlabel.Font = new System.Drawing.Font("Arcade Rounded", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.ForeColor = System.Drawing.Color.White;
            this.timerlabel.Location = new System.Drawing.Point(12, 134);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(732, 115);
            this.timerlabel.TabIndex = 1;
            this.timerlabel.Text = "60 Seconds";
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ResetButton.Font = new System.Drawing.Font("Pretendo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(32, 367);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 58);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkOrange;
            this.StartButton.Font = new System.Drawing.Font("Pretendo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(463, 367);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 58);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.DarkOrange;
            this.StopButton.Font = new System.Drawing.Font("Pretendo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(151, 431);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(316, 93);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.DarkOrange;
            this.PlusButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlusButton.Location = new System.Drawing.Point(638, 367);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(125, 58);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.DarkOrange;
            this.MinusButton.Font = new System.Drawing.Font("Commons", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(638, 448);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(125, 58);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // CountDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CountdownTimer.Properties.Resources.smooth_radio_station;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 746);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.TopLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CountDownTimer";
            this.Text = "Count Down Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
    }
}

