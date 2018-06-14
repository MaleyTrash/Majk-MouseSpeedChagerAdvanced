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
        public const UInt32 SPI_SETDOUBLECLICKTIME = 0x0020;
        public const UInt32 SPI_SETWHEELSCROLLCHARS = 0x006D;
        public const UInt32 SPI_SETWHEELSCROLLLINES = 0x0069;
        public const UInt32 SPI_SETMOUSEBUTTONSWAP = 0x0021;
        [DllImport("User32.dll")]
        static extern Boolean SystemParametersInfo(
            UInt32 uiAction,
            UInt32 uiParam,
            UInt32 pvParam,
            UInt32 fWinIni);
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);
        public void setMouse(ProfileData settings)
        {
            SetMouseSpeed(settings.MouseSpeed);
            SetScrollSpeed(settings.ScrollWheelSpeed);
            SetDoubleClickSpeed(settings.DoubleClickSpeed);
            SwitchMouseButtons(settings.MouseButtonSwap);
        }
        private void SetMouseSpeed(double MouseSpeed)
        {
            uint speed = Convert.ToUInt32(MouseSpeed);
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, speed, 0);
        }
        private void SwitchMouseButtons(bool SwitchMouse)
        {
            Int32 swap = 0;
            if (SwitchMouse)
            {
                swap = 1;
            }
            SwapMouseButton(swap);
        }
        private void SetScrollSpeed(double ScrollSpeed)
        {
            uint speed = Convert.ToUInt32(ScrollSpeed);
            SystemParametersInfo(SPI_SETWHEELSCROLLCHARS, 0, speed, 0);
            SystemParametersInfo(SPI_SETWHEELSCROLLLINES, 0, speed, 0);
        }
        private void SetDoubleClickSpeed(double DoubleClickSpeed)
        {
            uint speed = Convert.ToUInt32(DoubleClickSpeed);
            SystemParametersInfo(SPI_SETDOUBLECLICKTIME, 0, speed, 0);
        }
    }
}
