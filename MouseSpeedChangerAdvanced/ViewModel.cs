using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseSpeedChangerAdvanced
{
    public class ViewModel : INotifyPropertyChanged
    {
        private double _mouseSpeed;
        private double _doubleClickSpeed;
        private double _scrollWheelSpeed;
        private bool _mouseButtonSwap;
        public event PropertyChangedEventHandler PropertyChanged;
        public bool MouseButtonSwap
        {
            get => _mouseButtonSwap;
            set
            {
                _mouseButtonSwap = value;
                OnPropertyChanged("MouseButtonSwap");
            }
        }
        public double MouseSpeed{
            get => _mouseSpeed;
            set
            {
                _mouseSpeed = value;
                OnPropertyChanged("MouseSpeed");
            }
        }
        public double DoubleClickSpeed
        {
            get => _doubleClickSpeed;
            set
            {
                _doubleClickSpeed = value;
                OnPropertyChanged("DoubleClickSpeed");
            }
        }
        public double ScrollWheelSpeed
        {
            get => _scrollWheelSpeed;
            set
            {
                _scrollWheelSpeed = value;
                OnPropertyChanged("ScrollWheelSpeed");
            }
        }
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}
