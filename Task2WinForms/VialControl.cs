using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    public partial class VialControl : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxSegments { get; set; } = 4;
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int InitSegmentCount { get; set; } = 3;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<Segment> Segments { get; set; }


        private Color[] colorPool = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        public VialControl()
        {
            InitializeComponent();
            Segments = new List<Segment>();
            var rand = new Random();
            for(int i = 0; i < InitSegmentCount; i++)
            {
                Segments.Add(new Segment(colorPool[rand.Next() % colorPool.Length]));
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            int dividedSize = this.Height / MaxSegments;
            using (var pen = new Pen(Color.Black, 5))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(new Point(0, 0), this.Size));
            };
            int i = MaxSegments - InitSegmentCount;

            foreach (var segment in Segments)
            {
                Point location = new Point(0, i*dividedSize);
                using(var brush = new SolidBrush(segment.Color))
                {
                    e.Graphics.FillRectangle(brush, new RectangleF(location, new Size(this.Width, dividedSize)));
                }
                i++;
            }

        }

        public void VialControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
