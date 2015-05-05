using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int svmax,svmin,pvmax,pvmin,mvmax,mvmin,sv,pv,mv,adjust;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Pb_unchoose1.BringToFront();
            pb_unchoose2.BringToFront();
            timer1.Enabled = false;
         

        }


        //报表
        private void pb_baobiao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("报表");
        }



        //图像
        private void pb_picture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图像");
        }



//手动按钮
        private void bt_byhand_Click(object sender, EventArgs e)    
        {
           
            pb_unchoose2.BringToFront();
            pb_light1.BringToFront();
            timer1.Enabled = false;
            if (InputValid() && DataValid(svmax, svmin, mvmax, mvmin, pvmax, pvmin))
            {
                  pb_up.Show();
                  pb_down.Show();
                  cb_precision.Show();
                if (sv == 0)
                { 
                    sv = (svmax - svmin) / 2+svmin;
                    pv = (pvmax - pvmin) / 2+pvmin;
                    mv = (mvmax - mvmin) / 2+mvmin;
                }
              
            }
            else
            {
              Pb_unchoose1.BringToFront();
            }
        
        }



        //手动向上
        private void pb_down_Click(object sender, EventArgs e)  
        {
            if (cb_precision.SelectedIndex == -1)
            {
                MessageBox.Show("请选择正确的调整精度");
            }
            else
            {
                GetSelectedValue(cb_precision.SelectedIndex);
                if (sv - adjust > svmin)
                {
                    sv = sv - adjust;
                }
                else
                {
                    sv = 120;
                }
                settingheight(sv, pv, mv);
            }

        }




        //手动向下
        private void pb_up_Click(object sender, EventArgs e)
        {
            if (cb_precision.SelectedIndex == -1)
            {
                MessageBox.Show("请选择正确的调整精度");
            }
            else
            {
                GetSelectedValue(cb_precision.SelectedIndex);
                if (sv + adjust < svmax)
                {
                    sv = sv + adjust;
                }
                else
                {
                    sv = svmax;
                }
                settingheight(sv, pv, mv);

            }
        }




//自动按钮
        private void bt_auto_Click(object sender, EventArgs e)        
        {   
            Pb_unchoose1.BringToFront();
            pb_light2.BringToFront();
            
            if (InputValid() && DataValid(svmax, svmin, mvmax, mvmin, pvmax, pvmin))
            {
            timer1.Enabled = true;
            }
             else
            {
                 pb_unchoose2.BringToFront();
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            sv = rand.Next(svmin, svmax);
            pv = rand.Next(pvmin, pvmax);
            mv = rand.Next(mvmin, mvmax);
            settingheight(sv, pv, mv);
        }



        //判断输入类型是否合法
        private bool InputValid()
        {
            try
            {

                svmax = int.Parse(tb_SvMax.Text.Trim());
                svmin = int.Parse(tb_SvMin.Text.Trim());
                pvmax = int.Parse(tb_PvMax.Text.Trim());
                pvmin = int.Parse(tb_PvMin.Text.Trim());
                mvmax = int.Parse(tb_MvMax.Text.Trim());
                mvmin = int.Parse(tb_MvMin.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数值");
                return false;
            }

            return true;
        }



        //判断数据是否合法
        private bool DataValid(int sv_max, int sv_min, int mv_max, int mv_min, int pv_max, int pv_min)
        {
            if (sv_max > 30000 || pv_max > 30000 || mv_max > 100)
            {
                MessageBox.Show("请选择合适的最大值");
                //  tb_MvMax.Text = ""; tb_PvMax.Text = ""; tb_SvMax.Text = "";
                return false;
            }
            else if (mv_min < 0 || pv_min < 0 || sv_min < 0)
            {
                MessageBox.Show("请选择合适的最小值");
                // tb_SvMin.Text = ""; tb_PvMin.Text = ""; tb_MvMin.Text = "";
                return false;
            }
            else if (sv_max < sv_min || mv_max < mv_min || pv_max < pv_min)
            {
                MessageBox.Show("最大值必须大于最小值");
                return false;
            }
            else
            {
                return true;
            }
        }





//得到选择精度
        private void GetSelectedValue(int i)   
        {
            switch (i)
            { 
                case 0:
                    adjust=1;
                break;
                case 1:
                    adjust=10;
                break;
                case 2:
                    adjust=100;
                break;
                case 3:
                    adjust=1000;
                break;
                case 4:
                    adjust=10000;
                    break;
            }
        
        }




        //设置柱形图的高度
        private void settingheight(int y_sv, int y_pv, int y_mv)
        {

            int x_sv = 120 - 120 * (y_sv - svmin) / (svmax - svmin);
            int x_mv = 120 - 120 * (y_mv - mvmin) / (mvmax - mvmin);
            int x_pv = 120 - 120 * (y_pv - pvmin) / (pvmax - pvmin);
            lb_mvback.Height = x_mv;
            lb_Svback.Height = x_sv;
            lb_pvback.Height = x_pv;
            tbsv.Text = y_sv.ToString();
            tbmv.Text = y_mv.ToString();
            tbpv.Text = y_pv.ToString();
        }
     

    }
}
