﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class DepartmentModule : Form
    {
        public DepartmentModule()
        {
            InitializeComponent();
        }

        private void DepartmentModule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Dept b1 = new Add_Dept();
            b1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void del_dept_Click(object sender, EventArgs e)
        {

        }
    }
}
