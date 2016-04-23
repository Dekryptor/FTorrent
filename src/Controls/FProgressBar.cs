using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTorrent.Controls
{
    //http://stackoverflow.com/questions/3529928/how-do-i-put-text-on-progressbar
    //http://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5

    public enum ProgressBarDisplayText
    {
        Percentage,
        CustomText
    }

    public partial class FProgressBar : ProgressBar
    {
        public FProgressBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        public ProgressBarDisplayText DisplayStyle { get; set; }

        public Color ProgressBarColor { get; set; } = Color.YellowGreen;

        public Color TextColor { get; set; } = Color.Blue;

        public String CustomText { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = e.ClipRectangle;
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 2;
            if (ProgressBarRenderer.IsSupported)
            {
                ProgressBarRenderer.DrawHorizontalBar(g, e.ClipRectangle);
            }
            rec.Height -= 4;
            e.Graphics.FillRectangle(new SolidBrush(ProgressBarColor), 1, 1, rec.Width, rec.Height + 2);

            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;

            using (Font f = new Font(FontFamily.GenericSerif, 10))
            {
                SizeF len = g.MeasureString(text, f);
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                g.DrawString(text, f, new SolidBrush(TextColor), location);
            }
        }
    }
}
