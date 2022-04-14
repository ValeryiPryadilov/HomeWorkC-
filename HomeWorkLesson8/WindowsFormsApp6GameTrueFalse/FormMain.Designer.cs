namespace WindowsFormsApp6GameTrueFalse
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonTrue = new System.Windows.Forms.Button();
            this.buttonFalse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(634, 74);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFalse);
            this.panel1.Controls.Add(this.buttonTrue);
            this.panel1.Controls.Add(this.buttonGo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 121);
            this.panel1.TabIndex = 7;
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(12, 118);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(610, 166);
            this.labelText.TabIndex = 8;
            this.labelText.Text = "Вопрос";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.Location = new System.Drawing.Point(218, 16);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(196, 93);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Начать игру";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonTrue
            // 
            this.buttonTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrue.Location = new System.Drawing.Point(15, 16);
            this.buttonTrue.Name = "buttonTrue";
            this.buttonTrue.Size = new System.Drawing.Size(197, 93);
            this.buttonTrue.TabIndex = 1;
            this.buttonTrue.Text = "Верю";
            this.buttonTrue.UseVisualStyleBackColor = true;
            this.buttonTrue.Click += new System.EventHandler(this.buttonTrue_Click);
            // 
            // buttonFalse
            // 
            this.buttonFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFalse.Location = new System.Drawing.Point(420, 16);
            this.buttonFalse.Name = "buttonFalse";
            this.buttonFalse.Size = new System.Drawing.Size(197, 93);
            this.buttonFalse.TabIndex = 2;
            this.buttonFalse.Text = "Не верю";
            this.buttonFalse.UseVisualStyleBackColor = true;
            this.buttonFalse.Click += new System.EventHandler(this.buttonFalse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonFalse;
        private System.Windows.Forms.Button buttonTrue;
    }
}

