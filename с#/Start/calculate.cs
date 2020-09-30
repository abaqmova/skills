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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Calculate_Load(object sender, EventArgs e)
        {

        }
        private bool isNumber = false;

        private void TxtFirst_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber =
                e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
                || e.KeyCode == Keys.Back;
        }


        private void TxtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch (e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                        isNumber = true;
                    break;
                case '.':
                    if (box.Text.Length == 0)
                        break;
                    if (box.Text[0] == '-' && box.Text.Length == 1)
                        break;

                    if (box.Text.IndexOf(".") == -1)
                        isNumber = true;
                    break;
            }
            if (!isNumber)
                e.Handled = true;
        }
        private double numFirst, numSecond, numResult;

    
            private void btn_Clik(object sender, EventArgs e)
            {
                string strFirst = string.Copy(txtFirst.Text);
                string strSecond = string.Copy(txtSecond.Text);
                int pos = strFirst.IndexOf('.');
                if (pos != -1)
                {
                    strFirst = strFirst.Substring(0, pos)
                     + ','
                     + strFirst.Substring(pos + 1);
                }
                pos = strSecond.IndexOf('.');
                if (pos != -1)
                {
                    strSecond = strSecond.Substring(0, pos)
                     + ','
                     + strSecond.Substring(pos + 1);
                }
                if (txtFirst.Text.Length > 0)
                    numFirst = Convert.ToDouble(strFirst);
                else
                    numFirst = 0.0D;
                if (txtSecond.Text.Length > 0)
                    numSecond = Convert.ToDouble(strSecond);
                else
                    numSecond = 0.0D;

                string btnText = "";
                bool divideFlag = false;
                Button btn = (Button)sender;
                switch (btn.Name)
                {
                    case "btnIncrement":
                        btnText = "\"+\"";
                        numResult = numFirst + numSecond;
                        break;

                    case "btnDecrement":
                        btnText = "\"-\"";
                        numResult = numFirst - numSecond;
                        break;
                    case "btnIncrease":
                        btnText = "\"*\"";
                        numResult = numFirst * numSecond;
                        break;
                    case "btnSquare":
                    btnText = "\"Pow\"";//
                    numResult = Math.Pow(numFirst,2);
                    break;
                    case "btnDivide":
                        btnText = "\":\"";
                        if (Math.Abs(numSecond) < 1.0E-30)
                        {
                            MessageBox.Show(
                           "на ноль нельзя делить!",
                            "ОШИБКА",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Stop);
                            divideFlag = true;
                        }
                        else
                            numResult = numFirst / numSecond;
                        break;
                }
                System.Diagnostics.Debug.WriteLine("нажата кнопка " + btnText);
                if (!divideFlag)
                {
                    txtResult.Text = Convert.ToString(numResult);
                    this.Validate();
                }
            }
        }

       
}
