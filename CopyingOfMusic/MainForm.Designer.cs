﻿namespace CopyingOfMusic
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
            this.btnChooseDirectoryTo = new System.Windows.Forms.Button();
            this.btnDirectoryFrom = new System.Windows.Forms.Button();
            this.progressCopying = new System.Windows.Forms.ProgressBar();
            this.songName = new System.Windows.Forms.TextBox();
            this.btnCopyMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.extensionsBox = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseDirectoryTo
            // 
            this.btnChooseDirectoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseDirectoryTo.Location = new System.Drawing.Point(12, 396);
            this.btnChooseDirectoryTo.Name = "btnChooseDirectoryTo";
            this.btnChooseDirectoryTo.Size = new System.Drawing.Size(313, 23);
            this.btnChooseDirectoryTo.TabIndex = 13;
            this.btnChooseDirectoryTo.Text = "Choose Directory To";
            this.btnChooseDirectoryTo.UseVisualStyleBackColor = true;
            this.btnChooseDirectoryTo.Click += new System.EventHandler(this.btnChooseDirectoryTo_Click);
            // 
            // btnDirectoryFrom
            // 
            this.btnDirectoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDirectoryFrom.Location = new System.Drawing.Point(12, 367);
            this.btnDirectoryFrom.Name = "btnDirectoryFrom";
            this.btnDirectoryFrom.Size = new System.Drawing.Size(313, 23);
            this.btnDirectoryFrom.TabIndex = 12;
            this.btnDirectoryFrom.Text = "Choose Directory From";
            this.btnDirectoryFrom.UseVisualStyleBackColor = true;
            this.btnDirectoryFrom.Click += new System.EventHandler(this.btnDirectoryFrom_Click);
            // 
            // progressCopying
            // 
            this.progressCopying.Location = new System.Drawing.Point(12, 338);
            this.progressCopying.Name = "progressCopying";
            this.progressCopying.Size = new System.Drawing.Size(313, 23);
            this.progressCopying.TabIndex = 11;
            // 
            // songName
            // 
            this.songName.Location = new System.Drawing.Point(12, 12);
            this.songName.Multiline = true;
            this.songName.Name = "songName";
            this.songName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.songName.Size = new System.Drawing.Size(313, 320);
            this.songName.TabIndex = 10;
            // 
            // btnCopyMusic
            // 
            this.btnCopyMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyMusic.Location = new System.Drawing.Point(16, 453);
            this.btnCopyMusic.Name = "btnCopyMusic";
            this.btnCopyMusic.Size = new System.Drawing.Size(170, 33);
            this.btnCopyMusic.TabIndex = 9;
            this.btnCopyMusic.Text = "Copy Music";
            this.btnCopyMusic.UseVisualStyleBackColor = true;
            this.btnCopyMusic.Click += new System.EventHandler(this.btnCopyMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose file extension to copy:";
            // 
            // extensionsBox
            // 
            this.extensionsBox.FormattingEnabled = true;
            this.extensionsBox.Items.AddRange(new object[] {
            "*.mp3",
            "*.jpeg",
            "*.jpg",
            "*.doc"});
            this.extensionsBox.Location = new System.Drawing.Point(204, 426);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(121, 21);
            this.extensionsBox.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(192, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 33);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 498);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.extensionsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseDirectoryTo);
            this.Controls.Add(this.btnDirectoryFrom);
            this.Controls.Add(this.progressCopying);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.btnCopyMusic);
            this.Name = "MainForm";
            this.Text = "Copy Music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseDirectoryTo;
        private System.Windows.Forms.Button btnDirectoryFrom;
        private System.Windows.Forms.ProgressBar progressCopying;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.Button btnCopyMusic;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox extensionsBox;
        private System.Windows.Forms.Button btnCancel;
    }
}

