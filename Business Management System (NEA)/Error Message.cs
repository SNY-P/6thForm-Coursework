using System;
using System.Windows.Forms;

namespace Business_Management_System__NEA_
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        FormOpener FO = new FormOpener();

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenLoginForm)); // create a new thread
            this.Close(); // close current form
            t.Start();  // start the thread
        }
    }
}