﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            arrowButton1.ScrollButton = ScrollButton.Right;
            arrowButton2.ScrollButton = ScrollButton.Left;
            arrowButton3.ScrollButton = ScrollButton.Up;
            arrowButton4.ScrollButton = ScrollButton.Down;

        }
    }
}
