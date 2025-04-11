namespace Task2WinForms
{
    public partial class Form1 : Form
    {
        private const int CONTROL_WIDTH = 50;
        private const int CONTORL_HEIGHT = 500;

        public Form1()
        {
            InitializeComponent();



        }

        private void vialControl1_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is VialControl v)
            {
                VialControl? fromWho = (VialControl?)e?.Data?.GetData(typeof(VialControl));
                if (fromWho != null)
                {
                    if (v.Segments.Count == 0 || (fromWho.Segments.First().Color == v.Segments.First().Color && v.Segments.Count != v.MaxSegments))
                    {
                        v.Segments = v.Segments.Prepend(fromWho.Segments.First()).ToList();
                        v.InitSegmentCount++;
                        fromWho.Segments.RemoveAt(0);
                        fromWho.InitSegmentCount--;
                        v.Refresh();
                        fromWho.Refresh();
                    }
                }
            }
        }

        private void vialControl1_DragEnter(object sender, DragEventArgs e)
        {
            if(sender is VialControl v)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void vialControl1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void vialControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is VialControl v)
            {
                v.DoDragDrop(v, DragDropEffects.Move);
            }
        }
    }
}
