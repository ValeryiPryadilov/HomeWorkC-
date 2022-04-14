namespace HomeWorkNo7
{
    partial class Form2
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
            this.StartGame = new System.Windows.Forms.Button();
            this.ComputerNumText = new System.Windows.Forms.Label();
            this.PlusNumber = new System.Windows.Forms.Button();
            this.MultiNumber = new System.Windows.Forms.Button();
            this.UserNumText = new System.Windows.Forms.Label();
            this.MyNumber = new System.Windows.Forms.Label();
            this.Rollback = new System.Windows.Forms.Button();
            this.LevelNumber = new System.Windows.Forms.Label();
            this.MyScore = new System.Windows.Forms.Label();
            this.MyCount = new System.Windows.Forms.Label();
            this.ByeRollbackInfo = new System.Windows.Forms.Label();
            this.PlusOneCount = new System.Windows.Forms.Button();
            this.ByePlusCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Silver;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.Location = new System.Drawing.Point(300, 173);
            this.StartGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(94, 58);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // ComputerNumText
            // 
            this.ComputerNumText.AutoSize = true;
            this.ComputerNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputerNumText.ForeColor = System.Drawing.Color.Black;
            this.ComputerNumText.Location = new System.Drawing.Point(270, 46);
            this.ComputerNumText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComputerNumText.Name = "ComputerNumText";
            this.ComputerNumText.Size = new System.Drawing.Size(146, 24);
            this.ComputerNumText.TabIndex = 1;
            this.ComputerNumText.Text = "Нажмите Start";
            // 
            // PlusNumber
            // 
            this.PlusNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusNumber.Location = new System.Drawing.Point(105, 271);
            this.PlusNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlusNumber.Name = "PlusNumber";
            this.PlusNumber.Size = new System.Drawing.Size(130, 74);
            this.PlusNumber.TabIndex = 2;
            this.PlusNumber.Text = "+1";
            this.PlusNumber.UseVisualStyleBackColor = false;
            this.PlusNumber.Visible = false;
            this.PlusNumber.Click += new System.EventHandler(this.PlusNumber_Click);
            // 
            // MultiNumber
            // 
            this.MultiNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MultiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiNumber.Location = new System.Drawing.Point(465, 271);
            this.MultiNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MultiNumber.Name = "MultiNumber";
            this.MultiNumber.Size = new System.Drawing.Size(130, 74);
            this.MultiNumber.TabIndex = 3;
            this.MultiNumber.Text = "*2";
            this.MultiNumber.UseVisualStyleBackColor = false;
            this.MultiNumber.Visible = false;
            this.MultiNumber.Click += new System.EventHandler(this.MultiNumber_Click);
            // 
            // UserNumText
            // 
            this.UserNumText.AutoSize = true;
            this.UserNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNumText.Location = new System.Drawing.Point(288, 299);
            this.UserNumText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNumText.Name = "UserNumText";
            this.UserNumText.Size = new System.Drawing.Size(110, 20);
            this.UserNumText.TabIndex = 4;
            this.UserNumText.Text = "Ваше чиcло";
            this.UserNumText.Visible = false;
            // 
            // MyNumber
            // 
            this.MyNumber.AutoSize = true;
            this.MyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyNumber.Location = new System.Drawing.Point(335, 234);
            this.MyNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyNumber.Name = "MyNumber";
            this.MyNumber.Size = new System.Drawing.Size(27, 29);
            this.MyNumber.TabIndex = 5;
            this.MyNumber.Text = "0";
            this.MyNumber.Visible = false;
            // 
            // Rollback
            // 
            this.Rollback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Rollback.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rollback.Location = new System.Drawing.Point(14, 287);
            this.Rollback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rollback.Name = "Rollback";
            this.Rollback.Size = new System.Drawing.Size(59, 58);
            this.Rollback.TabIndex = 6;
            this.Rollback.Text = "↺";
            this.Rollback.UseVisualStyleBackColor = false;
            this.Rollback.Visible = false;
            this.Rollback.Click += new System.EventHandler(this.Rollback_Click);
            // 
            // LevelNumber
            // 
            this.LevelNumber.AutoSize = true;
            this.LevelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelNumber.Location = new System.Drawing.Point(14, 15);
            this.LevelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelNumber.Name = "LevelNumber";
            this.LevelNumber.Size = new System.Drawing.Size(95, 20);
            this.LevelNumber.TabIndex = 7;
            this.LevelNumber.Text = "Уровень 1";
            this.LevelNumber.Visible = false;
            // 
            // MyScore
            // 
            this.MyScore.AutoSize = true;
            this.MyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyScore.Location = new System.Drawing.Point(14, 141);
            this.MyScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyScore.Name = "MyScore";
            this.MyScore.Size = new System.Drawing.Size(82, 24);
            this.MyScore.TabIndex = 8;
            this.MyScore.Text = "Очки: 0";
            this.MyScore.Visible = false;
            // 
            // MyCount
            // 
            this.MyCount.AutoSize = true;
            this.MyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyCount.Location = new System.Drawing.Point(14, 187);
            this.MyCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyCount.Name = "MyCount";
            this.MyCount.Size = new System.Drawing.Size(85, 24);
            this.MyCount.TabIndex = 9;
            this.MyCount.Text = "Ходы: 6";
            this.MyCount.Visible = false;
            // 
            // ByeRollbackInfo
            // 
            this.ByeRollbackInfo.AutoSize = true;
            this.ByeRollbackInfo.Location = new System.Drawing.Point(15, 265);
            this.ByeRollbackInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ByeRollbackInfo.Name = "ByeRollbackInfo";
            this.ByeRollbackInfo.Size = new System.Drawing.Size(54, 15);
            this.ByeRollbackInfo.TabIndex = 10;
            this.ByeRollbackInfo.Text = "-5 очков";
            this.ByeRollbackInfo.Visible = false;
            // 
            // PlusOneCount
            // 
            this.PlusOneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusOneCount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlusOneCount.Location = new System.Drawing.Point(112, 187);
            this.PlusOneCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlusOneCount.MaximumSize = new System.Drawing.Size(40, 40);
            this.PlusOneCount.Name = "PlusOneCount";
            this.PlusOneCount.Size = new System.Drawing.Size(24, 25);
            this.PlusOneCount.TabIndex = 11;
            this.PlusOneCount.Text = "+";
            this.PlusOneCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PlusOneCount.UseVisualStyleBackColor = true;
            this.PlusOneCount.Visible = false;
            this.PlusOneCount.Click += new System.EventHandler(this.PlusOneCount_Click);
            // 
            // ByePlusCount
            // 
            this.ByePlusCount.AutoSize = true;
            this.ByePlusCount.Location = new System.Drawing.Point(140, 193);
            this.ByePlusCount.Name = "ByePlusCount";
            this.ByePlusCount.Size = new System.Drawing.Size(61, 15);
            this.ByePlusCount.TabIndex = 12;
            this.ByePlusCount.Text = "-15 очков";
            this.ByePlusCount.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.ByePlusCount);
            this.Controls.Add(this.PlusOneCount);
            this.Controls.Add(this.ByeRollbackInfo);
            this.Controls.Add(this.MyCount);
            this.Controls.Add(this.MyScore);
            this.Controls.Add(this.LevelNumber);
            this.Controls.Add(this.Rollback);
            this.Controls.Add(this.MyNumber);
            this.Controls.Add(this.UserNumText);
            this.Controls.Add(this.MultiNumber);
            this.Controls.Add(this.PlusNumber);
            this.Controls.Add(this.ComputerNumText);
            this.Controls.Add(this.StartGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label ComputerNumText;
        private System.Windows.Forms.Button PlusNumber;
        private System.Windows.Forms.Button MultiNumber;
        private System.Windows.Forms.Label UserNumText;
        private System.Windows.Forms.Label MyNumber;
        private System.Windows.Forms.Button Rollback;
        private System.Windows.Forms.Label LevelNumber;
        private System.Windows.Forms.Label MyScore;
        private System.Windows.Forms.Label MyCount;
        private System.Windows.Forms.Label ByeRollbackInfo;
        private System.Windows.Forms.Button PlusOneCount;
        private System.Windows.Forms.Label ByePlusCount;
    }
}