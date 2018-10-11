using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TooManyDaves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Declaration of class Person with List
        List<Person> PersonList = new List<Person>();
        List<string> NewChildren = new List<string>();

        int SinglePercentage = 0, TwinPercentage = 0, TripletPercentage = 0, QuadrupletPercentage = 0;

        public void GenerateListViewCalulateAge()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_age = new ColumnHeader();
            // Set its text to be displayed
            header_age.Text = "Age";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_age);
            lstView.Columns[1].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_dob = new ColumnHeader();
            // Set its text to be displayed
            header_dob.Text = "DOB";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_dob);
            lstView.Columns[2].Width = 216;
        }

        public void GenerateListViewMonthlyAllowance()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_age = new ColumnHeader();
            // Set its text to be displayed
            header_age.Text = "DOB";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_age);
            lstView.Columns[1].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_Amount = new ColumnHeader();
            // Set its text to be displayed
            header_Amount.Text = "Amount";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_Amount);
            lstView.Columns[2].Width = 216;
        }

        public void GenerateListViewMultipleBirth()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_age = new ColumnHeader();
            // Set its text to be displayed
            header_age.Text = "DOB";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_age);
            lstView.Columns[1].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_MultipleBirth = new ColumnHeader();
            // Set its text to be displayed
            header_MultipleBirth.Text = "Multiple Birth";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_MultipleBirth);
            lstView.Columns[2].Width = 216;
        }


        public void GenerateListViewCalulateSchoolTimes()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_age = new ColumnHeader();
            // Set its text to be displayed
            header_age.Text = "Age";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_age);
            lstView.Columns[1].Width = 216;

            // Create a ColumnHeader object
            ColumnHeader header_school = new ColumnHeader();
            // Set its text to be displayed
            header_school.Text = "School position";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_school);
            lstView.Columns[2].Width = 216;
        }

        public void GenerateListViewSearch()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 200;

            // Create a ColumnHeader object
            ColumnHeader header_dob = new ColumnHeader();
            // Set its text to be displayed
            header_dob.Text = "Age";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_dob);
            lstView.Columns[1].Width = 200;

            // Create a ColumnHeader object
            ColumnHeader header_like = new ColumnHeader();
            // Set its text to be displayed
            header_dob.Text = "Likes";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_like);
            lstView.Columns[2].Width = 200;
        }

        public void GenerateListViewTwoCol()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 375;


            // Create a ColumnHeader object
            ColumnHeader header_age = new ColumnHeader();
            // Set its text to be displayed
            header_age.Text = "Age";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_age);
            lstView.Columns[1].Width = 375;
        }

        public void GenerateListViewTwoColDob()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 375;


            // Create a ColumnHeader object
            ColumnHeader header_DOB = new ColumnHeader();
            // Set its text to be displayed
            header_DOB.Text = "DOB";
            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_DOB);
            lstView.Columns[1].Width = 375;
        }

        public void GenerateListViewOneCol()
        {
            lstView.Clear();

            // Create a ColumnHeader object
            ColumnHeader header_name = new ColumnHeader();
            // Set its text to be displayed
            header_name.Text = "Name";

            // Add it to the listview through its columns collection
            lstView.Columns.Add(header_name);
            lstView.Columns[0].Width = 650;
        }

        public void ReadFromFile()
        {
            string FilePath = "TooManyDave.dat";
            //  \d+ checks for numbers
            //  \D+ checks for characters
            //  | is OR
            //  So below checks for pattern
            //  (hypen numeric / numeric / numeric OR dot hyphen numeric / numeric)
            string patternFullName = @"-\d+/\d+/\d+\D+ | .-\d+/\d+/\d+\D+"; //Pattern to read Full Name
            string patterDOB = @"(\d+)/(\d+)/(\d+)";
            string patternLikes = @"(?<=\d+\w+)";
            //string excludesBeforeLikes = @"(-) | (-) (\D+)";

            //string[] tempArray = new string[23];
            string tempLIkes = "";
            string tempDOB = "";
            string line = "";
            int counter = 0;

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string[] name = new string[2];
                while ((line = sr.ReadLine()) != null)
                {
                    // Splitting full name by exclude regular expression
                    string[] substringsFullName = Regex.Split(line, patternFullName);
                    foreach (string match in substringsFullName)
                    {
                        if (match != "")
                        {
                            name[counter] = match;
                            if (counter == 1)
                            {
                                counter = 0;
                            }
                            else
                            {
                                counter++;
                            }
                        }
                    }

                    //Splitting dob with include regular expression
                    string[] substringDOB = Regex.Split(line, patterDOB);
                    Match matchDOB = Regex.Match(line, patterDOB);
                    if (matchDOB.Success)
                    {
                        tempDOB = matchDOB.Value;
                    }

                    //Splitting likes with exclude regular expression
                    string[] Likes = Regex.Split(line, patternLikes);
                    foreach (string item in Likes)
                    {
                        if (item != "")
                        {
                            tempLIkes = item;
                        }
                    }

                    //DateTime insertDOB = Convert.ToDateTime(tempDOB);
                    DateTime insertDOB = DateTime.ParseExact(tempDOB, "dd/MM/yyyy", null);

                    tempLIkes = tempLIkes.Replace("-", "");

                    //Adding a person
                    Person newPerson = new Person(name[0], insertDOB, tempLIkes);
                    PersonList.Add(newPerson);
                }
            }

        }

        public static int CalculateAge(DateTime dob)
        {
            //Convert To Unix Time stamp
            DateTime dt = DateTime.Today; //Gets the current date
            DateTime today = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, DateTimeKind.Utc);
            //Coordinated Universal Time
            TimeSpan diff = today - dob.ToUniversalTime(); //Subtracts dob from current date in seconds
            var ts = new TimeSpan(0,0,(int)Math.Floor(diff.TotalSeconds)); //Rounds of the seconds
            int days = ts.Days;
            int years = days / 365;
            return years;
        }

        public double CalculateMccaveMonthlyWelfare()
        {
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Nohing to do here yet
        }

        private void uploadData_btn_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            foreach (Person p in PersonList)
            {
                ListViewItem lvi = new ListViewItem(p.GetName());
                lvi.SubItems.Add(p.GetDOB().ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(p.GetLikes());
                lstView.Items.Add(lvi);
            }
            uploadData_btn.Enabled = false;
        }

        private void listBirthday_btn_Click(object sender, EventArgs e)
        { 
            GenerateListViewTwoColDob();
            foreach (var p in PersonList)
            {
                DateTime temp = new DateTime();
                temp = DateTime.Today;
                DateTime tempD = new DateTime();
                tempD = p.DOB;
                tempD = tempD.AddYears(CalculateAge(p.DOB) + 1);
                if (tempD.Month == temp.Month)
                {
                    if (tempD.Day <= temp.AddDays(7).Day && tempD.Day >= temp.Day)
                    {
                        ListViewItem lvi = new ListViewItem(p.GetName());
                        lvi.SubItems.Add(p.DOB.Day + "/" + p.DOB.Month + "/" + p.DOB.Year);
                        lstView.Items.Add(lvi);
                    }
                }
                else if (tempD.Month == temp.Month+1)
                {
                    temp = temp.AddDays(7);
                    if (tempD <= temp)
                    {
                        ListViewItem lvi = new ListViewItem(p.GetName());
                        lvi.SubItems.Add(p.DOB.Day + "/" + p.DOB.Month + "/" + p.DOB.Year);
                        lstView.Items.Add(lvi);
                    }
                }
            }
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string temp = txtSearch.Text;
            int choice = comboSearchBy.SelectedIndex;
            if (temp == "" && txtSearch.Enabled != false)
            {
                MessageBox.Show("Please enter a search term!");
            }
            else
            {
                GenerateListViewSearch();
                switch (choice)
                {
                    case 0:
                        lblSearchTerm.Text = "Search term: " + temp;
                        foreach (Person p in PersonList)
                        {
                            if (p.SearchByName(temp))
                            {
                                ListViewItem lvi = new ListViewItem(p.GetName());
                                lvi.SubItems.Add(p.GetDOB().ToString());
                                lvi.SubItems.Add(p.GetLikes());
                                lstView.Items.Add(lvi);
                            }
                        }
                        break;
                    case 1:
                        lblSearchTerm.Text = "Search term: " + temp;
                        DateTime dob = Convert.ToDateTime(temp);
                        foreach (Person p in PersonList)
                        {
                            if (p.SearchByDOB(dob))
                            {
                                ListViewItem lvi = new ListViewItem(p.GetName());
                                lvi.SubItems.Add(p.GetDOB().ToString());
                                lvi.SubItems.Add(p.GetLikes());
                                lstView.Items.Add(lvi);
                            }
                        }
                        break;
                    case 2:
                        lblSearchTerm.Text = "Search term: " + temp;
                        foreach (Person p in PersonList)
                        {
                            if (p.SearchByLike(temp))
                            {
                                ListViewItem lvi = new ListViewItem(p.GetName());
                                lvi.SubItems.Add(p.GetDOB().ToString());
                                lvi.SubItems.Add(p.GetLikes());
                                lstView.Items.Add(lvi);
                            }
                        }
                        break;
                    case 3:
                        lblSearchTerm.Text = "Search term: View All";
                        foreach (Person p in PersonList)
                        {
                            ListViewItem lvi = new ListViewItem(p.GetName());
                            lvi.SubItems.Add(p.GetDOB().ToString());
                            lvi.SubItems.Add(p.GetLikes());
                            lstView.Items.Add(lvi);
                        }
                        break;
                    default:
                        break;
                }
            }
            txtSearch.Clear();
        }

        private void listByAge_btn_Click(object sender, EventArgs e)
        {
            GenerateListViewCalulateAge();
            PersonList.Sort(new CompareAge());
            foreach (Person p in PersonList)
            {
                ListViewItem lvi = new ListViewItem(p.GetName());
                lvi.SubItems.Add(CalculateAge(p.GetDOB()).ToString());
                lvi.SubItems.Add(p.DOB.Day + "/" + p.DOB.Month + "/" + p.DOB.Year);
                lstView.Items.Add(lvi);
            }
        }

        private void listByAlpha_btn_Click(object sender, EventArgs e)
        {
            GenerateListViewOneCol();
            PersonList.Sort(new CompareName());
            foreach (Person p in PersonList)
            {
                ListViewItem lvi = new ListViewItem(p.GetName());
                lstView.Items.Add(lvi);
            }
        }

        private void comboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchBy.SelectedIndex == 3)
            {
                txtSearch.ReadOnly = true;
                txtSearch.Enabled = false;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int FindMultipleBirths(Person person)
        {
            int count = 1;
            PersonList.Sort(new CompareAge());
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (PersonList[i].DOB == person.DOB)
                {
                    if (PersonList[i].Equals(person))
                    {
                        ;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void CalcAllowanceMonthly_btn_Click(object sender, EventArgs e)
        {
            int finalAmount = 0;
            GenerateListViewMonthlyAllowance();
            PersonList.Sort(new CompareAge());
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (CalculateAge(PersonList[i].DOB) < 18)
                {
                    int numFam = FindMultipleBirths(PersonList[i]);
                    if (numFam == 1)
                    {
                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add("140");
                        finalAmount += 140;
                        lstView.Items.Add(lvi);
                    }
                    else if (numFam == 2)
                    {
                        ListViewItem lvi1 = new ListViewItem(PersonList[i+1].GetName());
                        lvi1.SubItems.Add(PersonList[i+1].DOB.Day + "/" + PersonList[i+1].DOB.Month + "/" + PersonList[i+1].DOB.Year);
                        lvi1.SubItems.Add("210");
                        finalAmount += 210;
                        lstView.Items.Add(lvi1);

                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add("210");
                        finalAmount += 210;
                        lstView.Items.Add(lvi);
                        i++;
                    }
                    else
                    {
                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add("280");
                        finalAmount += 280;
                        lstView.Items.Add(lvi);
                    }

                }
            }
            ListViewItem finalItem = new ListViewItem("Final Amount:");
            finalItem.SubItems.Add(finalAmount.ToString());
            lstView.Items.Add(finalItem);
        }

        private void planSchoolTime_btn_Click(object sender, EventArgs e)
        {
            GenerateListViewCalulateSchoolTimes();
            int year = 0;
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    if (form2.Year == null)
                    {
                        year = DateTime.Today.Year;
                    }
                    else
                    {
                        year = Convert.ToInt32(form2.Year);
                    }

                }
                else
                {
                    year = DateTime.Today.Year;
                }
            }

            DateTime temp = new DateTime(year, 1,1);
            foreach (Person p in PersonList)
            {
                DateTime tempD = new DateTime();
                if (temp == DateTime.Today)
                {
                    tempD = (p.DOB.AddDays(temp.Day));
                    tempD = (p.DOB.AddMonths(temp.Month));
                    tempD = (p.DOB.AddYears(temp.Year));
                }
                tempD = (p.DOB.AddYears(DateTime.Today.Year - temp.Year));
                ListViewItem lvi = new ListViewItem(p.GetName());
                lvi.SubItems.Add(CalculateAge(tempD).ToString());
                if (CalculateAge(tempD) < 5)
                {
                    lvi.SubItems.Add("Pre-school");
                }
                else if(CalculateAge(tempD) <= 13)
                {
                    lvi.SubItems.Add("Primary School");
                }
                else if (CalculateAge(tempD) <= 19)
                {
                    lvi.SubItems.Add("Secondary School");
                }
                else if (CalculateAge(tempD) <= 23)
                {
                    lvi.SubItems.Add("College");
                }
                else
                {
                    lvi.SubItems.Add("Finished");
                }
                lstView.Items.Add(lvi);
            }


        }

        private void calcAllowanceYear_btn_Click(object sender, EventArgs e)
        {
            int finalAmount = 0;
            GenerateListViewMonthlyAllowance();
            PersonList.Sort(new CompareAge());
            for (int i = 0; i < PersonList.Count; i++)
            {
                if (CalculateAge(PersonList[i].DOB) < 18)
                {
                    int numFam = FindMultipleBirths(PersonList[i]);
                    if (numFam == 1)
                    {
                        DateTime tempP = new DateTime(PersonList[i].DOB.Year, PersonList[i].DOB.Month, PersonList[i].DOB.Day);
                        int tempFinal = 0;
                        for (int y = 0; y < 12; y++)
                        {
                            if (CalculateAge(tempP.AddMonths(DateTime.Today.Month-1)) < 18)
                            {
                                tempFinal += 140;
                                tempP = tempP.AddMonths(-1);
                            }
                        }

                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add(tempFinal.ToString());
                        lstView.Items.Add(lvi);
                        finalAmount += tempFinal;

                    }
                    else if (numFam == 2)
                    {
                        Person tempP1 = new Person();
                        tempP1 = PersonList[i+1];
                        int tempFinal1 = 0;
                        for (int y = 0; y < 12; y++)
                        {
                            if (CalculateAge(tempP1.DOB) < 18)
                            {
                                tempFinal1 += 210;
                                tempP1.DOB.AddMonths(1);
                            }
                        }
                        ListViewItem lvi1 = new ListViewItem(PersonList[i+1].GetName());
                        lvi1.SubItems.Add(PersonList[i+1].DOB.Day + "/" + PersonList[i+1].DOB.Month + "/" + PersonList[i+1].DOB.Year);
                        lvi1.SubItems.Add(tempFinal1.ToString());
                        lstView.Items.Add(lvi1);
                        finalAmount += tempFinal1;

                        Person tempP = new Person();
                        tempP = PersonList[i];
                        int tempFinal = 0;
                        for (int y = 0; y < 12; y++)
                        {
                            if (CalculateAge(tempP.DOB) < 18)
                            {
                                tempFinal += 210;
                                tempP.DOB.AddMonths(1);
                            }
                        }
                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add(tempFinal.ToString());
                        lstView.Items.Add(lvi);
                        finalAmount += tempFinal;


                        i++;
                    }
                    else
                    {
                        Person tempP = new Person();
                        tempP = PersonList[i];
                        int tempFinal = 0;
                        for (int y = 0; y < 12; y++)
                        {
                            if (CalculateAge(tempP.DOB) < 18)
                            {
                                tempFinal += 280;
                                tempP.DOB.AddMonths(1);
                            }
                        }
                        ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                        lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                        lvi.SubItems.Add(tempFinal.ToString());
                        lstView.Items.Add(lvi);
                        finalAmount += tempFinal;

                    }

                }
            }
            ListViewItem finalItem = new ListViewItem("Final Amount:");
            finalItem.SubItems.Add(finalAmount.ToString());
            lstView.Items.Add(finalItem);
        }

        private void listMultiBirths_btn_Click(object sender, EventArgs e)
        {
            GenerateListViewMultipleBirth();
            PersonList.Sort(new CompareAge());
            for (int i = 0; i < PersonList.Count; i++)
            {
                int numFam = FindMultipleBirths(PersonList[i]);
                if (numFam == 2)
                {
                    ListViewItem lvi = new ListViewItem(PersonList[i+1].GetName());
                    lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                    lvi.SubItems.Add("Twin");
                    lstView.Items.Add(lvi);

                    ListViewItem lvi1 = new ListViewItem(PersonList[i].GetName());
                    lvi1.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                    lvi1.SubItems.Add("Twin");
                    lstView.Items.Add(lvi1);
                    i++;
                }
                else if(numFam == 3)
                {
                    ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                    lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                    lvi.SubItems.Add("Triplet");
                    lstView.Items.Add(lvi);
                }
                else if (numFam == 4)
                {
                    ListViewItem lvi = new ListViewItem(PersonList[i].GetName());
                    lvi.SubItems.Add(PersonList[i].DOB.Day + "/" + PersonList[i].DOB.Month + "/" + PersonList[i].DOB.Year);
                    lvi.SubItems.Add("Quadruplet");
                    lstView.Items.Add(lvi);
                }
            }
        }

        private void AddChild_btn_Click(object sender, EventArgs e)
        {
            string fullName = "";
            DateTime childDOB = new DateTime();
            string childLikes = "";
            bool exists = false;

            using (AddNewChild AddNewChildToList = new AddNewChild())
            {
                if (AddNewChildToList.ShowDialog() == DialogResult.OK)
                {
                    fullName = AddNewChildToList.FullName;
                    //childDOB = Convert.ToDateTime(AddNewChildToList.DOB);
                    childDOB = DateTime.Parse(AddNewChildToList.DOB);
                    childLikes = AddNewChildToList.Likes;

                    foreach (Person p in PersonList)
                    {
                        if (p.FullName == fullName && p.DOB == childDOB)
                        {
                            exists = true;
                            MessageBox.Show("Sorry, this person already exists in the database! Try add a different child.");
                        }
                    }

                    if (!exists)
                    {
                        Person temp = new Person(fullName, childDOB, childLikes);
                        PersonList.Add(temp);
                        NewChildren.Add(fullName);

                        string newChild = Environment.NewLine + fullName + "-" + childDOB.ToString("dd/MM/yyyy") + "-" + childLikes;

                        string path = @"TooManyDave.dat";

                        // This text is added only once to the file.
                        if (!File.Exists(path))
                        {
                            MessageBox.Show("Something went wrong");
                        }
                        else
                        {
                            File.AppendAllText(path, newChild);
                        }

                        MessageBox.Show(fullName + ", has been successfully added to the database!");
                    }
                }
                else
                {
                    MessageBox.Show("Nothing was added to the database.");
                }
            }
        }

        private void nameNewBaby_btn_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"RandomBabyNames.dat");

            List<string> names = new List<string>();

            foreach (string line in lines)
            {
                names.Add(line);
            }

            Random rnd = new Random();
            int randNum = rnd.Next(0, 67);

            MessageBox.Show("The baby's name will be " + names[randNum]);
        }


        private void produceGraph_btn_Click(object sender, EventArgs e)
        {
            InfoGraph infoG = new InfoGraph();

            DateTime today = DateTime.Today; //Creates current date

            foreach (var p in PersonList)
            {
                DateTime temp = new DateTime();
                temp = DateTime.Today;
                DateTime tempD = new DateTime();
                tempD = p.DOB;
                tempD = tempD.AddYears(CalculateAge(p.DOB) + 1);
                if (tempD.Month == temp.Month)
                {
                    if (tempD.Day <= temp.AddDays(7).Day && tempD.Day >= temp.Day)
                    {
                        infoG.UpComingBirthdays.Add(p.GetName());
                    }
                }
                else if (tempD.Month == temp.Month + 1)
                {
                    temp = temp.AddDays(7);
                    if (tempD <= temp)
                    {
                        infoG.UpComingBirthdays.Add(p.GetName());
                    }
                }
            }
            TwinPercentage = 0;
            TripletPercentage = 0;
            QuadrupletPercentage = 0;
            SinglePercentage = 0;
            for (int i = 0; i < PersonList.Count; i++)
            {
                int numFam = FindMultipleBirths(PersonList[i]);
                if (numFam == 2)
                {
                    TwinPercentage++;
                }
                else if (numFam == 3)
                {
                    TripletPercentage++;
                }
                else if (numFam == 4)
                {
                    QuadrupletPercentage++;
                }
            }

            infoG.SingPercentage = PersonList.Count - (TwinPercentage + TripletPercentage);
            infoG.TwinPercentage = TwinPercentage;
            infoG.TripletPercentage = TripletPercentage;
            infoG.QuadrupletPercentage = QuadrupletPercentage;

            infoG.NewChildren = NewChildren;

            infoG.ShowDialog();

        }
    }
}
