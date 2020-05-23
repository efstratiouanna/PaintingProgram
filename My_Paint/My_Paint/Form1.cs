using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace My_Paint
{
    

    public partial class Form1 : Form 
    {
        enum PaintTools { Pen, Rectangle, Ellipse, Line, Rubber, Triangle, House, Square };
        private PaintTools selectedTool = PaintTools.Pen;

        
        abstract class DrawnShape // base class of other classes  
        {
            public Color Color { get; set; }
            public int Thickness { get; set; }

            public abstract void draw(PaintEventArgs e);
        }


        class PenPaintingsClass : DrawnShape
        {
            public List<Point> PenPoints = new List<Point>();
            public override void draw(PaintEventArgs e)
            {
                Pen pen = new Pen(this.Color, this.Thickness);
                e.Graphics.DrawLines(pen, this.PenPoints.ToArray());
            }
        }

        class Line:DrawnShape
        {
            public Point StartingPoint { get; set; }
            public Point EndingPoint { get; set; }

            public override void draw(PaintEventArgs e)
            {
                Pen pen = new Pen(this.Color, this.Thickness);
                e.Graphics.DrawLine(pen, this.StartingPoint, this.EndingPoint);
            }


        }
        
        class DrawnRectangleClass:DrawnShape
        {
            public Rectangle MyRectangle { get; set; }

            public override void draw(PaintEventArgs e)
            {
                Pen pen = new Pen(this.Color, this.Thickness);
                e.Graphics.DrawRectangle(pen, this.MyRectangle);
            }
            
        }

        class DrawnEllipseClass:DrawnShape
        {
            public Rectangle MyEllipse { get; set; }

            public override void draw(PaintEventArgs e) 
            {
                Pen pen = new Pen(this.Color, this.Thickness);
                e.Graphics.DrawEllipse(pen, this.MyEllipse);
            
            }
        }


        class RubberClass:DrawnShape
        {
            public List<Point> RubberPoints = new List<Point>();
            public override void draw(PaintEventArgs e)
            {
                Pen pen = new Pen(Color.White, 5);
                e.Graphics.DrawLines(pen, this.RubberPoints.ToArray());
            }
        }


        Pen mypen = new Pen(Color.Black, 1);
        
        private Point startingPoint;
        private bool isMouseDown = false;


        // stores the currently drawing pen painting
        private PenPaintingsClass tempPenPainting = null;


        // stores the currently drawing Line
        private Line tempLine = null;


        // stores the currently drawing Rectangle
        private DrawnRectangleClass tempRectangle = null;

        
        // stores the currently drawing Ellipse
        private DrawnEllipseClass tempEllipse = null;

       
        // stores the currently drawing rubber
        private RubberClass tempRubber = null;


        private List<DrawnShape> drawnShapes = new List<DrawnShape>();


        public Form1()
        {
            this.DoubleBuffered = true; //prevent flicking 
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            foreach (var shape in this.drawnShapes)
            {

                shape.draw(e);
            }

            if (this.tempPenPainting != null)
            {
                tempPenPainting.draw(e);
            }

            if (this.tempLine != null)
            {
                tempLine.draw(e);
            }

            if (this.tempRectangle != null)
            {
                tempRectangle.draw(e);
            }

            if (this.tempEllipse != null)
            {
                tempEllipse.draw(e);
            }

            if (this.tempRubber != null)
            {
                tempRubber.draw(e);
            }


           
        }
       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isMouseDown = true;
                this.startingPoint = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseDown = false;
            
            if (this.tempRectangle != null)
            {
                this.drawnShapes.Add(this.tempRectangle);
            }
            this.tempRectangle = null;

            if (this.tempEllipse != null)
            {
                this.drawnShapes.Add(this.tempEllipse);
            }
            this.tempEllipse = null;

            if (this.tempLine != null)
            {
                this.drawnShapes.Add(this.tempLine);
            }
            this.tempLine = null;

            if (this.tempPenPainting != null)
            {
                this.drawnShapes.Add(this.tempPenPainting);
            }
            this.tempPenPainting = null;

            if (this.tempRubber !=null)
            {
                this.drawnShapes.Add(this.tempRubber);
            }
            this.tempRubber = null;
            
            this.startingPoint = Point.Empty;
            this.Invalidate(); // redraw the surface
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isMouseDown == false)
            {
                return;   
            }

            if (this.selectedTool == PaintTools.Line)
            {
                var endingPoint = e.Location;
                this.tempLine = new Line();
                this.tempLine.StartingPoint = this.startingPoint;
                this.tempLine.EndingPoint = endingPoint;
                this.tempLine.Thickness = (int)this.mypen.Width;
                this.tempLine.Color = this.mypen.Color;

            }
            
            if (this.selectedTool == PaintTools.Rectangle){
                var endingPoint = e.Location;
                int x = Math.Min(this.startingPoint.X, endingPoint.X);
                int y = Math.Min(this.startingPoint.Y, endingPoint.Y);
                int width = Math.Abs(endingPoint.X - this.startingPoint.X);
                int height = Math.Abs(endingPoint.Y - this.startingPoint.Y);

                this.tempRectangle = new DrawnRectangleClass();
                this.tempRectangle.MyRectangle = new Rectangle(x, y, width, height);
                this.tempRectangle.Thickness = (int)this.mypen.Width;
                this.tempRectangle.Color = this.mypen.Color;
                
            }

            if (this.selectedTool == PaintTools.Ellipse)
            {
                var endingPoint = e.Location;
                int x = Math.Min(this.startingPoint.X, endingPoint.X);
                int y = Math.Min(this.startingPoint.Y, endingPoint.Y);
                int width = Math.Abs(endingPoint.X - this.startingPoint.X);
                int height = Math.Abs(endingPoint.Y - this.startingPoint.Y);

                this.tempEllipse = new DrawnEllipseClass();
                this.tempEllipse.MyEllipse = new Rectangle(x, y, width, height);
                this.tempEllipse.Thickness = (int)this.mypen.Width;
                this.tempEllipse.Color = this.mypen.Color;
            }
            

            if (this.selectedTool == PaintTools.Pen)
            {
                if (this.tempPenPainting == null)
                {
                    this.tempPenPainting = new PenPaintingsClass();
                    this.tempPenPainting.PenPoints.Add(this.startingPoint);
                    this.tempPenPainting.Thickness = (int)this.mypen.Width;
                    this.tempPenPainting.Color = this.mypen.Color;
                }
                this.tempPenPainting.PenPoints.Add(e.Location);
            }

            if (this.selectedTool == PaintTools.Rubber)
            {
                if (this.tempRubber == null)
                {
                    this.tempRubber = new RubberClass();
                    this.tempRubber.RubberPoints.Add(this.startingPoint);
                    this.tempRubber.Thickness = 5;
                    this.tempRubber.Color = Color.White;
                }
                this.tempRubber.RubberPoints.Add(e.Location);
            }
            this.Invalidate();
        }

        private void penSelectLabel_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Pen;
        }

        private void rectanglebox_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Rectangle;
        }

        private void ellipsebox_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Ellipse; ;
        }

        private void lineSelectLabel_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Line;
        }

        private void rubberSelectLabel_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Rubber;
        }

        private void default1_Click(object sender, EventArgs e) //color box
        {
            ColorDialog MyColor = new ColorDialog();
            MyColor.AllowFullOpen = false;
            MyColor.ShowHelp = true;
            
            if(MyColor.ShowDialog() == DialogResult.OK)
            {
                mypen.Color = MyColor.Color;
                default1.BackColor = MyColor.Color;
            }
        }

        private void thicknessDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var thickness = Int32.Parse(comboBox.SelectedItem.ToString());
            this.mypen.Width = thickness;
            
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Triangle;
            triangleTimer.Enabled = true;
            houseTimer.Enabled = false;
            squareTimer.Enabled = false;
        }


        public int count = 0;
        private void triangleTimer_Tick(object sender, EventArgs e)
        {
            var triangleLength = 100;
            // left-down point of triangle
            var xLeftDown = 250;
            var yLeftDown = 300;

            // top point of triangle
            var xTop = xLeftDown + (triangleLength / 2);
            var yTop = yLeftDown - triangleLength;

            // right-down point of triangle
            var xRightDown = xLeftDown + triangleLength;
            var yRightDown = yLeftDown;


            Line line = new Line();
            line.Color = this.mypen.Color;
            line.Thickness = 5;

            if (count == 0)
            {
                line.StartingPoint = new Point(xLeftDown, yLeftDown);
                line.EndingPoint = new Point(xTop, yTop);                
            }

            if (count == 1)
            {
                line.StartingPoint = new Point(xTop, yTop);
                line.EndingPoint = new Point(xRightDown, yRightDown);
            }

            if (count == 2)
            {
                line.StartingPoint = new Point(xRightDown, yRightDown);
                line.EndingPoint = new Point(xLeftDown, yLeftDown);

                triangleTimer.Enabled = false;
                count = 0;
            }
            else
            {
                count++;
            }
            this.drawnShapes.Add(line);
            this.Invalidate();
            
        }

        private void houseButton_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.House;
            houseTimer.Enabled = true;
            triangleTimer.Enabled = false;
            squareTimer.Enabled = false;
        }

        private void houseTimer_Tick(object sender, EventArgs e)
        {
            var houseLenght = 100; 
            
            //right-up point of box
            var xRightUp = 600;
            var yRightUp = 300;

            //right-down point of box
            var xRightDown = xRightUp;
            var yRightDown = yRightUp + houseLenght;

            //left-down point of box
            var xLeftDown = xRightDown - houseLenght;
            var yLeftDown = yRightDown;

            //left-up point of box
            var xLeftUp = xLeftDown;
            var yLeftUp = yLeftDown - houseLenght;

            //top point of roof
            var xTop = xLeftUp + (houseLenght / 2);
            var yTop = yLeftUp - houseLenght;

            //right-down point of roof and up-right point of box
            var xRightUp2 = xRightUp;
            var yRightUp2 = yRightUp;

            //left-down point of roof and left-up point of box
            var xEnd = xLeftUp;
            var yEnd = yLeftUp;


            Line line = new Line();
            line.Color = this.mypen.Color;
            line.Thickness = 5;

            if (count == 0)
            {
                line.StartingPoint = new Point(xRightUp, yRightUp);
                line.EndingPoint = new Point(xRightDown, yRightDown);
            }

            if (count == 1)
            {
                line.StartingPoint = new Point(xRightDown, yRightDown);
                line.EndingPoint = new Point(xLeftDown, yLeftDown);
            }

            if (count == 2)
            {
                line.StartingPoint = new Point(xLeftDown, yLeftDown);
                line.EndingPoint = new Point(xLeftUp, yLeftUp);
            }

            if (count == 3)
            {
                line.StartingPoint = new Point(xLeftUp, yLeftUp);
                line.EndingPoint = new Point(xTop, yTop);
                
            }

            if (count == 4)
            {
                line.StartingPoint = new Point(xTop, yTop);
                line.EndingPoint = new Point(xRightUp2, yRightUp2);
            }

            if (count == 5)
            {
                line.StartingPoint = new Point(xRightUp2, yRightUp2);
                line.EndingPoint = new Point(xEnd, yEnd);
                houseTimer.Enabled = false;
                count = 0;
            }
                
            else
            {
                count++;
            }
            this.drawnShapes.Add(line);
            this.Invalidate();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            this.selectedTool = PaintTools.Square;
            squareTimer.Enabled = true;
            triangleTimer.Enabled = false;
            houseTimer.Enabled = false;
        }

        private void squareTimer_Tick(object sender, EventArgs e)
        {
            var houseLenght = 100;

            //left-down point of square
            var xLeftDown = 700;
            var yLeftDown = 300;

            //right-down point of square
            var xRightDown = xLeftDown + houseLenght;
            var yRightDown = yLeftDown;

            //right-up pont of square
            var xRightUp = xRightDown;
            var yRightUp = yRightDown - houseLenght;

            //left-up point of square
            var xLeftUp = xRightUp - houseLenght;
            var yLeftUp = yRightUp;

            //left-down point and end of square
            var xEnd = xLeftUp;
            var yEnd = yLeftUp + houseLenght;

            Line line = new Line();
            line.Color = this.mypen.Color;
            line.Thickness = 5;

            if (count == 0)
            {
                line.StartingPoint = new Point(xLeftDown, yLeftDown);
                line.EndingPoint = new Point(xRightDown, yRightDown);
            }
            if (count == 1)
            {
                line.StartingPoint = new Point(xRightDown, yRightDown);
                line.EndingPoint = new Point(xRightUp, yRightUp);
            }
            if (count == 2)
            {
                line.StartingPoint = new Point(xRightUp, yRightUp);
                line.EndingPoint = new Point(xLeftUp, yLeftUp);
            }
            if (count == 3)
            {
                line.StartingPoint = new Point(xLeftUp, yLeftUp);
                line.EndingPoint = new Point(xEnd, yEnd);
                squareTimer.Enabled = false;
                count = 0;
            }
            else
            {
                count++;
            }
            this.drawnShapes.Add(line);
            this.Invalidate();
        }

       
     
    }
}
