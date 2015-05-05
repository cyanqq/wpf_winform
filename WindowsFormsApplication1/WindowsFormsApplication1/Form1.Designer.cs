namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_byhand = new System.Windows.Forms.Button();
            this.bt_auto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbmv = new System.Windows.Forms.TextBox();
            this.tbpv = new System.Windows.Forms.TextBox();
            this.tbsv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_precision = new System.Windows.Forms.ComboBox();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_mvback = new System.Windows.Forms.Label();
            this.lb_pvback = new System.Windows.Forms.Label();
            this.lb_Svback = new System.Windows.Forms.Label();
            this.lb_svfont = new System.Windows.Forms.Label();
            this.lb_mvfont = new System.Windows.Forms.Label();
            this.lb_pvfont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.pb_baobiao = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_SvMax = new System.Windows.Forms.TextBox();
            this.tb_SvMin = new System.Windows.Forms.TextBox();
            this.tb_PvMax = new System.Windows.Forms.TextBox();
            this.tb_PvMin = new System.Windows.Forms.TextBox();
            this.tb_MvMax = new System.Windows.Forms.TextBox();
            this.tb_MvMin = new System.Windows.Forms.TextBox();
            this.Pb_unchoose1 = new System.Windows.Forms.PictureBox();
            this.pb_unchoose2 = new System.Windows.Forms.PictureBox();
            this.pb_light1 = new System.Windows.Forms.PictureBox();
            this.pb_light2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baobiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_unchoose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unchoose2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_light2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_byhand
            // 
            this.bt_byhand.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_byhand.Location = new System.Drawing.Point(6, 7);
            this.bt_byhand.Name = "bt_byhand";
            this.bt_byhand.Size = new System.Drawing.Size(52, 23);
            this.bt_byhand.TabIndex = 0;
            this.bt_byhand.Text = "手动";
            this.bt_byhand.UseVisualStyleBackColor = true;
            this.bt_byhand.Click += new System.EventHandler(this.bt_byhand_Click);
            // 
            // bt_auto
            // 
            this.bt_auto.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_auto.Location = new System.Drawing.Point(7, 53);
            this.bt_auto.Name = "bt_auto";
            this.bt_auto.Size = new System.Drawing.Size(52, 23);
            this.bt_auto.TabIndex = 1;
            this.bt_auto.Text = "自动";
            this.bt_auto.UseVisualStyleBackColor = true;
            this.bt_auto.Click += new System.EventHandler(this.bt_auto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.tbmv);
            this.panel1.Controls.Add(this.tbpv);
            this.panel1.Controls.Add(this.tbsv);
            this.panel1.Location = new System.Drawing.Point(76, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 86);
            this.panel1.TabIndex = 2;
            // 
            // tbmv
            // 
            this.tbmv.Location = new System.Drawing.Point(42, 59);
            this.tbmv.Name = "tbmv";
            this.tbmv.Size = new System.Drawing.Size(49, 21);
            this.tbmv.TabIndex = 5;
            // 
            // tbpv
            // 
            this.tbpv.Location = new System.Drawing.Point(42, 33);
            this.tbpv.Name = "tbpv";
            this.tbpv.Size = new System.Drawing.Size(49, 21);
            this.tbpv.TabIndex = 4;
            // 
            // tbsv
            // 
            this.tbsv.Location = new System.Drawing.Point(42, 7);
            this.tbsv.Name = "tbsv";
            this.tbsv.Size = new System.Drawing.Size(49, 21);
            this.tbsv.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.cb_precision);
            this.panel2.Controls.Add(this.pb_down);
            this.panel2.Controls.Add(this.pb_up);
            this.panel2.Controls.Add(this.lb_mvback);
            this.panel2.Controls.Add(this.lb_pvback);
            this.panel2.Controls.Add(this.lb_Svback);
            this.panel2.Controls.Add(this.lb_svfont);
            this.panel2.Controls.Add(this.lb_mvfont);
            this.panel2.Controls.Add(this.lb_pvfont);
            this.panel2.Location = new System.Drawing.Point(4, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 177);
            this.panel2.TabIndex = 3;
            // 
            // cb_precision
            // 
            this.cb_precision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_precision.FormattingEnabled = true;
            this.cb_precision.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000",
            "10000"});
            this.cb_precision.Location = new System.Drawing.Point(56, 151);
            this.cb_precision.Name = "cb_precision";
            this.cb_precision.Size = new System.Drawing.Size(73, 20);
            this.cb_precision.TabIndex = 9;
            this.cb_precision.Visible = false;
            // 
            // pb_down
            // 
            this.pb_down.Image = ((System.Drawing.Image)(resources.GetObject("pb_down.Image")));
            this.pb_down.Location = new System.Drawing.Point(31, 169);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(13, 7);
            this.pb_down.TabIndex = 8;
            this.pb_down.TabStop = false;
            this.pb_down.Visible = false;
            this.pb_down.Click += new System.EventHandler(this.pb_down_Click);
            // 
            // pb_up
            // 
            this.pb_up.Image = ((System.Drawing.Image)(resources.GetObject("pb_up.Image")));
            this.pb_up.Location = new System.Drawing.Point(31, 150);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(13, 8);
            this.pb_up.TabIndex = 7;
            this.pb_up.TabStop = false;
            this.pb_up.Visible = false;
            this.pb_up.Click += new System.EventHandler(this.pb_up_Click);
            // 
            // lb_mvback
            // 
            this.lb_mvback.BackColor = System.Drawing.Color.Silver;
            this.lb_mvback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_mvback.Location = new System.Drawing.Point(133, 28);
            this.lb_mvback.Name = "lb_mvback";
            this.lb_mvback.Size = new System.Drawing.Size(25, 60);
            this.lb_mvback.TabIndex = 3;
            // 
            // lb_pvback
            // 
            this.lb_pvback.BackColor = System.Drawing.Color.Silver;
            this.lb_pvback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_pvback.Location = new System.Drawing.Point(79, 27);
            this.lb_pvback.Name = "lb_pvback";
            this.lb_pvback.Size = new System.Drawing.Size(25, 60);
            this.lb_pvback.TabIndex = 2;
            // 
            // lb_Svback
            // 
            this.lb_Svback.BackColor = System.Drawing.Color.Silver;
            this.lb_Svback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Svback.Location = new System.Drawing.Point(25, 27);
            this.lb_Svback.Name = "lb_Svback";
            this.lb_Svback.Size = new System.Drawing.Size(25, 60);
            this.lb_Svback.TabIndex = 0;
            // 
            // lb_svfont
            // 
            this.lb_svfont.BackColor = System.Drawing.Color.Lime;
            this.lb_svfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_svfont.Location = new System.Drawing.Point(25, 27);
            this.lb_svfont.Name = "lb_svfont";
            this.lb_svfont.Size = new System.Drawing.Size(25, 120);
            this.lb_svfont.TabIndex = 1;
            // 
            // lb_mvfont
            // 
            this.lb_mvfont.BackColor = System.Drawing.Color.Blue;
            this.lb_mvfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mvfont.Location = new System.Drawing.Point(133, 27);
            this.lb_mvfont.Name = "lb_mvfont";
            this.lb_mvfont.Size = new System.Drawing.Size(25, 120);
            this.lb_mvfont.TabIndex = 5;
            // 
            // lb_pvfont
            // 
            this.lb_pvfont.BackColor = System.Drawing.Color.Red;
            this.lb_pvfont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pvfont.Location = new System.Drawing.Point(79, 28);
            this.lb_pvfont.Name = "lb_pvfont";
            this.lb_pvfont.Size = new System.Drawing.Size(25, 120);
            this.lb_pvfont.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 10);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(130, 400);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(18, 15);
            this.pb_picture.TabIndex = 6;
            this.pb_picture.TabStop = false;
            this.pb_picture.Click += new System.EventHandler(this.pb_picture_Click);
            // 
            // pb_baobiao
            // 
            this.pb_baobiao.Image = ((System.Drawing.Image)(resources.GetObject("pb_baobiao.Image")));
            this.pb_baobiao.Location = new System.Drawing.Point(157, 400);
            this.pb_baobiao.Name = "pb_baobiao";
            this.pb_baobiao.Size = new System.Drawing.Size(19, 15);
            this.pb_baobiao.TabIndex = 7;
            this.pb_baobiao.TabStop = false;
            this.pb_baobiao.Click += new System.EventHandler(this.pb_baobiao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "上限";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(115, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "下限";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "MV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "PV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "SV";
            // 
            // tb_SvMax
            // 
            this.tb_SvMax.Location = new System.Drawing.Point(51, 315);
            this.tb_SvMax.Name = "tb_SvMax";
            this.tb_SvMax.Size = new System.Drawing.Size(49, 21);
            this.tb_SvMax.TabIndex = 13;
            // 
            // tb_SvMin
            // 
            this.tb_SvMin.Location = new System.Drawing.Point(109, 315);
            this.tb_SvMin.Name = "tb_SvMin";
            this.tb_SvMin.Size = new System.Drawing.Size(49, 21);
            this.tb_SvMin.TabIndex = 14;
            // 
            // tb_PvMax
            // 
            this.tb_PvMax.Location = new System.Drawing.Point(51, 339);
            this.tb_PvMax.Name = "tb_PvMax";
            this.tb_PvMax.Size = new System.Drawing.Size(49, 21);
            this.tb_PvMax.TabIndex = 15;
            // 
            // tb_PvMin
            // 
            this.tb_PvMin.Location = new System.Drawing.Point(109, 339);
            this.tb_PvMin.Name = "tb_PvMin";
            this.tb_PvMin.Size = new System.Drawing.Size(49, 21);
            this.tb_PvMin.TabIndex = 16;
            // 
            // tb_MvMax
            // 
            this.tb_MvMax.Location = new System.Drawing.Point(51, 362);
            this.tb_MvMax.Name = "tb_MvMax";
            this.tb_MvMax.Size = new System.Drawing.Size(49, 21);
            this.tb_MvMax.TabIndex = 17;
            // 
            // tb_MvMin
            // 
            this.tb_MvMin.Location = new System.Drawing.Point(109, 363);
            this.tb_MvMin.Name = "tb_MvMin";
            this.tb_MvMin.Size = new System.Drawing.Size(49, 21);
            this.tb_MvMin.TabIndex = 18;
            // 
            // Pb_unchoose1
            // 
            this.Pb_unchoose1.Image = ((System.Drawing.Image)(resources.GetObject("Pb_unchoose1.Image")));
            this.Pb_unchoose1.Location = new System.Drawing.Point(23, 33);
            this.Pb_unchoose1.Name = "Pb_unchoose1";
            this.Pb_unchoose1.Size = new System.Drawing.Size(21, 21);
            this.Pb_unchoose1.TabIndex = 19;
            this.Pb_unchoose1.TabStop = false;
            // 
            // pb_unchoose2
            // 
            this.pb_unchoose2.Image = ((System.Drawing.Image)(resources.GetObject("pb_unchoose2.Image")));
            this.pb_unchoose2.Location = new System.Drawing.Point(24, 78);
            this.pb_unchoose2.Name = "pb_unchoose2";
            this.pb_unchoose2.Size = new System.Drawing.Size(21, 21);
            this.pb_unchoose2.TabIndex = 20;
            this.pb_unchoose2.TabStop = false;
            // 
            // pb_light1
            // 
            this.pb_light1.Image = ((System.Drawing.Image)(resources.GetObject("pb_light1.Image")));
            this.pb_light1.Location = new System.Drawing.Point(24, 32);
            this.pb_light1.Name = "pb_light1";
            this.pb_light1.Size = new System.Drawing.Size(22, 21);
            this.pb_light1.TabIndex = 0;
            this.pb_light1.TabStop = false;
            // 
            // pb_light2
            // 
            this.pb_light2.Image = ((System.Drawing.Image)(resources.GetObject("pb_light2.Image")));
            this.pb_light2.Location = new System.Drawing.Point(24, 76);
            this.pb_light2.Name = "pb_light2";
            this.pb_light2.Size = new System.Drawing.Size(24, 29);
            this.pb_light2.TabIndex = 21;
            this.pb_light2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(188, 425);
            this.Controls.Add(this.pb_light2);
            this.Controls.Add(this.pb_unchoose2);
            this.Controls.Add(this.tb_MvMin);
            this.Controls.Add(this.tb_MvMax);
            this.Controls.Add(this.tb_PvMin);
            this.Controls.Add(this.tb_PvMax);
            this.Controls.Add(this.tb_SvMin);
            this.Controls.Add(this.tb_SvMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_baobiao);
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_auto);
            this.Controls.Add(this.bt_byhand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_light1);
            this.Controls.Add(this.Pb_unchoose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "煤气流量设定值调整";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baobiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_unchoose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_unchoose2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_light2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_byhand;
        private System.Windows.Forms.Button bt_auto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbmv;
        private System.Windows.Forms.TextBox tbpv;
        private System.Windows.Forms.TextBox tbsv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.PictureBox pb_baobiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_SvMax;
        private System.Windows.Forms.TextBox tb_SvMin;
        private System.Windows.Forms.TextBox tb_PvMax;
        private System.Windows.Forms.TextBox tb_PvMin;
        private System.Windows.Forms.TextBox tb_MvMax;
        private System.Windows.Forms.TextBox tb_MvMin;
        private System.Windows.Forms.PictureBox Pb_unchoose1;
        private System.Windows.Forms.PictureBox pb_unchoose2;
        private System.Windows.Forms.PictureBox pb_light1;
        private System.Windows.Forms.PictureBox pb_light2;
        private System.Windows.Forms.Label lb_svfont;
        private System.Windows.Forms.Label lb_Svback;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_mvback;
        private System.Windows.Forms.Label lb_pvback;
        private System.Windows.Forms.Label lb_mvfont;
        private System.Windows.Forms.Label lb_pvfont;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.ComboBox cb_precision;
    }
}

