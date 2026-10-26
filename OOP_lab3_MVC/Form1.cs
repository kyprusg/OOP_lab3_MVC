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
            _model.observers += new System.EventHandler(this.UpdateFromModel);
            UpdateFromModel(this, null);
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = _model.getA().ToString();
            numericUpDownA.Value = _model.getA();
            trackBarA.Value = _model.getA();

            textBoxB.Text = _model.getB().ToString();
            numericUpDownB.Value = _model.getB();
            trackBarB.Value = _model.getB();

            textBoxC.Text = _model.getC().ToString();
            numericUpDownC.Value = _model.getC();
            trackBarC.Value = _model.getC();
        }

        //======================================================================
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
        //===================================================================
        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            _model.SetB(trackBarB.Value);
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            _model.SetB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _model.SetB(Int32.Parse(textBoxB.Text));
            }
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            _model.SetB(Int32.Parse(textBoxB.Text));
        }
        //=============================================================
        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            _model.SetC(trackBarC.Value);
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            _model.SetC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _model.SetC(Int32.Parse(textBoxC.Text));
            }
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            _model.SetC(Int32.Parse(textBoxC.Text));
        }
    }
}

