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
    public partial class InfoGraph : Form
    {
        public List<string> UpComingBirthdays = new List<string>();
        public List<string> NewChildren = new List<string>();
        public int SingPercentage { get; set; }
        public int TwinPercentage { get; set; }
        public int TripletPercentage { get; set; }
        public int QuadrupletPercentage { get; set; }
        public InfoGraph()
        {
            InitializeComponent();
        }

        private void InfoGraph_Load(object sender, EventArgs e)
        {
            MultiBirthChart.Series["Series1"].Points[0].SetValueY(SingPercentage);
            MultiBirthChart.Series["Series1"].Points[1].SetValueY(TwinPercentage);
            MultiBirthChart.Series["Series1"].Points[2].SetValueY(TripletPercentage);


            lstViewBirthDay.Items.Clear();
            foreach (string s in UpComingBirthdays)
            {
                ListViewItem lvi = new ListViewItem(s);
                lstViewBirthDay.Items.Add(lvi);
            }

            if (lstViewBirthDay.Items.Count < 1) //Checks if the list contains zero(0) items if so then simply output the following message
            {
                lstViewBirthDay.Items.Add("Opps, it's not birthday season");
                lstViewBirthDay.Items.Add("we don't sale cake.");
            }




            lstViewNewChildren.Items.Clear();
            foreach (string s in NewChildren)
            {
                ListViewItem lvi = new ListViewItem(s);
                lstViewNewChildren.Items.Add(lvi);
            }

            if (lstViewNewChildren.Items.Count < 1) //Checks if the list contains zero(0) items if so then simply output the following message
            {
                lstViewNewChildren.Items.Add("Opps, no new children");
            }

            //lblTest.Text = test;
        }
    }
}
