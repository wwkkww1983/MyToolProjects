﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGeneratorTest.Business;
using CodeGeneratorTest.Business.Implements;
using AccessHelper;

namespace CodeGeneratorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F_userManager f_UserManager = new F_userManager();
            //int row = f_UserManager.Delete("id");
            var dataset = AccessHelper.DataSet("select * from TPlugLibraryDetail");
        }
    }
}
