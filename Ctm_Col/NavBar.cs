using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ctm_Col
{
    public partial class NavBar : TabControl
    {
        public NavBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(30, 120);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var B = new Bitmap(Width, Height);
            var G = Graphics.FromImage(B);
            G.Clear(Color.Gainsboro);

            for (int i = 0; i < TabCount; i++)
            {
                var TabRectangle = (Rectangle)GetTabRect(i);

                if (i == SelectedIndex)
                {
                    G.FillRectangle(Brushes.Navy, TabRectangle);
                    G.DrawString(TabPages[i].Text, Font, Brushes.White, TabRectangle, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                else
                {
                    G.FillRectangle(Brushes.WhiteSmoke, TabRectangle);
                    G.DrawString(TabPages[i].Text, Font, Brushes.Black, TabRectangle, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }

                TabPages[i].Font = new Font(TabPages[i].Font, FontStyle.Regular);

            }

            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();

            base.OnPaint(e);
        }

    }
}
