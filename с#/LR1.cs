using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Smiles : Form
    {
        public Smiles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public 
        private void picHappy_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.FixedSingle;
            picFrown.BorderStyle = BorderStyle.None;
            picSmile.BorderStyle = BorderStyle.None;
            lblMessage.Text = "кликнули на первый рисунок";
            Random rnd = new Random(DateTime.Now.Millisecond);
            picFrown.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            picSmile.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void picFrown_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.None;
            picFrown.BorderStyle = BorderStyle.FixedSingle;
            picSmile.BorderStyle = BorderStyle.None;
            lblMessage.Text = "кликнули на второй рисунок";
            Random rnd = new Random(DateTime.Now.Millisecond);
            picSmile.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            picHappy.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
               
        }

        private void picSmile_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.None;
            picFrown.BorderStyle = BorderStyle.None;
            picSmile.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Text = "кликнули на третий рисунок";
            Random rnd = new Random(DateTime.Now.Millisecond);
            picHappy.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            picFrown.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static void Main()
        {
            Application.Run(new Smiles());
        }

        private void Smiles_Load(object sender, EventArgs e)
        {

        }
    }
}
