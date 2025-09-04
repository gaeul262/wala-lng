using System;
using System.Windows.Forms;

namespace QueueFormG
{
    public partial class NowServing : Form
    {
        private Timer timer;

        public NowServing()
        {
            InitializeComponent();
        }

        private void NowServing_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
       
        }
        private void NowServingText_Click(object sender, EventArgs e)
        {

        }
    }
}
