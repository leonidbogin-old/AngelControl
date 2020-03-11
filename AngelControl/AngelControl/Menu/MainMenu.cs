using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Menu {
    public class MainMenu {
        public Color menuColor = Color.FromArgb(103, 103, 103);
        public Color menuColorHover = Color.FromArgb(93, 93, 93);
        public Color menuColorActive = Color.FromArgb(66, 131, 222);

        public MenuIndex index = MenuIndex.reg;
        public enum MenuIndex {
            reg,
            rfid
        }
    }
}
