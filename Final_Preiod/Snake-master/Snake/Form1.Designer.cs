namespace Snake
{
    partial class SnakeForm
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
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Start_Btn = new System.Windows.Forms.Button();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            this.expectScore = new System.Windows.Forms.Label();
            this.expectScoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // GameCanvas
            // 
            this.GameCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameCanvas.Location = new System.Drawing.Point(5, 4);
            this.GameCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(724, 522);
            this.GameCanvas.TabIndex = 0;
            this.GameCanvas.TabStop = false;
            this.GameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.GameCanvas_Paint);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Start_Btn
            // 
            this.Start_Btn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start_Btn.Location = new System.Drawing.Point(5, 535);
            this.Start_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(136, 40);
            this.Start_Btn.TabIndex = 1;
            this.Start_Btn.Text = "開始 / 暫停";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.ScoreLbl.Location = new System.Drawing.Point(588, 546);
            this.ScoreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(50, 19);
            this.ScoreLbl.TabIndex = 4;
            this.ScoreLbl.Text = "分數 : ";
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.exit_btn.Location = new System.Drawing.Point(148, 535);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(136, 40);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.TabStop = false;
            this.exit_btn.Text = "離開";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // scoreText
            // 
            this.scoreText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(636, 535);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(90, 40);
            this.scoreText.TabIndex = 6;
            this.scoreText.Text = "label1";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expectScore
            // 
            this.expectScore.AutoSize = true;
            this.expectScore.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.expectScore.Location = new System.Drawing.Point(391, 546);
            this.expectScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expectScore.Name = "expectScore";
            this.expectScore.Size = new System.Drawing.Size(80, 19);
            this.expectScore.TabIndex = 7;
            this.expectScore.Text = "預期分數 : ";
            // 
            // expectScoreText
            // 
            this.expectScoreText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectScoreText.Location = new System.Drawing.Point(478, 535);
            this.expectScoreText.Name = "expectScoreText";
            this.expectScoreText.Size = new System.Drawing.Size(90, 40);
            this.expectScoreText.TabIndex = 8;
            this.expectScoreText.Text = "expectScoreText";
            this.expectScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 580);
            this.Controls.Add(this.expectScoreText);
            this.Controls.Add(this.expectScore);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.GameCanvas);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SnakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "越吃越長";
            this.Load += new System.EventHandler(this.SnakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameCanvas;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label expectScore;
        private System.Windows.Forms.Label expectScoreText;
    }
}

