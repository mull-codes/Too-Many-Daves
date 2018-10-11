using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TooManyDaves
{
    public partial class Form2 : Form
    {
        public string Year { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void sbmt_btn_Click(object sender, EventArgs e)
        {
            if (year_txt.Text == "")
            {
                ;
            }
            else
            {
                Year = year_txt.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (year_txt.CanFocus)
            {
                year_txt.Focus();
            }
        }
    }
}
