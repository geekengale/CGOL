using System.Drawing;

namespace CGOL
{
    public static class ViewPort
    {
        public delegate void RepaintEventHandler();
        public static event RepaintEventHandler RepaintEvent;

        private static Size _cellSize;
        public static Bitmap Bitmap;

        public static Size CellSize
        {
            get { return _cellSize; }
            set
            {
                _cellSize = value;
                Create();
            }
        }

        internal static void Create()
        {
            if (World.Width == null || World.Height == null || _cellSize.Width < 1 || _cellSize.Height < 1)
                return;

            var width = (int)World.Width;
            var height = (int)World.Height;

            Bitmap = new Bitmap(width * (_cellSize.Width  + 1)+ 1, height * (_cellSize.Height + 1) + 1);
            for (var x = 0; x < Bitmap.Width; x++)
                for (var y = 0; y < Bitmap.Height; y++)
                    if(x % (CellSize.Width + 1) == 0 || y % (CellSize.Height + 1) == 0)
                        Bitmap.SetPixel(x, y, Color.Black);

            RepaintEvent?.Invoke();
        }
        
        public static Point GetCellAt(Point location)
        {
            return new Point(location.X / (_cellSize.Width + 1), location.Y / (_cellSize.Height + 1));
        }
        
        internal static void SetTile(int x, int y, bool paint)
        {
            for (var i = x * (_cellSize.Width + 1) + 1; i < (x + 1) * (_cellSize.Width + 1) && i < Bitmap.Width; i++)
                for (var j = y * (_cellSize.Height + 1) + 1; j < (y + 1) * (_cellSize.Height + 1) && j < Bitmap.Height; j++)
                    Bitmap.SetPixel(i, j, paint ? Color.Blue : Color.Transparent);

            RepaintEvent?.Invoke();
        }
    }
}