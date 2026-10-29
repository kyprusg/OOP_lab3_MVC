using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab3_MVC
{
    internal class Model
    {
        private int _a;
        private int _b;
        private int _c;

        public System.EventHandler observers;

        public int getA()
        {
            return _a;
        }
        public int getB()
        {
            return _b;
        }
        public int getC()
        {
            return _c;
        }

        public Model()
        {
            Load();
        }

        public void SetA(int value)
        {
            value = Clamp(value, 0, 100);
            if (_a == value) return;

            _a = value;
            if (_a > _b) _b = _a;
            if (_a > _c) _c = _a;

            NotifyAndSave();
        }
        public void SetB(int value)
        {
            value = Clamp(value, 0, 100);

            if (value < _a) value = _a;
            if (value > _c) value = _c;

            if (_b == value) return;

            _b = value;
            NotifyAndSave();
        }
        public void SetC(int value)
        {
            value = Clamp(value, 0, 100);
            if (_c == value) return;

            _c = value;
            if (_c < _b) _b = _c;
            if (_c < _a) _a = _c;

            NotifyAndSave();
        }
        
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        private void NotifyAndSave()
        {
            Save();
            observers.Invoke(this, null);
        }
        private void Save()
        {
            Properties.Settings.Default.ValA = _a;
            Properties.Settings.Default.ValB = _b;
            Properties.Settings.Default.ValC = _c;

            Properties.Settings.Default.Save();
        }
        
        private void Load()
        {
            _a = Properties.Settings.Default.ValA;
            _b = Properties.Settings.Default.ValB;
            _c = Properties.Settings.Default.ValC;
        }
    }
}
