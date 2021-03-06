﻿namespace ExcelParser
{
    partial class MainForm
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
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.button_AddFile = new System.Windows.Forms.Button();
            this.button_EditFile = new System.Windows.Forms.Button();
            this.button_DeleteFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.Location = new System.Drawing.Point(12, 12);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Files.Size = new System.Drawing.Size(260, 95);
            this.listBox_Files.TabIndex = 0;
            // 
            // button_AddFile
            // 
            this.button_AddFile.Location = new System.Drawing.Point(12, 113);
            this.button_AddFile.Name = "button_AddFile";
            this.button_AddFile.Size = new System.Drawing.Size(83, 23);
            this.button_AddFile.TabIndex = 1;
            this.button_AddFile.Text = "Добавить";
            this.button_AddFile.UseVisualStyleBackColor = true;
            this.button_AddFile.Click += new System.EventHandler(this.button_AddFile_Click);
            // 
            // button_EditFile
            // 
            this.button_EditFile.Location = new System.Drawing.Point(101, 113);
            this.button_EditFile.Name = "button_EditFile";
            this.button_EditFile.Size = new System.Drawing.Size(83, 23);
            this.button_EditFile.TabIndex = 2;
            this.button_EditFile.Text = "Изменить";
            this.button_EditFile.UseVisualStyleBackColor = true;
            // 
            // button_DeleteFile
            // 
            this.button_DeleteFile.Location = new System.Drawing.Point(189, 113);
            this.button_DeleteFile.Name = "button_DeleteFile";
            this.button_DeleteFile.Size = new System.Drawing.Size(83, 23);
            this.button_DeleteFile.TabIndex = 3;
            this.button_DeleteFile.Text = "Удалить";
            this.button_DeleteFile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Соеденить файлы выделенных сотрудников";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Соеденить файлы всех сотрудников";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_DeleteFile);
            this.Controls.Add(this.button_EditFile);
            this.Controls.Add(this.button_AddFile);
            this.Controls.Add(this.listBox_Files);
            this.MaximumSize = new System.Drawing.Size(300, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Button button_AddFile;
        private System.Windows.Forms.Button button_EditFile;
        private System.Windows.Forms.Button button_DeleteFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

