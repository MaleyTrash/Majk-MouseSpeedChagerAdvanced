using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseSpeedChangerAdvanced
{
    public class ProfileData
    {
        public double mouseSpeed;
        public double doubleClickSpeed;
        public double scrollWheelSpeed;
        public bool mouseButtonSwap;
        public ProfileData(double _mouseSpeed, double _DoubleClickSpeed, double _scrollWheelSpeed, bool _mouseButtonSwap)
        {
            mouseSpeed = _mouseSpeed;
            doubleClickSpeed = _DoubleClickSpeed;
            scrollWheelSpeed = _scrollWheelSpeed;
            mouseButtonSwap = _mouseButtonSwap;
        }
    }
}
