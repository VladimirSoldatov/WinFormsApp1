using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Point moveStart;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Aquamarine;
            Button button1 = new Button
            {
                Location = new Point(this.Width/2, this.Height/2 - 50)
            };
            button1.Size = new Size(196,60);
            button1.Text = "Закрыть";
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Font = new Font(button1.Font.Name, 24,
                button1.Font.Style);

            button1.Click += Button1_Click;
            Controls.Add(button1);
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMoved;
            tabControl1.Location = new Point
                (
                   tabControl1.Location.X + 50, tabControl1.Location.Y
                );
            tabControl1.TabPages[0].Controls
                .Add(new Button 
                    {
                        Name = "Else"
                        ,Dock = DockStyle.Fill
                        , Text = "Еще"
                    }); 
        
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"{(sender as Button)?.Size.Width} - {(sender as Button)?.Size.Height}");
            this.Close();

        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }
        private void Form1_MouseMoved(object? sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point
                    (this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new GraphicsPath();
            Point[] points = new Point[]
            {
                new Point(0,0),
                new Point(100,this.Height + 100),
                new Point(this.Width,this.Height),
                new Point(this.Width -100,- 100)

            };

            //(1; 7), (0; 10), (-1; 11), (-2; 10), (0; 7), (-2; 5), (-7; 3), (-8; 0), (-9; 1), (-9; 0), (-7; -2), (-2; -2), (-3; -1), (-4; -1), (-1; 3), (0; -2), (1; -2), (0; 0), (0; 3), (1; 4), (2; 4), (3; 5), (2; 6), (1; 9), (0, 10); (1; 6).
            graphicsPath.AddPolygon(points);
            Region region = new Region(graphicsPath);
            this.Region = region;
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Location = new Point(50, 50);
            flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel.Size = new Size(200,200);
            flowLayoutPanel.BackColor = Color.Aqua;
            Button button1 = new Button();
            button1.Text = "test1";
            Button button2 = new Button();
            button2.Text = "test2";
            Button button3 = new Button();
            button3.Text = "test3";
            Button button4 = new Button();
            button4.Text = "test4";
            flowLayoutPanel.Controls.Add(button1);
            flowLayoutPanel.Controls.Add(button2);
            flowLayoutPanel.Controls.Add(button3);
            flowLayoutPanel.Controls.Add(button4);
            Controls.Add(flowLayoutPanel);
            Button button11 = new Button();
            button11.Text = "test1";
            button11.Dock = DockStyle.Fill; 
            Button button12 = new Button();
            button12.Text = "test2";
            button12.Dock = DockStyle.Fill;
            Button button13 = new Button();
            button13.Text = "test3";
            button13.Dock = DockStyle.Fill;
            Button button14 = new Button();
            button14.Text = "test4";
            button14.Dock = DockStyle.Fill;
            Button button15 = new Button();
            button15.Text = "test5";
            button15.Dock = DockStyle.Fill;
            Button button16 = new Button();
            button16.Text = "test6";
            button16.Dock = DockStyle.Fill;
            Button button17 = new Button();
            button17.Text = "test7";
            button17.Dock = DockStyle.Fill;
            Button button18 = new Button();
            button18.Text = "test8";
            button18.Dock = DockStyle.Fill;
            Button button19 = new Button();
            button19.Text = "test9";
            button19.Dock = DockStyle.Fill;

            tableLayoutPanel1.Controls.AddRange
                (
                new Button[] 
                    {
                        button11,
                        button12,
                        button13,
                        button14,
                        button15,
                        button16,
                        button17,
                        button18,
                        button19
                    }
                );
           MyButton myButton = new MyButton();
            myButton.Location = new Point(300, 100);
           myButton.Size = new Size(100, 100);
           Controls.Add(myButton);
        }

    }
}
