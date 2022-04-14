namespace WindowsFormsApp4Birthdays
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
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
            this.labelHeader.Size = new System.Drawing.Size(624, 74);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveToFile);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.dateTimePickerBirthday);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 367);
            this.panel1.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(227, 74);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 367);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // listBoxList
            // 
            this.listBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 20;
            this.listBoxList.Location = new System.Drawing.Point(230, 74);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(394, 367);
            this.listBoxList.TabIndex = 7;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(12, 25);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(196, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(12, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "День рождения:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(12, 126);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(196, 22);
            this.dateTimePickerBirthday.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(196, 48);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 224);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 48);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(118, 224);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 48);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(12, 287);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(196, 49);
            this.buttonSaveToFile.TabIndex = 8;
            this.buttonSaveToFile.Text = "Сохранить в файле";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSaveToFile;
    }
}

