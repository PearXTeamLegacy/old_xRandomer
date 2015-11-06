namespace xRandomer
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textFormat = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBoxDefaultFormat = new System.Windows.Forms.ListBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClearFormat = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.backgroundWorkerAutoRandom = new System.ComponentModel.BackgroundWorker();
            this.textCode = new System.Windows.Forms.TextBox();
            this.groupBoxAutoGen = new System.Windows.Forms.GroupBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonAutoGenStop = new System.Windows.Forms.Button();
            this.buttonAutoGenStart = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.groupBoxAutoGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // textFormat
            // 
            this.textFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFormat.Location = new System.Drawing.Point(12, 56);
            this.textFormat.Name = "textFormat";
            this.textFormat.Size = new System.Drawing.Size(370, 21);
            this.textFormat.TabIndex = 1;
            this.textFormat.Text = "%num%%CHAR%%num%-%CHAR%-%num%-%CHAR%";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 83);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(368, 34);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxDefaultFormat
            // 
            this.listBoxDefaultFormat.FormattingEnabled = true;
            this.listBoxDefaultFormat.Items.AddRange(new object[] {
            "Пин-код",
            "Цифровой ключ (4 блока)",
            "Номер телефона",
            "Пароль",
            "Пароль (с символами)",
            "Сложный пароль",
            "Сложный пароль (с символами)"});
            this.listBoxDefaultFormat.Location = new System.Drawing.Point(418, 56);
            this.listBoxDefaultFormat.Name = "listBoxDefaultFormat";
            this.listBoxDefaultFormat.Size = new System.Drawing.Size(177, 95);
            this.listBoxDefaultFormat.TabIndex = 4;
            this.listBoxDefaultFormat.SelectedIndexChanged += new System.EventHandler(this.listBoxDefaultFormat_SelectedIndexChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(383, 12);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(207, 38);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClearFormat
            // 
            this.buttonClearFormat.Image = global::xRandomer.Properties.Resources.cross;
            this.buttonClearFormat.Location = new System.Drawing.Point(383, 55);
            this.buttonClearFormat.Name = "buttonClearFormat";
            this.buttonClearFormat.Size = new System.Drawing.Size(24, 24);
            this.buttonClearFormat.TabIndex = 6;
            this.buttonClearFormat.UseVisualStyleBackColor = true;
            this.buttonClearFormat.Click += new System.EventHandler(this.buttonClearFormat_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(9, 141);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(0, 13);
            this.labelHelp.TabIndex = 7;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(7, 143);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(371, 78);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // backgroundWorkerAutoRandom
            // 
            this.backgroundWorkerAutoRandom.WorkerSupportsCancellation = true;
            this.backgroundWorkerAutoRandom.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAutoRandom_DoWork);
            this.backgroundWorkerAutoRandom.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAutoRandom_RunWorkerCompleted);
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCode.Location = new System.Drawing.Point(10, 12);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(370, 38);
            this.textCode.TabIndex = 9;
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
            // 
            // groupBoxAutoGen
            // 
            this.groupBoxAutoGen.Controls.Add(this.pictureBoxLoading);
            this.groupBoxAutoGen.Controls.Add(this.buttonOpenFolder);
            this.groupBoxAutoGen.Controls.Add(this.label1);
            this.groupBoxAutoGen.Controls.Add(this.textBoxCount);
            this.groupBoxAutoGen.Controls.Add(this.buttonAutoGenStop);
            this.groupBoxAutoGen.Controls.Add(this.buttonAutoGenStart);
            this.groupBoxAutoGen.Location = new System.Drawing.Point(634, 12);
            this.groupBoxAutoGen.Name = "groupBoxAutoGen";
            this.groupBoxAutoGen.Size = new System.Drawing.Size(313, 209);
            this.groupBoxAutoGen.TabIndex = 10;
            this.groupBoxAutoGen.TabStop = false;
            this.groupBoxAutoGen.Text = "Авто-генерация";
            this.groupBoxAutoGen.Visible = false;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Location = new System.Drawing.Point(123, 105);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoading.TabIndex = 5;
            this.pictureBoxLoading.TabStop = false;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(6, 159);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(298, 44);
            this.buttonOpenFolder.TabIndex = 4;
            this.buttonOpenFolder.Text = "Открыть папку со сгенерированными кодами";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Генерировать штук:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(153, 68);
            this.textBoxCount.MaxLength = 9;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 2;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCount_KeyPress);
            // 
            // buttonAutoGenStop
            // 
            this.buttonAutoGenStop.Location = new System.Drawing.Point(163, 19);
            this.buttonAutoGenStop.Name = "buttonAutoGenStop";
            this.buttonAutoGenStop.Size = new System.Drawing.Size(144, 43);
            this.buttonAutoGenStop.TabIndex = 1;
            this.buttonAutoGenStop.Text = "Стоп";
            this.buttonAutoGenStop.UseVisualStyleBackColor = true;
            this.buttonAutoGenStop.Click += new System.EventHandler(this.buttonAutoGenStop_Click);
            // 
            // buttonAutoGenStart
            // 
            this.buttonAutoGenStart.Location = new System.Drawing.Point(6, 19);
            this.buttonAutoGenStart.Name = "buttonAutoGenStart";
            this.buttonAutoGenStart.Size = new System.Drawing.Size(150, 43);
            this.buttonAutoGenStart.TabIndex = 0;
            this.buttonAutoGenStart.Text = "Старт";
            this.buttonAutoGenStart.UseVisualStyleBackColor = true;
            this.buttonAutoGenStart.Click += new System.EventHandler(this.buttonAutoGenStart_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Image = global::xRandomer.Properties.Resources.plus;
            this.buttonPlus.Location = new System.Drawing.Point(601, 1);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(32, 32);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 230);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.groupBoxAutoGen);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonClearFormat);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.listBoxDefaultFormat);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Randomer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxAutoGen.ResumeLayout(false);
            this.groupBoxAutoGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBoxDefaultFormat;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClearFormat;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAutoRandom;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.GroupBox groupBoxAutoGen;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonAutoGenStop;
        private System.Windows.Forms.Button buttonAutoGenStart;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button buttonPlus;


    }
}

