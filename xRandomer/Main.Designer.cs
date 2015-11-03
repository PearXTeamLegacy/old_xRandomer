﻿namespace xRandomer
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
            this.textCode = new System.Windows.Forms.TextBox();
            this.textFormat = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxDefaultFormat = new System.Windows.Forms.ListBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClearFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCode.Location = new System.Drawing.Point(12, 12);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(370, 38);
            this.textCode.TabIndex = 2;
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
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
            this.buttonGenerate.Location = new System.Drawing.Point(151, 83);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(113, 34);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Генерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(17, 141);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(371, 78);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
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
            this.buttonCopy.Location = new System.Drawing.Point(388, 12);
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
            this.buttonClearFormat.Location = new System.Drawing.Point(388, 56);
            this.buttonClearFormat.Name = "buttonClearFormat";
            this.buttonClearFormat.Size = new System.Drawing.Size(24, 24);
            this.buttonClearFormat.TabIndex = 6;
            this.buttonClearFormat.UseVisualStyleBackColor = true;
            this.buttonClearFormat.Click += new System.EventHandler(this.buttonClearFormat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 228);
            this.Controls.Add(this.buttonClearFormat);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.listBoxDefaultFormat);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textFormat);
            this.Controls.Add(this.textCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Randomer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxDefaultFormat;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClearFormat;


    }
}

