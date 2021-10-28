using System;
using System.Windows.Forms;
using System.Drawing;

namespace my_notepad
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
            this.tbMainText = new TextBox();
            this.SuspendLayout();
            // 
            // tbMainText
            // 
            this.tbMainText.BorderStyle = BorderStyle.None;
            this.tbMainText.Dock = DockStyle.Fill;
            this.tbMainText.Font = new Font("Consolas", 11F);
            this.tbMainText.Location = new Point(0, 0);
            this.tbMainText.Margin = new Padding(16);
            this.tbMainText.Multiline = true;
            this.tbMainText.Name = "tbMainText";
            this.tbMainText.ScrollBars = ScrollBars.Both;
            this.tbMainText.Size = new Size(694, 411);
            this.tbMainText.TabIndex = 0;
            this.tbMainText.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(694, 411);
            this.Controls.Add(this.tbMainText);
            this.Name = "MainForm";
            this.Text = "my notepad";
            this.FormClosing += new FormClosingEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMainText;
    }
}

