using Pet_Care.View;

namespace Pet_Care
{
    public partial class Splash_Screen : Form
    {
        int time;
        public Splash_Screen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <30)
            {
                this.time++;
            }
            else
            {
                timer1.Stop();
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
