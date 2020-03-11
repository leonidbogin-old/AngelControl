using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Menu {
    public class RfidMenu {
        public Color menuColor = Color.FromArgb(224, 224, 224);
        public Color menuColorHover = Color.FromArgb(228, 228, 228);
        public Color menuColorActive = Color.FromArgb(242, 242, 242);

        public MenuRfidIndex index = MenuRfidIndex.nutrition;
        public enum MenuRfidIndex {
            nutrition,
            study,
            monitor
        }
    }
}
