namespace Quiz
{
    partial class Game
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
            this.AnswerA = new System.Windows.Forms.Button();
            this.AnswerB = new System.Windows.Forms.Button();
            this.AnswerC = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.WhichPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerA
            // 
            this.AnswerA.Location = new System.Drawing.Point(12, 274);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(776, 49);
            this.AnswerA.TabIndex = 0;
            this.AnswerA.Text = "Answer A";
            this.AnswerA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AnswerA.UseVisualStyleBackColor = true;
            this.AnswerA.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.Location = new System.Drawing.Point(12, 329);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(776, 52);
            this.AnswerB.TabIndex = 1;
            this.AnswerB.Text = "Answer B";
            this.AnswerB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AnswerB.UseVisualStyleBackColor = true;
            this.AnswerB.Click += new System.EventHandler(this.AnswerB_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.Location = new System.Drawing.Point(12, 387);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(776, 51);
            this.AnswerC.TabIndex = 2;
            this.AnswerC.Text = "Answer C";
            this.AnswerC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AnswerC.UseVisualStyleBackColor = true;
            this.AnswerC.Click += new System.EventHandler(this.AnswerC_Click);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 71);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(776, 200);
            this.Question.TabIndex = 3;
            this.Question.Text = "Question";
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(75, 9);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(162, 38);
            this.Player1.TabIndex = 4;
            this.Player1.Text = "Gracz 1: 0";
            this.Player1.Visible = false;
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(243, 9);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(162, 38);
            this.Player2.TabIndex = 5;
            this.Player2.Text = "Gracz 2: 0";
            this.Player2.Visible = false;
            // 
            // Player3
            // 
            this.Player3.Location = new System.Drawing.Point(411, 9);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(162, 38);
            this.Player3.TabIndex = 6;
            this.Player3.Text = "Gracz 3: 0";
            this.Player3.Visible = false;
            // 
            // Player4
            // 
            this.Player4.Location = new System.Drawing.Point(579, 9);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(162, 38);
            this.Player4.TabIndex = 7;
            this.Player4.Text = "Gracz 4: 0";
            this.Player4.Visible = false;
            // 
            // WhichPlayer
            // 
            this.WhichPlayer.Location = new System.Drawing.Point(12, 46);
            this.WhichPlayer.Name = "WhichPlayer";
            this.WhichPlayer.Size = new System.Drawing.Size(162, 25);
            this.WhichPlayer.TabIndex = 8;
            this.WhichPlayer.Text = "WhichPlayer";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WhichPlayer);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerA);
            this.Name = "Game";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AnswerA;
        private System.Windows.Forms.Button AnswerB;
        private System.Windows.Forms.Button AnswerC;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label WhichPlayer;
    }
}