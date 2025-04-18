using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    /// <summary>
    /// VialControl derived from UserControl is a class that simulates behavior of a vial with randomized segments of colors 
    /// </summary>
    public partial class VialControl : UserControl
    {
        private int _maxSegments = 4;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        /// <summary>
        /// Describes the maximum amount of colored segments allowed on the control
        /// </summary>
        public int MaxSegments
        {
            get => _maxSegments;
            set
            {
                if (value == _maxSegments) return;
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxSegments), _maxSegments, "Max segments should be positive");
                }
                else _maxSegments = value;
            }
        }

        private int _initSegmentCount = 3;

        /// <summary>
        /// Sets the inital colored segment count on the control
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int InitSegmentCount { get => _initSegmentCount;
            set
            {
                if (value == _initSegmentCount) return;
                if (value <= 0 || value > MaxSegments)
                {
                    throw new ArgumentOutOfRangeException(nameof(InitSegmentCount), value, "The value of InitSegmentCount must be positive and less than MaxSegments");
                }
                else
                {
                    _initSegmentCount = value;
                    InitSegmentCountChanged.Invoke(this, new PropertyChangedEventArgs(nameof(InitSegmentCount)));
                }
            } }


        /// <summary>
        /// Wewnetrzny event aplikacji po to, aby sie resetowala po zmianie InitSegmentCount
        /// </summary>
        private event PropertyChangedEventHandler InitSegmentCountChanged;

        public event DragDropOccuredEventHandler? DragDropOccured;


        /// <summary>
        /// The list of current colored segments on the control
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public BindingList<Segment> Segments { get; set; }

        /// <summary>
        /// Collection of colors allowed on the control
        /// </summary>
        private readonly Color[] colorPool = { Color.Red, Color.Green, Color.Blue, Color.Yellow };

        /// <summary>
        /// The distance between the edges of the Control and Segments' borders
        /// </summary>
        private const int PADDING = 6;
        private const int MAX_WIDTH = 50;
        private const int MAX_HEIGHT = 150;

        public VialControl()
        {
            InitializeComponent();
            InitializeSegments();

            // Default dragging events
            this.DragDrop += VialControl_DragDrop;
            this.DragEnter += VialControl_DragEnter;
            this.MouseMove += VialControl_MouseMove;
            this.AllowDrop = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.InitSegmentCountChanged += VialControl_InitSegmentCountChanged;
        }

        /// <summary>
        /// Initializes the Segment List
        /// </summary>
        private void InitializeSegments()
        {
            Segments = new BindingList<Segment>();

            // Randomizing segments
            var rand = new Random();
            for (int i = 0; i < InitSegmentCount; i++)
            {
                Segments.Add(new Segment(colorPool[rand.Next() % colorPool.Length]));
            }
        }


        /// <summary>
        /// Event raised when initial segment count is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VialControl_InitSegmentCountChanged(object? sender, PropertyChangedEventArgs e)
        {
            InitializeSegments();
        }

        /// <summary>
        /// Event raised on moving the mouse, triggers the DragDrop event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VialControl_MouseMove(object? sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Accepts a DragDrop action when the sender is another VialControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VialControl_DragEnter(object? sender, DragEventArgs e)
        {
            if (sender is VialControl v)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        /// <summary>
        /// Handles the DragDrop logic of moving colored segments between vials. Ensuers that all segments with the same color are transferred to another vial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VialControl_DragDrop(object? sender, DragEventArgs e)
        {
            if (sender is VialControl v)
            {
                // Tracks the amount of segments transferred
                int amount = 0;
                VialControl? fromWho = (VialControl?)e?.Data?.GetData(typeof(VialControl)); // VialControl that we are receiving a segment from
                if (fromWho != null && fromWho != this)
                {
                    // Logic of moving all the blocks with the same color at once
                    while (v.Segments.Count == 0 || (fromWho.Segments.Count > 0 && fromWho.Segments.First().Color == v.Segments.First().Color && v.Segments.Count != v.MaxSegments))
                    {
                        v.Segments.Insert(0, fromWho.Segments.First());
                        fromWho.Segments.RemoveAt(0);
                        amount++;
                    }
                    v.Refresh();
                    fromWho.Refresh();
                }
                if(amount > 0)
                {
                    DragDropOccured?.Invoke(this, new DragDropOccuredEventArgs(fromWho!, v, amount));
                }
            }
        }

        /// <summary>
        /// Custom Painting Logic for the VialControl, draws the Control with corresponding colored segments
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dividing painting area equally
            float dividedSize = (this.Height*1.0f) / MaxSegments;

            // Path used for clipping
            GraphicsPath path = new GraphicsPath();

            // Outline of the control
            using (var pen = new Pen(this.ForeColor, PADDING))
            {
                float halfPenWidth = pen.Width / 2f-0.5f; // Korekta o pół piksela, aby była symetria ?
                float arcTop = this.Height - this.Width + halfPenWidth; // Symetryczny okrąg na dole
                float arcHeight = this.Width - pen.Width;

                // Left line
                path.AddLine(halfPenWidth, 0, halfPenWidth, arcTop);

                // Bottom arc
                path.AddArc(halfPenWidth, arcTop, this.Width - pen.Width, arcHeight, 180, -180);

                // Right line
                path.AddLine(this.Width - halfPenWidth-0.5f, arcTop, this.Width - halfPenWidth - 0.5f, 0); // Analogiczna korekta jak wyżej

                // Clipping region
                Region region = new Region(path);
                e.Graphics.SetClip(path, CombineMode.Replace);
            }

            // The vials are empty from the top
            int i = MaxSegments - Segments.Count;


            foreach (var segment in Segments)
            {
                Point location = new Point(0, i*((int)dividedSize)) + new Size(PADDING, PADDING);
                Size size = new Size(this.Width - 2 * PADDING, ((int)dividedSize));
                RectangleF rect = new RectangleF(location, size);

                using (var brush = new SolidBrush(segment.Color))
                {
                    using var pen = new Pen(this.ForeColor, PADDING);
                    e.Graphics.DrawRectangle(pen, rect);
                    e.Graphics.FillRectangle(brush, rect);
                }
                i++;
            }

            using (var pen = new Pen(this.ForeColor, PADDING))
            {
                e.Graphics.ResetClip();
                e.Graphics.DrawPath(pen, path);
            }
        }


        /// <summary>
        /// Clears and initiates the segment list with colors choosen from a specific collection
        /// </summary>
        /// <param name="colors">Collection of color to choose from</param>
        public void pickColors(ICollection<Color> colors)
        {
            Segments.Clear();
            var rand = new Random(((int)DateTime.Now.Ticks));

            // Differentiates the case when there are less colors than the control needs
            // When zero, control just clears itself
            int limit = Math.Min(InitSegmentCount, colors.Count);


            for (int i = 0; i < limit; i++)
            {
                var chosenColor = colors.ElementAt(new Index(rand.Next(0, colors.Count)));
                Segments.Add(new Segment(chosenColor));
                colors.Remove(chosenColor);
            }
        }

        /// <summary>
        /// Event occurs when the control is Resized, limits the maximum size of the control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = Math.Min(this.Width, MAX_WIDTH);
            this.Height = Math.Min(this.Height, MAX_HEIGHT);
            Refresh();
        }
        public void VialControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
