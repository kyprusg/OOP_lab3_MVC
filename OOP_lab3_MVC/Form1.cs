using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab3_MVC
{
    public partial class Form1 : Form
    {
        private Model _model;

        public Form1()
        {
            InitializeComponent();

            _model = new Model();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            _model.SetA(trackBarA.Value);
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            _model.SetA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                _model.SetA(Int32.Parse(textBoxA.Text));
            }
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            _model.SetA(Int32.Parse(textBoxA.Text));
        }
    }
}

