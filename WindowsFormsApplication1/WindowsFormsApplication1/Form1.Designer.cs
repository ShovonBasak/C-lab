namespace WindowsFormsApplication1
{
    partial class quizForm
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
            this.question = new System.Windows.Forms.Label();
            this.radioOption1 = new System.Windows.Forms.RadioButton();
            this.radioOption2 = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.finalScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(24, 26);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(0, 13);
            this.question.TabIndex = 0;
            // 
            // radioOption1
            // 
            this.radioOption1.AutoSize = true;
            this.radioOption1.Location = new System.Drawing.Point(27, 89);
            this.radioOption1.Name = "radioOption1";
            this.radioOption1.Size = new System.Drawing.Size(14, 13);
            this.radioOption1.TabIndex = 1;
            this.radioOption1.UseVisualStyleBackColor = true;
            // 
            // radioOption2
            // 
            this.radioOption2.AutoSize = true;
            this.radioOption2.Location = new System.Drawing.Point(27, 112);
            this.radioOption2.Name = "radioOption2";
            this.radioOption2.Size = new System.Drawing.Size(14, 13);
            this.radioOption2.TabIndex = 2;
            this.radioOption2.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(27, 162);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(175, 248);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(54, 26);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score: ";
            // 
            // timeLimit
            // 
            this.timeLimit.AutoSize = true;
            this.timeLimit.Location = new System.Drawing.Point(409, 9);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(60, 13);
            this.timeLimit.TabIndex = 6;
            this.timeLimit.Text = "Time Limit: ";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(225, 248);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 26);
            this.score.TabIndex = 7;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScore.Location = new System.Drawing.Point(200, 112);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(78, 33);
            this.finalScore.TabIndex = 8;
            this.finalScore.Text = "Score : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // quizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 315);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.radioOption2);
            this.Controls.Add(this.radioOption1);
            this.Controls.Add(this.question);
            this.Name = "quizForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.quizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton radioOption1;
        private System.Windows.Forms.RadioButton radioOption2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label timeLimit;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label finalScore;
        private System.Windows.Forms.Timer timer1;
    }
}

