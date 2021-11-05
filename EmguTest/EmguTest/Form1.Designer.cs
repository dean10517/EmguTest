namespace EmguTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_Src = new System.Windows.Forms.PictureBox();
            this.pic_Template = new System.Windows.Forms.PictureBox();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chk_Stream_On = new System.Windows.Forms.CheckBox();
            this.pic_Result = new System.Windows.Forms.PictureBox();
            this.tb_GamaVal = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_ClipLimit = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.tb_GridSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Template)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Src
            // 
            this.pic_Src.Location = new System.Drawing.Point(253, 12);
            this.pic_Src.Name = "pic_Src";
            this.pic_Src.Size = new System.Drawing.Size(640, 480);
            this.pic_Src.TabIndex = 1;
            this.pic_Src.TabStop = false;
            this.pic_Src.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Result_Paint);
            this.pic_Src.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseDown);
            this.pic_Src.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseMove);
            this.pic_Src.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseUp);
            // 
            // pic_Template
            // 
            this.pic_Template.Location = new System.Drawing.Point(12, 148);
            this.pic_Template.Name = "pic_Template";
            this.pic_Template.Size = new System.Drawing.Size(227, 190);
            this.pic_Template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Template.TabIndex = 2;
            this.pic_Template.TabStop = false;
            // 
            // cmb_Method
            // 
            this.cmb_Method.FormattingEnabled = true;
            this.cmb_Method.Items.AddRange(new object[] {
            "Sqdiff",
            "SqdiffNormed",
            "Ccorr",
            "CcorrNormed",
            "Ccoeff",
            "CcoeffNormed"});
            this.cmb_Method.Location = new System.Drawing.Point(12, 13);
            this.cmb_Method.Name = "cmb_Method";
            this.cmb_Method.Size = new System.Drawing.Size(121, 20);
            this.cmb_Method.TabIndex = 3;
            this.cmb_Method.SelectedIndexChanged += new System.EventHandler(this.cmb_Method_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grabe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Match";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chk_Stream_On
            // 
            this.chk_Stream_On.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_Stream_On.AutoSize = true;
            this.chk_Stream_On.Location = new System.Drawing.Point(98, 56);
            this.chk_Stream_On.Name = "chk_Stream_On";
            this.chk_Stream_On.Size = new System.Drawing.Size(35, 22);
            this.chk_Stream_On.TabIndex = 6;
            this.chk_Stream_On.Text = "OFF";
            this.chk_Stream_On.UseVisualStyleBackColor = true;
            this.chk_Stream_On.CheckedChanged += new System.EventHandler(this.chk_Stream_On_CheckedChanged);
            // 
            // pic_Result
            // 
            this.pic_Result.Location = new System.Drawing.Point(899, 12);
            this.pic_Result.Name = "pic_Result";
            this.pic_Result.Size = new System.Drawing.Size(640, 480);
            this.pic_Result.TabIndex = 7;
            this.pic_Result.TabStop = false;
            // 
            // tb_GamaVal
            // 
            this.tb_GamaVal.Location = new System.Drawing.Point(121, 641);
            this.tb_GamaVal.Name = "tb_GamaVal";
            this.tb_GamaVal.Size = new System.Drawing.Size(100, 22);
            this.tb_GamaVal.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Gray";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 612);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "CLAHE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_ClipLimit
            // 
            this.tb_ClipLimit.Location = new System.Drawing.Point(121, 669);
            this.tb_ClipLimit.Name = "tb_ClipLimit";
            this.tb_ClipLimit.Size = new System.Drawing.Size(100, 22);
            this.tb_ClipLimit.TabIndex = 11;
            this.tb_ClipLimit.Text = "0.2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(177, 583);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 52);
            this.button5.TabIndex = 12;
            this.button5.Text = "test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(253, 498);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(640, 237);
            this.histogramBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.histogramBox1.TabIndex = 2;
            this.histogramBox1.TabStop = false;
            // 
            // tb_GridSize
            // 
            this.tb_GridSize.Location = new System.Drawing.Point(121, 697);
            this.tb_GridSize.Name = "tb_GridSize";
            this.tb_GridSize.Size = new System.Drawing.Size(100, 22);
            this.tb_GridSize.TabIndex = 13;
            this.tb_GridSize.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "GamaVal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "ClipLimit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "GridSize";
            // 
            // histogramBox2
            // 
            this.histogramBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.histogramBox2.Location = new System.Drawing.Point(899, 498);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(640, 237);
            this.histogramBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox2.TabIndex = 17;
            this.histogramBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 914);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_GridSize);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tb_ClipLimit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_GamaVal);
            this.Controls.Add(this.pic_Result);
            this.Controls.Add(this.chk_Stream_On);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Method);
            this.Controls.Add(this.pic_Template);
            this.Controls.Add(this.pic_Src);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Template)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Src;
        private System.Windows.Forms.PictureBox pic_Template;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chk_Stream_On;
        private System.Windows.Forms.PictureBox pic_Result;
        private System.Windows.Forms.TextBox tb_GamaVal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_ClipLimit;
        private System.Windows.Forms.Button button5;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.TextBox tb_GridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.HistogramBox histogramBox2;
    }
}

