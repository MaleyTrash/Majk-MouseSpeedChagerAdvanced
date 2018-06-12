using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseSpeedChangerAdvanced
{
    public class MouseSetter
    {
        public const UInt32 SPI_SETMOUSESPEED = 0x0071;
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);
        public void setMouse(double mouseSpeed, double DoubleClickSpeed, double scrollWheelSpeed,bool mouseButtonSwap)
        {

        }
    }
}
