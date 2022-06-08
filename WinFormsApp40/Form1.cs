namespace WinFormsApp40
{
    public partial class Form1 : Form
    {
        private TrafficLight trafficLight = new TrafficLight(Color.Green, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.DarkGray);
            e.Graphics.FillRectangle(solidBrush, 10, 10, 200, 500);
            solidBrush.Color = Color.White;
            if(trafficLight.color == Color.Red)
                solidBrush.Color = Color.Red;
            e.Graphics.FillEllipse(solidBrush, 35, 20, 150, 150);
            solidBrush.Color = Color.White;
            if (trafficLight.color == Color.Yellow)
                solidBrush.Color = Color.Yellow;
            e.Graphics.FillEllipse(solidBrush, 35, 180, 150, 150);
            solidBrush.Color = Color.White;
            if (trafficLight.color == Color.Green)
                solidBrush.Color = Color.Green;
            e.Graphics.FillEllipse(solidBrush, 35, 340, 150, 150);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trafficLight.move();
            Refresh();
        }
    }
}