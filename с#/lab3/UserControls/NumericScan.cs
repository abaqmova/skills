using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany.StudAbakumova
{
    public partial class NumericScan : UserControl
    {

        int iDecimalPlaces = 0;
        decimal mValue = 0;
        decimal mIncrement = 1;
        decimal mMinimum = 0;
        decimal mMaximum = 100;

        public int DecimalPlaces
        {
            get { return iDecimalPlaces; }
            set { iDecimalPlaces = value; }
        }
        public decimal Value
        {
            get { return mValue; }
            set { txtBox.Text = (mValue = value).ToString(); }
        }

        public decimal Increment
        {
            get { return mIncrement; }
            set { mIncrement = value; }
        }

        public decimal Minimum
        {
            get { return mMinimum; }
            set
            {
                if (Value < (mMinimum = value))
                    Value = mMinimum;
            }
        }

        public decimal Maximum
        {
            get { return mMaximum; }
            set
            {
                if (Value > (mMaximum = value))
                    Value = mMaximum;
            }
        }

        public NumericScan()
        {
            InitializeComponent();
            this.Width = 4 * this.Font.Height;
            this.Height = txtBox.PreferredHeight +
                SystemInformation.HorizontalScrollBarHeight;

        }

        private void TextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 0)
                return;
            decimal tmpValue;
            if (!Decimal.TryParse(txtBox.Text, out tmpValue))
                txtBox.Text = mValue.ToString();
            else
                mValue = tmpValue;

        }

        private void TextBoxOnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    OnValueChanged(EventArgs.Empty);
                    break;
            }

        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            ArrowButton btn = (ArrowButton)sender;
            decimal tmpValue = mValue;
            if (btn == btnLeft)
            {
                if ((tmpValue -= mIncrement) < mMinimum)
                    return;
            }
            else
            {
                if ((tmpValue += mIncrement) > mMaximum)
                    return;
            }
            this.Value = tmpValue;
            OnValueChanged(EventArgs.Empty);


        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(4 * this.Font.Height,
                txtBox.PreferredHeight +
                SystemInformation.HorizontalScrollBarHeight);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            btnLeft.Location = new Point(0, 0);
            btnLeft.Size = btnRight.Size = new Size(this.Width / 2,
                       this.Height - txtBox.Height);
            btnRight.Location = new Point(this.Width / 2, 0);
            txtBox.Location = new Point(0, this.Height / 2);
            txtBox.Size = new Size(this.Width, txtBox.PreferredHeight);



        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs args)
        {
            Value = Math.Min(mMaximum, mValue);
            Value = Math.Max(mMinimum, mValue);
            Value = Decimal.Round(mValue, iDecimalPlaces);
            if (ValueChanged != null)
                ValueChanged(this, args);
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            OnValueChanged(EventArgs.Empty);
        }

    }
}
