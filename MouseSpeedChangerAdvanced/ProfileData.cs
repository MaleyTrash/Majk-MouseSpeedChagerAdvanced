using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseSpeedChangerAdvanced
{
    public class ProfileData : INotifyPropertyChanged
    {
        private string _profileName;
        private double _mouseSpeed = 3;
        private double _doubleClickSpeed = 500;
        private double _scrollWheelSpeed = 3;
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
        public double MouseSpeed
        {
            get => _mouseSpeed;
            set
            {
                _mouseSpeed = value;
                OnPropertyChanged("MouseSpeed");
            }
        }
        public string ProfileName
        {
            get => _profileName;
            set
            {
                _profileName = value;
                OnPropertyChanged("ProfileName");
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
