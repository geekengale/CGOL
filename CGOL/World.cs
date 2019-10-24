using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CGOL
{
    public static class World
    {
        private static bool[][] CurrentGeneration;
        private static bool[][] NextGeneration;

        public static bool Running = false;

        public static int? Width { get { return CurrentGeneration?.Length; } }
        public static int? Height { get { return CurrentGeneration?[0]?.Length; } }

        public static void SetSize(int width, int height, bool repaint = true)
        {
            if (width < 1 && height < 1)
                return;

            var set = NextGeneration != null && repaint;
            bool[][] old = null;
            if (set)
                old = NextGeneration;

            CurrentGeneration = new bool[width][];
            for (var x = 0; x < width; x++)
                CurrentGeneration[x] = new bool[height];

            NextGeneration = new bool[width][];
            for (var x = 0; x < width; x++)
                NextGeneration[x] = new bool[height];

            if(set)
            {
                for (var x = 0; x < old.Length && x < NextGeneration.Length; x++)
                    for (var y = 0; y < old[0].Length && y < NextGeneration[0].Length; y++)
                        NextGeneration[x][y] = old[x][y];
            }
            ViewPort.Create();
        }
        
        public static void Toggle(Point cell)
        {
            if (cell.X < 0 || cell.Y < 0 || cell.X >= Width || cell.Y >= Height)
                return;
            NextGeneration[cell.X][cell.Y] = !CurrentGeneration[cell.X][cell.Y];
            Update();
        }

        public static async Task Run()
        {
            while (Running)
            {
                for (var x = 0; x < CurrentGeneration.Length; x++)
                    for (var y = 0; y < CurrentGeneration[0].Length; y++)
                    {
                        var neighbors = Neighbors(x, y);

                        if (!CurrentGeneration[x][y])
                        {
                            if (neighbors == 3)
                                NextGeneration[x][y] = true;
                        }
                        else if (neighbors <= 1 || neighbors >= 4)
                            NextGeneration[x][y] = false;
                    }

                Update();
                await Task.Delay(100);
            }
        }

        public static void Update()
        {
            if (Width == null || Height == null)
                return;

            for (var x = 0; x < Width; x++)
                for (var y = 0; y < Height; y++)
                    if (CurrentGeneration[x][y] != NextGeneration[x][y])
                        ViewPort.SetTile(x, y, (CurrentGeneration[x][y] = NextGeneration[x][y]));
        }

        public static void Clear()
        {
            if (Width == null || Height == null)
                return;

            SetSize((int)Width, (int)Height, false);
        }

        public static void RandomFill(float percentage)
        {
            if (Width == null || Height == null)
                return;
            Clear();
            var cells = (int)Width * (int)Height;
            var cnt = (int)(cells * percentage);
            var rnd = Enumerable.Range(0, cells).Select(o=>new Point(o%(int)Width, o/(int)Width)).OrderBy(o => Guid.NewGuid()).Take(cnt);
            foreach(var p in rnd)
                Toggle(p);
        }

        private static int Neighbors(int x, int y)
        {
            var neighbors = new bool[8];
            var neighbor = 0;

            if (Width == null || Height == null)
                return 0;
            
            for (var i = -1; i <= 1; i++)
                for (var j = -1; j <= 1; j++)
                {
                    if ((i == 0 && j == 0) ||
                        x + i < 0 ||
                        y + j < 0 ||
                        x + i >= Width ||
                        y + j >= Height)
                        continue;

                    neighbor = (j + 1) * 3 + (i + 1);
                    neighbors[neighbor < 5 ? neighbor : neighbor - 1] = CurrentGeneration[x + i][y + j];
                }

            return neighbors.Where(c=>c).Count();
        }
    }
}
