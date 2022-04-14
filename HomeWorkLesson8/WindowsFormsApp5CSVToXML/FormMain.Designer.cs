namespace WindowsFormsApp5CSVToXML
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
            this.buttonLoadFromCSV = new System.Windows.Forms.Button();
            this.buttonSaveToXML = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
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
            this.labelHeader.TabIndex = 5;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveToXML);
            this.panel1.Controls.Add(this.buttonLoadFromCSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 92);
            this.panel1.TabIndex = 6;
            // 
            // buttonLoadFromCSV
            // 
            this.buttonLoadFromCSV.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFromCSV.Name = "buttonLoadFromCSV";
            this.buttonLoadFromCSV.Size = new System.Drawing.Size(132, 68);
            this.buttonLoadFromCSV.TabIndex = 0;
            this.buttonLoadFromCSV.Text = "Открыть CSV файл";
            this.buttonLoadFromCSV.UseVisualStyleBackColor = true;
            this.buttonLoadFromCSV.Click += new System.EventHandler(this.buttonLoadFromCSV_Click);
            // 
            // buttonSaveToXML
            // 
            this.buttonSaveToXML.Location = new System.Drawing.Point(150, 12);
            this.buttonSaveToXML.Name = "buttonSaveToXML";
            this.buttonSaveToXML.Size = new System.Drawing.Size(132, 68);
            this.buttonSaveToXML.TabIndex = 1;
            this.buttonSaveToXML.Text = "Записать XML файл";
            this.buttonSaveToXML.UseVisualStyleBackColor = true;
            this.buttonSaveToXML.Click += new System.EventHandler(this.buttonSaveToXML_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxData.Location = new System.Drawing.Point(0, 74);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(634, 289);
            this.textBoxData.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 455);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveToXML;
        private System.Windows.Forms.Button buttonLoadFromCSV;
        private System.Windows.Forms.TextBox textBoxData;
    }
}

