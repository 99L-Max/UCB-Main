﻿using System.Drawing;
using System.Windows.Forms;

namespace UCB
{
    partial class FormInfo : Form
    {
        public FormInfo(string text, Color backColor)
        {
            InitializeComponent();

            _txtBox.BackColor = backColor;
            _txtBox.Text = text.Replace("/t/", "\t");
        }
    }
}
