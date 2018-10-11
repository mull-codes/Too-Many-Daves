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
    public partial class AddNewChild : Form
    {
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string Likes { get; set; }

        public AddNewChild()
        {
            InitializeComponent();
        }

        private void AddNewChild_Load(object sender, EventArgs e)
        {
            if (txtFullName.CanFocus)
            {
                txtFullName.Focus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtLikes.Text == "")
            {
                pnlError.BackColor = Color.Coral;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Error, you must fill in all feilds!";
            }else
            {
                FullName = txtFullName.Text;
                DOB = dtpDOB.Text;
                Likes = txtLikes.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pnlError_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
