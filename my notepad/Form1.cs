using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace my_notepad
{
    public partial class MainForm : Form
    {
        ExitDialog exitDialog;        
        public MainForm()
        {
            InitializeComponent();
        }

       public void MainForm_Closing(Object sender, FormClosingEventArgs e)
        {
            exitDialog = new ExitDialog();
            DialogResult dr = exitDialog.ShowDialog();

            switch (dr)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                case DialogResult.Yes:

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        sfd.FilterIndex = 2;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(sfd.FileName, tbMainText.Text);
                        }
                    }

                    break;

                case DialogResult.No:

                    e.Cancel = false;
                    break;
                   
            }
        }

    }
}
