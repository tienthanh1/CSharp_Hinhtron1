using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Hinhtron1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double TinhDienTich( double bk) { return bk *bk *Math.PI; }
        double TinhChuVi(double bk) { return bk * 2 * Math.PI; }
        private void button1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = TinhDienTich(bankinh);
            lblkq.Text = "-Diện tích " + Convert.ToString(dientich);
            lblkq.Text = dientich.ToString();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double chuvi = TinhChuVi(bankinh);
            lblkq.Text = "-Chu vi " + Convert.ToString(chuvi);
            lblkq.Text = chuvi.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnloai1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbdientich.Checked)
            {
                double dientich = TinhDienTich(bankinh);
                string thongbao = "-Diện tích " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbchuvi.Checked)
            {
                double chuvi = TinhChuVi(bankinh);
                string thongbao = "-Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnloai2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (cbdientich.Checked)
            {
                double dientich = TinhDienTich(bankinh);
                thongbao = thongbao + "-Diện tích " + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (cbchuvi.Checked)
            {
                double chuvi = TinhChuVi(bankinh);
                thongbao = thongbao + "-Chu vi " + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
