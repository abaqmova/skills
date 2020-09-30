using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MyCompany.StudAbakumova
{
    public partial class ClickmaticButton : Button
    {
        public ClickmaticButton()
        {
            InitializeComponent();
        }

        public ClickmaticButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        readonly int DELAY = 250 * (1 + SystemInformation.KeyboardDelay);
        readonly int SPEED = 405 - 12 * SystemInformation.KeyboardSpeed;

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = SPEED;
            this.OnClick(EventArgs.Empty);

        }
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            timer.Enabled = this.Capture
                && this.ClientRectangle.Contains(mevent.Location);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if ((mevent.Button & MouseButtons.Left) != 0)
            {
                timer.Interval = DELAY;
                timer.Start();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            timer.Stop();
        }

    }
}
