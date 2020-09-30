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
        private Random _rnd;
        public Smiles()
        {
            InitializeComponent();
            _rnd = new Random();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picHappy_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.FixedSingle;
            picFrown.BorderStyle = BorderStyle.None;
            picSmile.BorderStyle = BorderStyle.None;
            lblMessage.Text = "кликнули на первый рисунок";
            
            picFrown.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
            picSmile.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
        }

        private void picFrown_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.None;
            picFrown.BorderStyle = BorderStyle.FixedSingle;
            picSmile.BorderStyle = BorderStyle.None;
            lblMessage.Text = "кликнули на второй рисунок";
           
            picSmile.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
            picHappy.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
               
        }

        private void picSmile_Click(object sender, EventArgs e)
        {
            picHappy.BorderStyle = BorderStyle.None;
            picFrown.BorderStyle = BorderStyle.None;
            picSmile.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Text = "кликнули на третий рисунок";
            
            picHappy.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));
            picFrown.BackColor = Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void Smiles_Load(object sender, EventArgs e)
        {

        }
    }
}
