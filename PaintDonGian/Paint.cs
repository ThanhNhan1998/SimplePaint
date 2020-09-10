using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDonGian
{
    public enum ButtonColor
    {
        Left,
        Right
    }

    public enum ShapeModes
    {
        None,
        DrawLine,
        DrawRectangle,
        DrawElipse,
        DrawTriangular,
        DrawHexagon,
        DrawLeftRightArrow,
        DrawUpDownArrow,
    }

    public partial class Paint : Form
    {
        private Point p1;
        private Point p2;

        private Graphics grp;       // ve len bitmap;
        private Graphics grpDraw;   // ve len form

        int locationBitmap;
        private List<Bitmap> bitmaps;
        private Bitmap Bpen_eraser;

        private ButtonColor bColor;
        private int penSize;

        
        private ShapeModes shape;

        private bool isDown = false, isMouseMove = false;
        private bool Pen;
        private bool isEaraser = false;
        private int countUndo = 0;
        private bool setUpBitMap_Pen_Eraser;

        public Paint()
        {
            InitializeComponent();
            
            //bitmap = new Bitmap(this.Width, this.Height);
            //grp = Graphics.FromImage(bitmap); // grp nay se ve len bitmap

            this.MouseDown += new MouseEventHandler(Paint_MouseDown);
            this.MouseMove += new MouseEventHandler(Paint_MouseMove);
            this.MouseUp += new MouseEventHandler(Paint_MouseUp);
            this.Paint += new PaintEventHandler(Paint_Draw);

            // bitmap 0 la bitmap rong
            locationBitmap = 0;
            bitmaps = new List<Bitmap>();
            bitmaps.Add(new Bitmap(this.Width, this.Height));

            // bitmap pen
            setUpBitMap_Pen_Eraser = false;
            Bpen_eraser = (Bitmap)bitmaps.ElementAt(0).Clone();

            //nut mau mat dinh la nut trai
            bColor = ButtonColor.Left;
            shape = ShapeModes.None;

 
            // size mat dinh

            for (int i = 1; i <= 10; i++)
                cbSize.Items.Add(i);

            cbSize.SelectedIndex = 0;

            // Mac dinh la dung but ve
            Pen = true;

            //Giam rung
            this.SetStyle(ControlStyles.UserPaint, true); //thong bao cho form biet rang user se thao tac ve, form tu dieu khien va khong phu thuoc vao he dieu hanh
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // ngat het moi tin nhan tu he dieu hanh, giup form cap nhap nhanh hon
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // Gap doi bo nho dem de co the nho duoc nhieu thao tac hon
        }

        void Paint_Draw(object sender, PaintEventArgs e)
        {
            switch (shape)
            {
                case ShapeModes.DrawLine:
                    e.Graphics.DrawLine(new Pen(btnRightColor.BackColor, penSize), p1, p2);
                    break;
                case ShapeModes.DrawRectangle:
                    e.Graphics.DrawRectangle(new Pen(btnRightColor.BackColor, penSize),
                        Math.Min(p1.X, p2.X),
                        Math.Min(p1.Y, p2.Y),
                        Math.Abs(p2.X - p1.X),
                        Math.Abs(p2.Y - p1.Y));
                    //e.Graphics.DrawRectangle(new Pen(btnLeftColor.BackColor, penSize), p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
                    break;
                case ShapeModes.DrawElipse:
                    e.Graphics.DrawEllipse(new Pen(btnRightColor.BackColor, penSize), p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                    break;
                case ShapeModes.DrawTriangular:

                    Point A = new Point((p2.X + p1.X)/2, p1.Y);
                    Point B = new Point(p1.X, p2.Y);
                    Point C = new Point(p2.X, p2.Y);

                    e.Graphics.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), new Point[]{
                        A, B, C
                    });
                    break;
                case ShapeModes.DrawHexagon:
                    float y = (float)((p2.Y - p1.Y) / 3);

                    PointF Top = new PointF((float)((p1.X + p2.X)/2), p1.Y);
                    PointF TopLeft = new PointF(p1.X, p1.Y + y);
                    PointF TopRight = new PointF(p2.X, p1.Y + y);
                    PointF Bot = new PointF((float)((p1.X + p2.X) / 2), p2.Y);
                    PointF BotLeft = new PointF(p1.X, p2.Y - y);
                    PointF BotRight = new PointF(p2.X, p2.Y - y);

                    e.Graphics.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), new PointF[] {
                        Top, TopLeft, BotLeft, Bot, BotRight, TopRight
                    });
                    break;
                case ShapeModes.DrawLeftRightArrow:
                    PointF[] pointFs = getPointOfLeftRightArrow(p1, p2);
                    e.Graphics.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), pointFs);
                    break;
                case ShapeModes.DrawUpDownArrow:
                    PointF[] pointFss = getPointOfUpDownArrow(p1, p2);
                    e.Graphics.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), pointFss);
                    break;
            }
        }

        void Paint_MouseUp(object sender, MouseEventArgs e)
        { 
            isDown = false;
            setUpBitMap_Pen_Eraser = false;
            //if (Pen || isEaraser)
            //    isMouseMove = true;

            if (isMouseMove)
            {
                int n = countUndo;
                for (int i = 1; i <= n; i++)
                {
                    bitmaps.RemoveAt(bitmaps.Count() - 1);
                    countUndo--;
                }
            }
            

            if ((Pen && isMouseMove) || (isEaraser && isMouseMove))
            {
                bitmaps.Add(Bpen_eraser);
                locationBitmap++;
                Bpen_eraser = (Bitmap)bitmaps.ElementAt(locationBitmap).Clone();
            }
            else if (shape != ShapeModes.None && isMouseMove)
            {
                Bitmap bitmap = (Bitmap)bitmaps.ElementAt(locationBitmap).Clone();
                grp = Graphics.FromImage(bitmap);
                locationBitmap++;

                switch (shape)
                {
                    case ShapeModes.DrawLine:
                        grp.DrawLine(new Pen(btnRightColor.BackColor, penSize), p1, p2);
                        break;
                    case ShapeModes.DrawRectangle:
                        grp.DrawRectangle(new Pen(btnRightColor.BackColor, penSize),
                        Math.Min(p1.X, p2.X),
                        Math.Min(p1.Y, p2.Y),
                        Math.Abs(p2.X - p1.X),
                        Math.Abs(p2.Y - p1.Y));
                        break;
                    case ShapeModes.DrawElipse:
                        grp.DrawEllipse(new Pen(btnRightColor.BackColor, penSize), p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
                        break;
                    case ShapeModes.DrawTriangular:
                        Point A = new Point((p2.X + p1.X) / 2, p1.Y);
                        Point B = new Point(p1.X, p2.Y);
                        Point C = new Point(p2.X, p2.Y);

                        grp.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), new Point[]{
                            A, B, C
                        });
                        break;
                    case ShapeModes.DrawHexagon:

                        float y = (float)((p2.Y - p1.Y) / 3);

                        PointF Top = new PointF((float)((p1.X + p2.X) / 2), p1.Y);
                        PointF TopLeft = new PointF(p1.X, p1.Y + y);
                        PointF TopRight = new PointF(p2.X, p1.Y + y);
                        PointF Bot = new PointF((float)((p1.X + p2.X) / 2), p2.Y);
                        PointF BotLeft = new PointF(p1.X, p2.Y - y);
                        PointF BotRight = new PointF(p2.X, p2.Y - y);

                        grp.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), new PointF[] {
                        Top, TopLeft, BotLeft, Bot, BotRight, TopRight
                        });
                        break;
                    case ShapeModes.DrawLeftRightArrow:
                        PointF[] pointFs = getPointOfLeftRightArrow(p1, p2);
                        grp.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), pointFs);
                        break;
                    case ShapeModes.DrawUpDownArrow:
                        PointF[] pointFss = getPointOfUpDownArrow(p1, p2);
                        grp.DrawPolygon(new Pen(btnRightColor.BackColor, penSize), pointFss);
                        break;
                }

                Bpen_eraser = (Bitmap)bitmap.Clone();
                bitmaps.Add(bitmap);
            }
            else
                p2 = new Point(p1.X, p1.Y);

            this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap).Clone();
            isMouseMove = false;
        }

        void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            lbLocation.Text = "(" + e.Location.X + ", " + e.Location.Y + ")";

            if (isDown)
            {
                if (countUndo > 0 && setUpBitMap_Pen_Eraser == false)
                {
                    Bpen_eraser = (Bitmap)bitmaps.ElementAt(locationBitmap).Clone();
                    setUpBitMap_Pen_Eraser = true;
                }

                if (Pen)
                {
                    grp = Graphics.FromImage(Bpen_eraser);
                    p2 = new Point(e.Location.X, e.Location.Y);
                    grpDraw = this.CreateGraphics();
                    grpDraw.DrawLine(new Pen(btnLeftColor.BackColor, penSize), p1, p2);
                    grp.DrawLine(new Pen(btnLeftColor.BackColor, penSize), p1, p2);
                    p1 = p2;
                }
                else if (isEaraser)
                {
                    grp = Graphics.FromImage(Bpen_eraser);

                    p2 = new Point(e.Location.X, e.Location.Y);
                    grpDraw = this.CreateGraphics();
                    grpDraw.DrawLine(new Pen(Color.White, 10), p1, p2);
                    grp.DrawLine(new Pen(Color.White, 10), p1, p2);

                    p1 = p2;
                }
                else
                {
                    p2 = new Point(e.Location.X, e.Location.Y);

                    this.Refresh();
                }

                isMouseMove = true;
            }


        }

        void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.Location.X, e.Location.Y);

            isDown = true;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Paint_Load(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();

            if (cld.ShowDialog() == DialogResult.OK)
            {
                if (bColor == ButtonColor.Left)
                {
                    btnLeftColor.BackColor = cld.Color;
                }
                else
                    btnRightColor.BackColor = cld.Color;
            }
        }

        private void btnLeftColor_Click(object sender, EventArgs e)
        {
            bColor = ButtonColor.Left;
        }

        private void btnRightColor_Click(object sender, EventArgs e)
        {
            bColor = ButtonColor.Right;
            
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            penSize = Convert.ToInt32(cbSize.SelectedItem);

        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawRectangle;
            Pen = false;
            isEaraser = false;
        }

        private void btnDrawElipse_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawElipse;
            Pen = false;
            isEaraser = false;
        }

        private void btnDrawPolygon_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawTriangular;
            Pen = false;
            isEaraser = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.None;
            Pen = true;
            isEaraser = false;
        }

        //private void Paint_MouseMove_1(object sender, MouseEventArgs e)
        //{
            
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            isEaraser = true;
            shape = ShapeModes.None;
            Pen = false;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            isEaraser = false;
            shape = ShapeModes.DrawHexagon;
            Pen = false;
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawLine;
            Pen = false;
            isEaraser = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLeftRightArrow_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawLeftRightArrow;
            Pen = false;
            isEaraser = false;
        }

        private void btnUpDownArrow_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.DrawUpDownArrow;
            Pen = false;
            isEaraser = false;
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            
        }

        PointF[] getPointOfLeftRightArrow(Point p1, Point p2)
        {
            List<PointF> listPoint = new List<PointF>();

            float y = (float)((p2.Y - p1.Y) / 4);

            PointF LeftTop = new PointF(p1.X, p1.Y + y);
            PointF LeftBot = new PointF(p1.X, p2.Y - y);
            PointF Mid1 = new PointF((float)(p1.X + p2.X)/2, p1.Y);
            PointF Mid2 = new PointF((float)(p1.X + p2.X) / 2, p1.Y + y);
            PointF Mid3 = new PointF((float)(p1.X + p2.X) / 2, p2.Y - y);
            PointF Mid4 = new PointF((float)(p1.X + p2.X) / 2, p2.Y);
            PointF Right = new PointF(p2.X, (float)(p2.Y + p1.Y)/2);

            listPoint.Add(LeftTop);
            listPoint.Add(Mid2);
            listPoint.Add(Mid1);
            listPoint.Add(Right);
            listPoint.Add(Mid4);
            listPoint.Add(Mid3);
            listPoint.Add(LeftBot);

            return listPoint.ToArray();
        }

        PointF[] getPointOfUpDownArrow(Point p1, Point p2)
        {
            List<PointF> listPoint = new List<PointF>();

            float y = (float)((p2.X - p1.X) / 4);

            PointF Top = new PointF((float)(p1.X + p2.X) / 2, p1.Y);
            PointF Mid1 = new PointF(p1.X, (float)(p2.Y + p1.Y) / 2);
            PointF Mid2 = new PointF(p1.X + y, (float)(p2.Y + p1.Y) / 2);
            PointF Mid3 = new PointF(p2.X - y, (float)(p2.Y + p1.Y) / 2);
            PointF Mid4 = new PointF(p2.X, (float)(p2.Y + p1.Y) / 2);
            PointF BotLeft = new PointF(p1.X + y, p2.Y);
            PointF BotRight = new PointF(p2.X - y, p2.Y);

            listPoint.Add(BotLeft);
            listPoint.Add(BotRight);
            listPoint.Add(Mid3);
            listPoint.Add(Mid4);
            listPoint.Add(Top);
            listPoint.Add(Mid1);
            listPoint.Add(Mid2);

            return listPoint.ToArray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = ShapeModes.None;

            bitmaps = new List<Bitmap>();


            bitmaps.Add(new Bitmap(this.Width, this.Height));
            Bpen_eraser = (Bitmap)bitmaps.ElementAt(0).Clone();
            locationBitmap = 0;
            grp = Graphics.FromImage(bitmaps.ElementAt(0));

            this.Refresh();

            this.BackgroundImage = (Bitmap)bitmaps.ElementAt(0).Clone();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            opd.Filter = "Bmp (*.bmp)|*.bmp|Jpeg (*.jpeg)|*.jpeg|Jpg (*.jpg)|*.jpg|Png (*.png)|*.png|All File|*.bmp;*.jpec;*.jpg;*.png";

            if (opd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opd.FileName);

                Bitmap ImageBitmap = new Bitmap(this.Width, this.Height);

                grp = Graphics.FromImage(ImageBitmap);

                Rectangle rec = new Rectangle(0, panelControl.Height, this.Width, this.Height - (panelBot.Height + panelControl.Height + menuStrip1.Height));

                grp.DrawImage(img, rec);

                if (countUndo > 0)
                {
                    int n = countUndo;
                    for (int i = 1; i <= n; i++)
                    {
                        bitmaps.RemoveAt(bitmaps.Count() - 1);
                        countUndo--;
                    }
                }

                bitmaps.Add(ImageBitmap);
                Bpen_eraser = (Bitmap)ImageBitmap.Clone();
                locationBitmap++;

                this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap).Clone();

            }
        }

        private void Paint_Resize(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Bmp (*.bmp)|*.bmp|Jpeg (*.jpeg)|*.jpeg|Jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
                bitmaps.ElementAt(locationBitmap).Save(sfd.FileName);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (locationBitmap > 0)
            {
                this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap - 1).Clone();
                shape = ShapeModes.None;
                locationBitmap--;

                countUndo++;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (locationBitmap < bitmaps.Count()- 1)
            {
                this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap + 1).Clone();
                shape = ShapeModes.None;
                locationBitmap++;
                countUndo--;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (locationBitmap > 0)
            {
                this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap - 1).Clone();
                shape = ShapeModes.None;
                locationBitmap--;

                countUndo++;
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (locationBitmap < bitmaps.Count() - 1)
            {
                this.BackgroundImage = (Bitmap)bitmaps.ElementAt(locationBitmap + 1).Clone();
                shape = ShapeModes.None;
                locationBitmap++;
                countUndo--;
            }
        }
    }
}
