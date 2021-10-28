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
    public partial class ExitDialog : Form
    {

        SaveFileDialog saveFileDialog;

        public ExitDialog()
        {
            InitializeComponent();
        }

        public void btnSave_Click(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        public void btnDont_Click(Object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }

        public void btnCancel_Click(Object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;            
        }

        private void initialSaveDialog()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Choose your file save location";
            saveFileDialog.ShowDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
    }
}
