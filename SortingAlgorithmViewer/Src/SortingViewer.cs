using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SortingAlgorithmViewer.Src
{
    class SortingViewer
    {

        private int eWidth;
        private int eHeight;

        private int elementSpacing = 4;
        private int DrawOffsetX = 8;
        private int DrawOffsetY = 8;

        private int delay;
        public int Delay { get { return delay; } }

        private List<int> highlighted = new List<int>();

        private int[] arr;

        private Control component;
        private SortingSyncContoller syncContoller;

        Pen p;
        SolidBrush b;
        public SortingViewer(Control component, SortingSyncContoller syncContoller, Color color)
        {
            this.component = component;
            this.syncContoller = syncContoller;

            p = new Pen(color);
            b = new SolidBrush(color);

            component.Paint += Draw;
        }

        public void SetDelay(int d)
        {
            delay = d;
        }

        public void Draw(object s, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            for (int i = 0; i < arr.Length; i++)
            {
                e.Graphics.DrawRectangle(p, new Rectangle(CalculateNumPoint(i), new Size(eWidth, eHeight * arr[i])));
            }
            for (int i = 0; i < highlighted.Count; i++)
            {
                e.Graphics.FillRectangle(b, new Rectangle(CalculateNumPoint(highlighted[i]), new Size(eWidth, eHeight * arr[highlighted[i]])));
            }
            highlighted.Clear();
        }

        public void CallDraw()
        {
            if (syncContoller.IsPaused)
                syncContoller.WaitForStep();
            component.Invalidate();
            Thread.Sleep(delay);
        }

        public void Highlight(params int[] indexes)
        {
            highlighted = new List<int>(indexes);
            CallDraw();
        }

        private Point CalculateNumPoint(int i)
        {
            return new Point(DrawOffsetX + i * elementSpacing + i * eWidth, component.Height - (eHeight * arr[i]) - DrawOffsetY);
        }

        public void SetArray(int[] arr)
        {
            this.arr = arr;
            CalculateDrawSize();
        }

        public void CalculateDrawSize() 
        {
            eWidth = (component.Width - (arr.Length - 1) * elementSpacing - DrawOffsetX * 2) / arr.Length;
            eHeight = (component.Height - DrawOffsetY * 2) / arr.Length;
        }
    }
}


public enum MarkType
{

}
