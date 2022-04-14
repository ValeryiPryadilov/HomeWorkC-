namespace WindowsFormsApp3GameEditor
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
            this.buttonSaveQuest = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxTrueFalse = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNumQuestion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumQuestion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(643, 74);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveQuest);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.checkBoxTrueFalse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownNumQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 57);
            this.panel1.TabIndex = 4;
            // 
            // buttonSaveQuest
            // 
            this.buttonSaveQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveQuest.Location = new System.Drawing.Point(485, 6);
            this.buttonSaveQuest.Name = "buttonSaveQuest";
            this.buttonSaveQuest.Size = new System.Drawing.Size(121, 42);
            this.buttonSaveQuest.TabIndex = 6;
            this.buttonSaveQuest.Text = "Сохранить";
            this.buttonSaveQuest.UseVisualStyleBackColor = true;
            this.buttonSaveQuest.Click += new System.EventHandler(this.buttonSaveQuest_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(358, 6);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 42);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(231, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxTrueFalse
            // 
            this.checkBoxTrueFalse.AutoSize = true;
            this.checkBoxTrueFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTrueFalse.Location = new System.Drawing.Point(128, 23);
            this.checkBoxTrueFalse.Name = "checkBoxTrueFalse";
            this.checkBoxTrueFalse.Size = new System.Drawing.Size(87, 24);
            this.checkBoxTrueFalse.TabIndex = 3;
            this.checkBoxTrueFalse.Text = "Правда";
            this.checkBoxTrueFalse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответ:";
            // 
            // numericUpDownNumQuestion
            // 
            this.numericUpDownNumQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownNumQuestion.Location = new System.Drawing.Point(15, 19);
            this.numericUpDownNumQuestion.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumQuestion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumQuestion.Name = "numericUpDownNumQuestion";
            this.numericUpDownNumQuestion.Size = new System.Drawing.Size(86, 29);
            this.numericUpDownNumQuestion.TabIndex = 1;
            this.numericUpDownNumQuestion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumQuestion.ValueChanged += new System.EventHandler(this.numericUpDownNumQuestion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер вопроса:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuestion.Location = new System.Drawing.Point(0, 98);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(643, 246);
            this.textBoxQuestion.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripMenuItem1,
            this.miExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(162, 22);
            this.miNew.Text = "Новый";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(162, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(162, 22);
            this.miSave.Text = "Сохранить";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(162, 22);
            this.miSaveAs.Text = "Сохранить как...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(162, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(180, 22);
            this.miAbout.Text = "О программе ...";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 401);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 440);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumQuestion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.CheckBox checkBoxTrueFalse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveQuest;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}

