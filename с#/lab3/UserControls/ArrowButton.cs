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
    
    public partial class ArrowButton : ClickmaticButton
    {
        public ArrowButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }

        public ArrowButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }

        System.Windows.Forms.ScrollButton scrollButton =
            System.Windows.Forms.ScrollButton.Right;
        public System.Windows.Forms.ScrollButton ScrollButton
        {
            set
            {
                scrollButton = value;
                this.Invalidate();
            }
            get
            {
                return
                    scrollButton;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics gr = pevent.Graphics;
            bool mouseInButton = this.Capture &&
                this.ClientRectangle.Contains(this.PointToClient(MousePosition));
            System.Windows.Forms.ButtonState buttonState =
                !this.Enabled ? ButtonState.Inactive
                : (mouseInButton ? ButtonState.Pushed
                : ButtonState.Normal);
            ControlPaint.DrawScrollButton(gr, this.ClientRectangle,
                scrollButton,
                buttonState);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
            this.Invalidate();
        }
    }
}


