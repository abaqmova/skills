using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class InputPasswords : Form
    {
        public InputPasswords()
        {
            InitializeComponent();
        }
        public InputPasswords(string windowTitle, string message)
        {
            InitializeComponent();

            this.Text = windowTitle;
            lblMessage.Text = message;
        }
        public static string Show(string windowTitle, string message)
        {
            using (InputPasswords inputDlg = new InputPasswords(windowTitle, message))
            {
                inputDlg.ShowDialog();
                return inputDlg.textInput.Text;
            }

        }

        private void flow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
