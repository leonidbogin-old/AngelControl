namespace System.Windows.Forms {
    public class DataGridViewEx : DataGridView {
        public DataGridViewEx() : base() {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}