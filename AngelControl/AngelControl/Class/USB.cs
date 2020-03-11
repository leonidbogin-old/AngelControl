using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Class {
    public static class USB {
        public const int WM_DEVICECHANGE = 0x0219; //something to do with usb
        public const int DBT_DEVICEARRIVAL = 0x8000; //the device is connected
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004; //the device is disconnected
    }
}
