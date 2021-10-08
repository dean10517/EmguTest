using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EmguTest
{
    public partial class Form1 : Form
    {
        string imgSrcPath = "C:\\Users\\柏閔\\Desktop\\S__33857542.jpeg";
        string templSrc = "C:\\Users\\柏閔\\Desktop\\S__33857542_template.jpg";

        private VideoCapture usbCam;

        public Form1()
        {
            InitializeComponent();

            usbCam = new VideoCapture(0);
            usbCam.ImageGrabbed += UsbCam_ImageGrabbed;
        }

      
        private void UsbCam_ImageGrabbed(object sender, EventArgs e)
        {     
            //取得畫面
            Mat frame = new Mat();
            usbCam.Retrieve(frame);

            //畫十字線
            Point p1 = new Point(0, frame.Height / 2);
            Point p2 = new Point(frame.Width, frame.Height / 2);
            Point p3 = new Point(frame.Width / 2, 0);
            Point p4 = new Point(frame.Width / 2, frame.Height);
            CvInvoke.Line(frame, p1, p2, new MCvScalar(0, 255, 0, 0));
            CvInvoke.Line(frame, p3, p4, new MCvScalar(0, 255, 0, 0));

            //將加工後的畫面輸出到pictureBox上
            pic_Result.Image = frame.ToBitmap();

            //此延遲影響畫面更新率
            Thread.Sleep(100);
        }

        private void cmb_Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            Emgu.CV.CvEnum.TemplateMatchingType matchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccoeff;
            switch (cmb_Method.SelectedIndex)
            {
                case 0:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccoeff;
                    break;

                case 1:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed;
                    break;

                case 2:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccorr;
                    break;

                case 3:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed;
                    break;

                case 4:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff;
                    break;

                case 5:
                    matchingType = Emgu.CV.CvEnum.TemplateMatchingType.SqdiffNormed;
                    break;

            }

            Mat matSrc = new Mat(imgSrcPath);
            Mat matTemplate = new Mat(templSrc);
            Mat imgout = new Mat();

            // To resize the image             
            Size newSize1 = new Size(matSrc.Size.Width / 10, matSrc.Size.Height / 10);
            Size newSize2 = new Size(matTemplate.Size.Width / 10, matTemplate.Size.Height / 10);
            CvInvoke.Resize(matSrc, matSrc, newSize1);
            CvInvoke.Resize(matTemplate, matTemplate, newSize2);
            CvInvoke.MatchTemplate(matSrc, matTemplate, imgout, matchingType);


            double minVal = 0.0;
            double maxVal = 0.0;
            Point minLoc = new Point();
            Point maxLoc = new Point();

            pic_Template.Image = imgout.ToBitmap();
            CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

            Console.WriteLine(minVal + "," + maxVal);

            Rectangle r = new Rectangle(maxLoc, matTemplate.Size);
            CvInvoke.Rectangle(matSrc, r, new MCvScalar(255, 0, 0), 3);

            Rectangle r2 = new Rectangle(minLoc, matTemplate.Size);
            CvInvoke.Rectangle(matSrc, r2, new MCvScalar(0, 255, 0), 1);

            pic_Result.Image = matSrc.ToBitmap();
        }
       

        Point startPos;      // mouse-down position
        Point currentPos;    // current mouse position
        bool drawing;        // busy drawing
        private Rectangle getRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }
        private void pic_Result_MouseDown(object sender, MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;
        }
        private void pic_Result_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            currentPos = e.Location;
            if (drawing) picBox.Invalidate();            
        }
        private void pic_Result_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                var rc = getRectangle();
                (sender as PictureBox).Invalidate();
            }
        }
        private void pic_Result_Paint(object sender, PaintEventArgs e)
        {
            //Mat matSrc =  pic_Result.Image;
            


            if (drawing)
            {
                Mat matSrc = GetMatFromSDImage(pic_Result.Image);
                matSrc = new Mat(matSrc, getRectangle());
                //if (matSrc.GetData() != null)
                pic_Template.Image = matSrc.ToBitmap();
                e.Graphics.DrawRectangle(Pens.Red, getRectangle());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usbCam.Grab();
            //usbCam.
        }
        private void button2_Click(object sender, EventArgs e)
        {


        }

        

        private void chk_Stream_On_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                usbCam.Start();
                checkBox.Text = "ON";
            }
            else
            {
                usbCam.Stop();
                checkBox.Text = "OFF";
            }
        }

        private Mat GetMatFromSDImage(System.Drawing.Image image)
        {
            int stride = 0;
            Bitmap bmp = new Bitmap(image);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            System.Drawing.Imaging.PixelFormat pf = bmp.PixelFormat;
            if (pf == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            {
                stride = bmp.Width * 4;
            }
            else
            {
                stride = bmp.Width * 3;
            }

            Image<Bgra, byte> cvImage = new Image<Bgra, byte>(bmp.Width, bmp.Height, stride, (IntPtr)bmpData.Scan0);

            bmp.UnlockBits(bmpData);

            return cvImage.Mat;
        }
    }
}
