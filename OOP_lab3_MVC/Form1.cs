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
            numericUpDownA.Text = _model.getA().ToString();
            trackBarA.Value = _model.getA();

            textBoxB.Text = _model.getB().ToString();
            numericUpDownB.Value = _model.getB();
            numericUpDownB.Text = _model.getB().ToString();
            trackBarB.Value = _model.getB();

            textBoxC.Text = _model.getC().ToString();
            numericUpDownC.Value = _model.getC();
            numericUpDownC.Text = _model.getC().ToString();
            trackBarC.Value = _model.getC();
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            _model.SetA(trackBarA.Value);
            trackBarA.Value = _model.getA();
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            _model.SetA(Decimal.ToInt32(numericUpDownA.Value));
            numericUpDownA.Value = _model.getA();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxA.Text, out int val))
                    _model.SetA(val);
                UpdateFromModel(this, null);
            }
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxA.Text, out int val))
                _model.SetA(val);
            UpdateFromModel(this, null);
        }
        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            _model.SetB(trackBarB.Value);
            trackBarB.Value = _model.getB();
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            _model.SetB(Decimal.ToInt32(numericUpDownB.Value));
            numericUpDownB.Value = _model.getB();

        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxB.Text, out int val))
                    _model.SetB(val);
                UpdateFromModel(this, null);
            }
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxB.Text, out int val))
                _model.SetB(val);
            UpdateFromModel(this, null);
        }
        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            _model.SetC(trackBarC.Value);
            trackBarC.Value = _model.getC();
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            _model.SetC(Decimal.ToInt32(numericUpDownC.Value));
            numericUpDownC.Value = _model.getC();
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxC.Text, out int val))
                    _model.SetC(val);
                UpdateFromModel(this, null);
            }
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxC.Text, out int val))
                _model.SetC(val);
            UpdateFromModel(this, null);
        }

        private void numericUpDownA_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownA.Text, out decimal val))
                _model.SetA((int)val);
            UpdateFromModel(this, null);
        }

        private void numericUpDownB_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownB.Text, out decimal val))
                _model.SetB((int)val);
            UpdateFromModel(this, null);
        }

        private void numericUpDownC_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownC.Text, out decimal val))
                _model.SetC((int)val);
            UpdateFromModel(this, null);
        }
    }
}

