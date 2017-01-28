namespace SpeedCubeTimer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrUpdatesPerSecond = new System.Windows.Forms.Timer(this.components);
            this.txtScramble = new System.Windows.Forms.TextBox();
            this.lstBoxScores = new System.Windows.Forms.ListBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Bebas Neue Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 282);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(647, 87);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrUpdatesPerSecond
            // 
            this.tmrUpdatesPerSecond.Interval = 1;
            this.tmrUpdatesPerSecond.Tick += new System.EventHandler(this.tmrUpdatesPerSecond_Tick);
            // 
            // txtScramble
            // 
            this.txtScramble.BackColor = System.Drawing.SystemColors.Control;
            this.txtScramble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScramble.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtScramble.Location = new System.Drawing.Point(12, 23);
            this.txtScramble.Name = "txtScramble";
            this.txtScramble.ReadOnly = true;
            this.txtScramble.Size = new System.Drawing.Size(647, 33);
            this.txtScramble.TabIndex = 4;
            this.txtScramble.TabStop = false;
            this.txtScramble.Text = "SCRAMBLE";
            this.txtScramble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstBoxScores
            // 
            this.lstBoxScores.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxScores.FormattingEnabled = true;
            this.lstBoxScores.HorizontalScrollbar = true;
            this.lstBoxScores.ItemHeight = 16;
            this.lstBoxScores.Location = new System.Drawing.Point(665, 23);
            this.lstBoxScores.Name = "lstBoxScores";
            this.lstBoxScores.Size = new System.Drawing.Size(484, 260);
            this.lstBoxScores.TabIndex = 5;
            this.lstBoxScores.TabStop = false;
            // 
            // txtTimer
            // 
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTimer.Font = new System.Drawing.Font("Bebas Neue Bold", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(12, 51);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(647, 206);
            this.txtTimer.TabIndex = 6;
            this.txtTimer.TabStop = false;
            this.txtTimer.Text = "00:00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Best:";
            // 
            // txtBest
            // 
            this.txtBest.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBest.Location = new System.Drawing.Point(716, 287);
            this.txtBest.Name = "txtBest";
            this.txtBest.ReadOnly = true;
            this.txtBest.Size = new System.Drawing.Size(433, 22);
            this.txtBest.TabIndex = 8;
            this.txtBest.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 381);
            this.Controls.Add(this.txtBest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lstBoxScores);
            this.Controls.Add(this.txtScramble);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Bebas Neue Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Speed Cube Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrUpdatesPerSecond;
        private System.Windows.Forms.TextBox txtScramble;
        private System.Windows.Forms.ListBox lstBoxScores;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBest;
    }
}

