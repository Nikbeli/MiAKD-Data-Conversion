﻿namespace ConvertData
{
    partial class Main
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
			this.Close = new System.Windows.Forms.Button();
			this.Label_Date = new System.Windows.Forms.Label();
			this.comboBox_Date = new System.Windows.Forms.ComboBox();
			this.Label_FormatDate = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button_res = new System.Windows.Forms.Button();
			this.comboBox_format = new System.Windows.Forms.ComboBox();
			this.numericUpDown_operations = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button_convertToString = new System.Windows.Forms.Button();
			this.textBox_string = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button_converttodata = new System.Windows.Forms.Button();
			this.textBox_result = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_operations)).BeginInit();
			this.SuspendLayout();
			// 
			// Close
			// 
			this.Close.Location = new System.Drawing.Point(951, 511);
			this.Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(100, 28);
			this.Close.TabIndex = 0;
			this.Close.Text = "Закрыть";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.Close_Click);
			// 
			// Label_Date
			// 
			this.Label_Date.AutoSize = true;
			this.Label_Date.Location = new System.Drawing.Point(16, 11);
			this.Label_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label_Date.Name = "Label_Date";
			this.Label_Date.Size = new System.Drawing.Size(42, 16);
			this.Label_Date.TabIndex = 5;
			this.Label_Date.Text = "Дата:";
			// 
			// comboBox_Date
			// 
			this.comboBox_Date.FormattingEnabled = true;
			this.comboBox_Date.Location = new System.Drawing.Point(16, 226);
			this.comboBox_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox_Date.Name = "comboBox_Date";
			this.comboBox_Date.Size = new System.Drawing.Size(265, 24);
			this.comboBox_Date.TabIndex = 7;
			this.comboBox_Date.SelectedIndexChanged += new System.EventHandler(this.comboBox_Date_SelectedIndexChanged);
			// 
			// Label_FormatDate
			// 
			this.Label_FormatDate.AutoSize = true;
			this.Label_FormatDate.Location = new System.Drawing.Point(12, 207);
			this.Label_FormatDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label_FormatDate.Name = "Label_FormatDate";
			this.Label_FormatDate.Size = new System.Drawing.Size(157, 16);
			this.Label_FormatDate.TabIndex = 8;
			this.Label_FormatDate.Text = "Форматироварие даты";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 31);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// button_res
			// 
			this.button_res.Location = new System.Drawing.Point(332, 63);
			this.button_res.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_res.Name = "button_res";
			this.button_res.Size = new System.Drawing.Size(236, 28);
			this.button_res.TabIndex = 12;
			this.button_res.Text = "Изменить";
			this.button_res.UseVisualStyleBackColor = true;
			this.button_res.Click += new System.EventHandler(this.button_plus_Click);
			// 
			// comboBox_format
			// 
			this.comboBox_format.FormattingEnabled = true;
			this.comboBox_format.Location = new System.Drawing.Point(332, 98);
			this.comboBox_format.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox_format.Name = "comboBox_format";
			this.comboBox_format.Size = new System.Drawing.Size(235, 24);
			this.comboBox_format.TabIndex = 14;
			// 
			// numericUpDown_operations
			// 
			this.numericUpDown_operations.Location = new System.Drawing.Point(332, 31);
			this.numericUpDown_operations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.numericUpDown_operations.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown_operations.Name = "numericUpDown_operations";
			this.numericUpDown_operations.Size = new System.Drawing.Size(236, 22);
			this.numericUpDown_operations.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(332, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Изменение:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(608, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Конвертация:";
			// 
			// button_convertToString
			// 
			this.button_convertToString.Location = new System.Drawing.Point(611, 33);
			this.button_convertToString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_convertToString.Name = "button_convertToString";
			this.button_convertToString.Size = new System.Drawing.Size(279, 28);
			this.button_convertToString.TabIndex = 18;
			this.button_convertToString.Text = "Конвертировать в строку";
			this.button_convertToString.UseVisualStyleBackColor = true;
			this.button_convertToString.Click += new System.EventHandler(this.button_convertToString_Click);
			// 
			// textBox_string
			// 
			this.textBox_string.Location = new System.Drawing.Point(332, 228);
			this.textBox_string.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox_string.Name = "textBox_string";
			this.textBox_string.Size = new System.Drawing.Size(235, 22);
			this.textBox_string.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(328, 207);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Строковые данные";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(605, 207);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Конвертация:";
			// 
			// button_converttodata
			// 
			this.button_converttodata.Location = new System.Drawing.Point(612, 228);
			this.button_converttodata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_converttodata.Name = "button_converttodata";
			this.button_converttodata.Size = new System.Drawing.Size(277, 28);
			this.button_converttodata.TabIndex = 22;
			this.button_converttodata.Text = "Конвертация в дату";
			this.button_converttodata.UseVisualStyleBackColor = true;
			this.button_converttodata.Click += new System.EventHandler(this.button_converttodata_Click);
			// 
			// textBox_result
			// 
			this.textBox_result.Location = new System.Drawing.Point(16, 286);
			this.textBox_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox_result.Name = "textBox_result";
			this.textBox_result.Size = new System.Drawing.Size(265, 22);
			this.textBox_result.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 266);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(194, 16);
			this.label5.TabIndex = 24;
			this.label5.Text = "Результат форматирования";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_result);
			this.Controls.Add(this.button_converttodata);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_string);
			this.Controls.Add(this.button_convertToString);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown_operations);
			this.Controls.Add(this.comboBox_format);
			this.Controls.Add(this.button_res);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.Label_FormatDate);
			this.Controls.Add(this.comboBox_Date);
			this.Controls.Add(this.Label_Date);
			this.Controls.Add(this.Close);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Main";
			this.Text = "Lab 4: Convert Data";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_operations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.ComboBox comboBox_Date;
        private System.Windows.Forms.Label Label_FormatDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.NumericUpDown numericUpDown_operations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_convertToString;
        private System.Windows.Forms.TextBox textBox_string;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_converttodata;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label5;
    }
}
