namespace GraphingCSharp
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button()
            {
                Location = new Point(10, 10),
                Text = "Draw Graph",
                Size = new Size(100, 30)
            };
            Controls.Add(b);
            b.Click += btnClickEvent;
        }
        private void btnClickEvent(object sender, EventArgs e)
        {
            drawGraph();
        }

        private void drawGraph()
        {
            List<int> graphData = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                graphData.Add(rng.Next(10,100));
            }

            // draw a line graph of the random data
            Graphics graph = CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);//choose your own colour and thickness
            //graph.drawline(pen,startX,startY,endX,endY);

        }
    }
}
