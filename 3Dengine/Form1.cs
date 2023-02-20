namespace _3Dengine
{
    public partial class Form1 : Form
    {
        private static Bitmap bmp;
        private static Graphics g;
        private Scene scene;
        private Figure cube;
        private int Cx, Cy;
        private float degrees;
        private float radians;
        private int option;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);
            g = Graphics.FromImage(bmp);
            PCT_CANVAS.Image = bmp;

            Cx = (bmp.Width / 2);
            Cy = (bmp.Height / 2);

            scene = new Scene();
            cube = new Figure();
            scene.Figures.Add(cube);
            timer1.Stop();
            degrees = 0;
        }

        private void createPoints3D()
        {
            cube.vertices.Add(new Vertex(-50,-50,50));
            cube.vertices.Add(new Vertex(-50,50,50));
            cube.vertices.Add(new Vertex(50,50, 50));
            cube.vertices.Add(new Vertex(50,-50, 50));
            cube.vertices.Add(new Vertex(50, 50, -50));
            cube.vertices.Add(new Vertex(50, -50, -50));
            cube.vertices.Add(new Vertex(-50, 50, -50));
            cube.vertices.Add(new Vertex(-50, -50, -50));
        }

        private void centerPoints()
        {
            for (int i = 0; i < scene.Figures[0].Pts.Count; i++)
            {
                scene.Figures[0].Pts[i] = new PointF(scene.Figures[0].Pts[i].X + Cx, scene.Figures[0].Pts[i].Y + Cy);
            }
        }

        public void drawFigure()
        {
            g.Clear(Color.Black);

            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(0), scene.Figures[0].Pts.ElementAt(1));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(1), scene.Figures[0].Pts.ElementAt(2));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(2), scene.Figures[0].Pts.ElementAt(3));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(3), scene.Figures[0].Pts.ElementAt(0));

            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(2), scene.Figures[0].Pts.ElementAt(4));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(3), scene.Figures[0].Pts.ElementAt(5));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(5), scene.Figures[0].Pts.ElementAt(4));

            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(1), scene.Figures[0].Pts.ElementAt(6));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(0), scene.Figures[0].Pts.ElementAt(7));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(6), scene.Figures[0].Pts.ElementAt(7));

            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(6), scene.Figures[0].Pts.ElementAt(4));
            g.DrawLine(Pens.White, scene.Figures[0].Pts.ElementAt(7), scene.Figures[0].Pts.ElementAt(5));

            PCT_CANVAS.Invalidate();
        }


        private float convertRadians(float angle)
        {
            angle = Convert.ToSingle((Math.PI / 180.0) * angle);
            degrees++;
            return angle;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            createPoints3D();
            
            radians = convertRadians(degrees);

            if (option == 1)
            {
                scene.Figures[0].rotatePoints(radians, option);
            }
            else if(option == 2){
                scene.Figures[0].rotatePoints(radians, option);
            }
            else if(option == 3)
            {
                scene.Figures[0].rotatePoints(radians, option);
            }
            else
            {
                scene.Figures[0].rotatePoints(radians, 1);
                scene.Figures[0].rotatePoints(radians, 2);
                scene.Figures[0].rotatePoints(radians, 3);
            }

            scene.Figures[0].projectPoints();

            centerPoints();

            drawFigure();

            scene.Figures[0].Pts.Clear();

            cube.vertices.Clear();

        }

        private void rotateX_Click(object sender, EventArgs e)
        {
            option = 1;
            timer1.Start();
        }
        private void rotateY_Click(object sender, EventArgs e)
        {
            option = 2;
            timer1.Start();
        }
        private void rotateZ_Click(object sender, EventArgs e)
        {
            option = 3;
            timer1.Start();
        }
        private void rotateXYZ_Click(object sender, EventArgs e)
        {
            option = 4;
            timer1.Start();
        }
    }
}