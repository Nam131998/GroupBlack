﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_Demo
{
    public partial class ThongTinNhaHang : Form
    {
        public ThongTinNhaHang()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Hide();
                Form frm = new Index();
                frm.ShowDialog();
            }
        }
    }
}
