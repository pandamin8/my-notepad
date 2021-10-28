using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
