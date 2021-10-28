using System;
using System.Windows.Forms;
using System.Drawing;

namespace my_notepad
{
    partial class ExitDialog
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
            this.btnSave = new Button();
            this.btnDont = new Button();
            this.btnCancel = new Button();
            this.txtExit = new Label();
            this.pbPictureBox = new PictureBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(124, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "save";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDont
            // 
            this.btnDont.Location = new Point(205, 87);
            this.btnDont.Name = "btnDont";
            this.btnDont.Size = new Size(87, 23);
            this.btnDont.TabIndex = 1;
            this.btnDont.Text = "don\'t save";
            this.btnDont.Click += new EventHandler(this.btnDont_Click);
            this.btnDont.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(298, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "cancel";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // txtExit
            //        
            this.txtExit.Text = "Would you like to save changes?";
            this.txtExit.Location = new Point(90, 25);
            this.txtExit.AutoSize = true;
            this.txtExit.Font = new Font(this.txtExit.Font.FontFamily, 10);
            //
            // pbPictureBox
            //
            this.pbPictureBox.Location = new Point(20, 20);
            this.pbPictureBox.Size = new Size(32, 32);
            this.pbPictureBox.Image = (Image) new Bitmap("C:\\Users\\pandamin\\Pictures\\icons\\notepad32.png");            
            // 
            // ExitDialog
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(385, 122);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDont);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.pbPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitDialog";
            this.Text = "my notepad";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private Button btnDont;
        private Button btnCancel;
        private Label txtExit;
        private PictureBox pbPictureBox;
    }
}