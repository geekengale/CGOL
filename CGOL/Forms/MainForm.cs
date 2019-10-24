using System;
using System.Drawing;
using System.Windows.Forms;

namespace CGOL.Forms
{
    public partial class MainForm : Form
    {
        private bool painting;
        private Point LastPainted;
        bool restart;

        #region Loading
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewPort.RepaintEvent += OnViewPortRepainted;

            var cellSize = Convert.ToInt32(CellSizeGui.Value);
            ViewPort.CellSize = new Size(cellSize, cellSize);

            World.SetSize(Convert.ToInt32(WorldSizeXGUI.Value), Convert.ToInt32(WorldSizeYGUI.Value));
        }
        #endregion

        private void OnViewPortRepainted()
        {
            ViewPortGUI.Image = ViewPort.Bitmap;
        }

        private async void PlayAsync(object sender, EventArgs e)
        {
            World.Running = !World.Running;

            if (World.Running)
                await World.Run();
        }

        #region WorldSettings
        private void ResizeCell(object sender, EventArgs e)
        {
            var i = Convert.ToInt32(CellSizeGui.Value);

            ViewPort.CellSize = new Size(i, i);
        }

        private void WorldSizeChanged(object sender, EventArgs e)
        {
            World.SetSize(Convert.ToInt32(WorldSizeXGUI.Value), Convert.ToInt32(WorldSizeYGUI.Value));
            World.Update();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            World.Clear();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            World.RandomFill(FillPrecent.Value / 100f);
        }
        #endregion

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            restart = World.Running;
            World.Running = false;

            painting = true;
            LastPainted = ViewPort.GetCellAt(e.Location);
            World.Toggle(LastPainted);
            World.Update();
        }

        private async void OnMouseUp(object sender, MouseEventArgs e)
        {
            painting = false;
            if (restart)
            {
                World.Running = true;
                await World.Run();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (painting)
            {
                var lp = ViewPort.GetCellAt(e.Location);
                if (lp != LastPainted)
                {
                    LastPainted = ViewPort.GetCellAt(e.Location);
                    World.Toggle(LastPainted);
                    World.Update();
                }
            }
        }
    }
}
