﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class schedule_detail : Form
    {
        public schedule_detail()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //フォームが最大化されないようにする
            this.MaximizeBox = false;
            //フォームが最小化されないようにする
            this.MinimizeBox = false;
            //フォームの現在の大きさを最大サイズとする
            this.MaximumSize = this.Size;
            //ユーザーがサイズを変更できないようにする
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

    }
}

