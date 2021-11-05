using Emgu.CV;
using Emgu.CV.IntensityTransform;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
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
        private Mat currFrame = new Mat();      //當前原始影像
        private Mat matTemplate = new Mat();    //目標影像
        private Mat matResult = new Mat();      //尋找後結果影像
        private Mat matGray = new Mat();        //灰階影像

        //Match 所需要的參數
        private double minVal = 0.0;
        private double maxVal = 0.0;
        private Point minLoc = new Point();
        private Point maxLoc = new Point();

        //搜尋結果的方框繪製參數
        MCvScalar color1 = new MCvScalar(255, 0, 0);
        MCvScalar color2 = new MCvScalar(0, 255, 0);
        Rectangle rect;
        Rectangle rect2;

        private Emgu.CV.CvEnum.TemplateMatchingType matchingType = Emgu.CV.CvEnum.TemplateMatchingType.Ccoeff;

        public Form1()
        {
            InitializeComponent();

            usbCam = new VideoCapture(0);
            usbCam.ImageGrabbed += UsbCam_ImageGrabbed;
        }

        private void UsbCam_ImageGrabbed(object sender, EventArgs e)
        {            
            Mat copyFrame = new Mat();  //含十字的畫面

            //取得畫面
            usbCam.Retrieve(currFrame);
            currFrame.CopyTo(copyFrame);

            //畫十字線
            Point p1 = new Point(0, copyFrame.Height / 2);
            Point p2 = new Point(copyFrame.Width, copyFrame.Height / 2);
            Point p3 = new Point(copyFrame.Width / 2, 0);
            Point p4 = new Point(copyFrame.Width / 2, copyFrame.Height);
            CvInvoke.Line(copyFrame, p1, p2, new MCvScalar(0, 255, 0, 0));
            CvInvoke.Line(copyFrame, p3, p4, new MCvScalar(0, 255, 0, 0));

            //將加工後的畫面輸出到pictureBox上
            pic_Src.Image = copyFrame.ToBitmap();

            //histogramBox1.ClearHistogram();
            //histogramBox1.GenerateHistograms(copyFrame, 256);
            //histogramBox1.Refresh();

            //此延遲影響畫面更新率
            Thread.Sleep(100);

            //Match
            if (matTemplate.DataPointer != IntPtr.Zero)   //須有樣板Template才能做Match
            {
                //CvInvoke.MatchTemplate(currFrame, matTemplate, matResult, matchingType);
                //CvInvoke.MinMaxLoc(matResult, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                //rect = new Rectangle(maxLoc, matTemplate.Size);
                //rect2 = new Rectangle(minLoc, matTemplate.Size);

                //Mat srcCopy = new Mat();
                //currFrame.CopyTo(srcCopy);
                //CvInvoke.Rectangle(srcCopy, rect, color1, 3);
                //CvInvoke.Rectangle(srcCopy, rect2, color2, 1);                
                //picBoxInvoke(pic_Result, srcCopy.ToBitmap());                
            }
        }

        private void cmb_Method_SelectedIndexChanged(object sender, EventArgs e)
        {            
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

            //Mat matSrc = new Mat(imgSrcPath);
            //Mat matTemplate = new Mat(templSrc);
            //Mat imgout = new Mat();

            //// To resize the image             
            //Size newSize1 = new Size(matSrc.Size.Width / 10, matSrc.Size.Height / 10);
            //Size newSize2 = new Size(matTemplate.Size.Width / 10, matTemplate.Size.Height / 10);
            //CvInvoke.Resize(matSrc, matSrc, newSize1);
            //CvInvoke.Resize(matTemplate, matTemplate, newSize2);
            //CvInvoke.MatchTemplate(matSrc, matTemplate, imgout, matchingType);


            //double minVal = 0.0;
            //double maxVal = 0.0;
            //Point minLoc = new Point();
            //Point maxLoc = new Point();

            //pic_Template.Image = imgout.ToBitmap();
            //CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

            //Console.WriteLine(minVal + "," + maxVal);

            //Rectangle r = new Rectangle(maxLoc, matTemplate.Size);
            //CvInvoke.Rectangle(matSrc, r, new MCvScalar(255, 0, 0), 3);

            //Rectangle r2 = new Rectangle(minLoc, matTemplate.Size);
            //CvInvoke.Rectangle(matSrc, r2, new MCvScalar(0, 255, 0), 1);

            //pic_Src.Image = matSrc.ToBitmap();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            usbCam.Grab();
            //usbCam.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //IntensityTransformInvoke.GammaCorrection(currFrame, matResult, float.Parse(tb_GamaVal.Text));

            CvInvoke.MatchTemplate(currFrame, matTemplate, matResult, matchingType);
            CvInvoke.MinMaxLoc(matResult, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            //Console.WriteLine(minVal + "," + maxVal);

            rect = new Rectangle(maxLoc, matTemplate.Size);
            rect2 = new Rectangle(minLoc, matTemplate.Size);

            CvInvoke.Rectangle(currFrame, rect, color1, 1);
            CvInvoke.Rectangle(currFrame, rect2, color2, 1);
            //Mat matGray = new Mat();
            //CvInvoke.CvtColor(currFrame, matGray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

            //CvInvoke.CLAHE(matGray, 40, matGray.Size, matResult);
            pic_Result.Image = currFrame.ToBitmap();


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

        Point startPos;      // mouse-down position
        Point currentPos;    // current mouse position
        bool drawing;        // busy drawing
        private Rectangle getRectangle()
        {
            //return nothing if high or weidth are zero
            if ((startPos.X == currentPos.X) || (startPos.Y == currentPos.Y)) return new Rectangle();

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
            if (drawing)
            {
                Rectangle r = getRectangle();
                if (r.Height == 0) return;  //判斷是否有選取矩形

                matTemplate = new Mat(currFrame,r);
                pic_Template.Image = matTemplate.ToBitmap();
                e.Graphics.DrawRectangle(Pens.Red, getRectangle());
            }
        }

        //image to Mat
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

        //invoke function
        public void picBoxInvoke(PictureBox picBox,Image img)
        {
            if (picBox.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action safeWrite = delegate { picBoxInvoke(picBox,img); };
                picBox.Invoke(safeWrite);
            }
            else
                picBox.Image = img;
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            CvInvoke.CvtColor(currFrame, matResult, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            pic_Result.Image = matResult.ToBitmap();

            histogramBox2.ClearHistogram();
            histogramBox2.GenerateHistograms(matResult, 256);
            histogramBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CvInvoke.CvtColor(currFrame, matResult, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.CLAHE(matResult, double.Parse(tb_ClipLimit.Text),new Size(int.Parse(tb_GridSize.Text), int.Parse(tb_GridSize.Text)), matResult);
            pic_Result.Image = matResult.ToBitmap();

            histogramBox2.ClearHistogram();
            histogramBox2.GenerateHistograms(matResult, 256);
            histogramBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i =0;i < matGray.Rows; i++)
            {
                for(int j = 0; j < matGray.Cols; j++)
                {
                    //matGray.at
                }
            }
        }
    }
}
