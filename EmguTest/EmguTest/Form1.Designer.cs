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
            this.pic_Result = new System.Windows.Forms.PictureBox();
            this.pic_Template = new System.Windows.Forms.PictureBox();
            this.cmb_Method = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chk_Stream_On = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Template)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Result
            // 
            this.pic_Result.Location = new System.Drawing.Point(253, 12);
            this.pic_Result.Name = "pic_Result";
            this.pic_Result.Size = new System.Drawing.Size(600, 651);
            this.pic_Result.TabIndex = 1;
            this.pic_Result.TabStop = false;
            this.pic_Result.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Result_Paint);
            this.pic_Result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseDown);
            this.pic_Result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseMove);
            this.pic_Result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_Result_MouseUp);
            // 
            // pic_Template
            // 
            this.pic_Template.Location = new System.Drawing.Point(859, 12);
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
            this.button1.Location = new System.Drawing.Point(1011, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1129, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Test";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 675);
            this.Controls.Add(this.chk_Stream_On);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Method);
            this.Controls.Add(this.pic_Template);
            this.Controls.Add(this.pic_Result);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Template)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Result;
        private System.Windows.Forms.PictureBox pic_Template;
        private System.Windows.Forms.ComboBox cmb_Method;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chk_Stream_On;
    }
}

