namespace TooManyDaves
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadData_btn = new System.Windows.Forms.Button();
            this.listBirthday_btn = new System.Windows.Forms.Button();
            this.listByAge_btn = new System.Windows.Forms.Button();
            this.listByAlpha_btn = new System.Windows.Forms.Button();
            this.listMultiBirths_btn = new System.Windows.Forms.Button();
            this.AddChild_btn = new System.Windows.Forms.Button();
            this.nameNewBaby_btn = new System.Windows.Forms.Button();
            this.CalcAllowanceMonthly_btn = new System.Windows.Forms.Button();
            this.calcAllowanceYear_btn = new System.Windows.Forms.Button();
            this.planSchoolTime_btn = new System.Windows.Forms.Button();
            this.produceGraph_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstView = new System.Windows.Forms.ListView();
            this.colHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderLikes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadData_btn
            // 
            this.uploadData_btn.BackColor = System.Drawing.Color.White;
            this.uploadData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadData_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.uploadData_btn.Location = new System.Drawing.Point(13, 16);
            this.uploadData_btn.Margin = new System.Windows.Forms.Padding(4);
            this.uploadData_btn.Name = "uploadData_btn";
            this.uploadData_btn.Size = new System.Drawing.Size(165, 41);
            this.uploadData_btn.TabIndex = 0;
            this.uploadData_btn.Text = "Upload Data";
            this.uploadData_btn.UseVisualStyleBackColor = false;
            this.uploadData_btn.Click += new System.EventHandler(this.uploadData_btn_Click);
            // 
            // listBirthday_btn
            // 
            this.listBirthday_btn.BackColor = System.Drawing.Color.White;
            this.listBirthday_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listBirthday_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBirthday_btn.Location = new System.Drawing.Point(13, 62);
            this.listBirthday_btn.Margin = new System.Windows.Forms.Padding(4);
            this.listBirthday_btn.Name = "listBirthday_btn";
            this.listBirthday_btn.Size = new System.Drawing.Size(165, 41);
            this.listBirthday_btn.TabIndex = 1;
            this.listBirthday_btn.Text = "Display Birthdays in the next 7 Days";
            this.listBirthday_btn.UseVisualStyleBackColor = false;
            this.listBirthday_btn.Click += new System.EventHandler(this.listBirthday_btn_Click);
            // 
            // listByAge_btn
            // 
            this.listByAge_btn.BackColor = System.Drawing.Color.White;
            this.listByAge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listByAge_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listByAge_btn.Location = new System.Drawing.Point(13, 108);
            this.listByAge_btn.Margin = new System.Windows.Forms.Padding(4);
            this.listByAge_btn.Name = "listByAge_btn";
            this.listByAge_btn.Size = new System.Drawing.Size(165, 41);
            this.listByAge_btn.TabIndex = 2;
            this.listByAge_btn.Text = "List By Age";
            this.listByAge_btn.UseVisualStyleBackColor = false;
            this.listByAge_btn.Click += new System.EventHandler(this.listByAge_btn_Click);
            // 
            // listByAlpha_btn
            // 
            this.listByAlpha_btn.BackColor = System.Drawing.Color.White;
            this.listByAlpha_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listByAlpha_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listByAlpha_btn.Location = new System.Drawing.Point(13, 155);
            this.listByAlpha_btn.Margin = new System.Windows.Forms.Padding(4);
            this.listByAlpha_btn.Name = "listByAlpha_btn";
            this.listByAlpha_btn.Size = new System.Drawing.Size(165, 41);
            this.listByAlpha_btn.TabIndex = 3;
            this.listByAlpha_btn.Text = "List By Alphaberical Order";
            this.listByAlpha_btn.UseVisualStyleBackColor = false;
            this.listByAlpha_btn.Click += new System.EventHandler(this.listByAlpha_btn_Click);
            // 
            // listMultiBirths_btn
            // 
            this.listMultiBirths_btn.BackColor = System.Drawing.Color.White;
            this.listMultiBirths_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listMultiBirths_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listMultiBirths_btn.Location = new System.Drawing.Point(13, 201);
            this.listMultiBirths_btn.Margin = new System.Windows.Forms.Padding(4);
            this.listMultiBirths_btn.Name = "listMultiBirths_btn";
            this.listMultiBirths_btn.Size = new System.Drawing.Size(165, 41);
            this.listMultiBirths_btn.TabIndex = 4;
            this.listMultiBirths_btn.Text = "List Multiple Birth\'s";
            this.listMultiBirths_btn.UseVisualStyleBackColor = false;
            this.listMultiBirths_btn.Click += new System.EventHandler(this.listMultiBirths_btn_Click);
            // 
            // AddChild_btn
            // 
            this.AddChild_btn.BackColor = System.Drawing.Color.White;
            this.AddChild_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChild_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddChild_btn.Location = new System.Drawing.Point(13, 247);
            this.AddChild_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddChild_btn.Name = "AddChild_btn";
            this.AddChild_btn.Size = new System.Drawing.Size(165, 41);
            this.AddChild_btn.TabIndex = 5;
            this.AddChild_btn.Text = "Add New Child";
            this.AddChild_btn.UseVisualStyleBackColor = false;
            this.AddChild_btn.Click += new System.EventHandler(this.AddChild_btn_Click);
            // 
            // nameNewBaby_btn
            // 
            this.nameNewBaby_btn.BackColor = System.Drawing.Color.White;
            this.nameNewBaby_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameNewBaby_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameNewBaby_btn.Location = new System.Drawing.Point(13, 296);
            this.nameNewBaby_btn.Margin = new System.Windows.Forms.Padding(4);
            this.nameNewBaby_btn.Name = "nameNewBaby_btn";
            this.nameNewBaby_btn.Size = new System.Drawing.Size(165, 41);
            this.nameNewBaby_btn.TabIndex = 6;
            this.nameNewBaby_btn.Text = "Name Next Baby";
            this.nameNewBaby_btn.UseVisualStyleBackColor = false;
            this.nameNewBaby_btn.Click += new System.EventHandler(this.nameNewBaby_btn_Click);
            // 
            // CalcAllowanceMonthly_btn
            // 
            this.CalcAllowanceMonthly_btn.BackColor = System.Drawing.Color.White;
            this.CalcAllowanceMonthly_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcAllowanceMonthly_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CalcAllowanceMonthly_btn.Location = new System.Drawing.Point(13, 342);
            this.CalcAllowanceMonthly_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CalcAllowanceMonthly_btn.Name = "CalcAllowanceMonthly_btn";
            this.CalcAllowanceMonthly_btn.Size = new System.Drawing.Size(165, 41);
            this.CalcAllowanceMonthly_btn.TabIndex = 7;
            this.CalcAllowanceMonthly_btn.Text = "Calculate Childrens Allowance(Monthly)";
            this.CalcAllowanceMonthly_btn.UseVisualStyleBackColor = false;
            this.CalcAllowanceMonthly_btn.Click += new System.EventHandler(this.CalcAllowanceMonthly_btn_Click);
            // 
            // calcAllowanceYear_btn
            // 
            this.calcAllowanceYear_btn.BackColor = System.Drawing.Color.White;
            this.calcAllowanceYear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcAllowanceYear_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.calcAllowanceYear_btn.Location = new System.Drawing.Point(13, 388);
            this.calcAllowanceYear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.calcAllowanceYear_btn.Name = "calcAllowanceYear_btn";
            this.calcAllowanceYear_btn.Size = new System.Drawing.Size(165, 41);
            this.calcAllowanceYear_btn.TabIndex = 8;
            this.calcAllowanceYear_btn.Text = "Calculate childrens Allowance(Yearly)";
            this.calcAllowanceYear_btn.UseVisualStyleBackColor = false;
            this.calcAllowanceYear_btn.Click += new System.EventHandler(this.calcAllowanceYear_btn_Click);
            // 
            // planSchoolTime_btn
            // 
            this.planSchoolTime_btn.BackColor = System.Drawing.Color.White;
            this.planSchoolTime_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planSchoolTime_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.planSchoolTime_btn.Location = new System.Drawing.Point(13, 435);
            this.planSchoolTime_btn.Margin = new System.Windows.Forms.Padding(4);
            this.planSchoolTime_btn.Name = "planSchoolTime_btn";
            this.planSchoolTime_btn.Size = new System.Drawing.Size(165, 41);
            this.planSchoolTime_btn.TabIndex = 9;
            this.planSchoolTime_btn.Text = "Plan School Times";
            this.planSchoolTime_btn.UseVisualStyleBackColor = false;
            this.planSchoolTime_btn.Click += new System.EventHandler(this.planSchoolTime_btn_Click);
            // 
            // produceGraph_btn
            // 
            this.produceGraph_btn.BackColor = System.Drawing.Color.White;
            this.produceGraph_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produceGraph_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.produceGraph_btn.Location = new System.Drawing.Point(13, 481);
            this.produceGraph_btn.Margin = new System.Windows.Forms.Padding(4);
            this.produceGraph_btn.Name = "produceGraph_btn";
            this.produceGraph_btn.Size = new System.Drawing.Size(165, 41);
            this.produceGraph_btn.TabIndex = 10;
            this.produceGraph_btn.Text = "Produce dynamic infograph";
            this.produceGraph_btn.UseVisualStyleBackColor = false;
            this.produceGraph_btn.Click += new System.EventHandler(this.produceGraph_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exit_btn.Location = new System.Drawing.Point(13, 528);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(165, 41);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uploadData_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.listBirthday_btn);
            this.panel1.Controls.Add(this.produceGraph_btn);
            this.panel1.Controls.Add(this.listByAge_btn);
            this.panel1.Controls.Add(this.planSchoolTime_btn);
            this.panel1.Controls.Add(this.listByAlpha_btn);
            this.panel1.Controls.Add(this.calcAllowanceYear_btn);
            this.panel1.Controls.Add(this.listMultiBirths_btn);
            this.panel1.Controls.Add(this.CalcAllowanceMonthly_btn);
            this.panel1.Controls.Add(this.AddChild_btn);
            this.panel1.Controls.Add(this.nameNewBaby_btn);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 589);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(324, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome to Too Many Daves";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstView);
            this.panel2.Location = new System.Drawing.Point(225, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 589);
            this.panel2.TabIndex = 14;
            // 
            // lstView
            // 
            this.lstView.BackColor = System.Drawing.Color.White;
            this.lstView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderName,
            this.colHeaderDOB,
            this.colHeaderLikes});
            this.lstView.Location = new System.Drawing.Point(13, 16);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(650, 553);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderName
            // 
            this.colHeaderName.Text = "Name";
            this.colHeaderName.Width = 200;
            // 
            // colHeaderDOB
            // 
            this.colHeaderDOB.Text = "DOB";
            this.colHeaderDOB.Width = 200;
            // 
            // colHeaderLikes
            // 
            this.colHeaderLikes.Text = "Likes";
            this.colHeaderLikes.Width = 200;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboSearchBy
            // 
            this.comboSearchBy.FormattingEnabled = true;
            this.comboSearchBy.Items.AddRange(new object[] {
            "Search by name",
            "Search by DOB",
            "Search by like",
            "View All"});
            this.comboSearchBy.Location = new System.Drawing.Point(12, 53);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.Size = new System.Drawing.Size(194, 21);
            this.comboSearchBy.TabIndex = 17;
            this.comboSearchBy.Text = "Search by name";
            this.comboSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboSearchBy_SelectedIndexChanged);
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(225, 95);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(0, 13);
            this.lblSearchTerm.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(917, 741);
            this.Controls.Add(this.lblSearchTerm);
            this.Controls.Add(this.comboSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Too Many Daves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadData_btn;
        private System.Windows.Forms.Button listBirthday_btn;
        private System.Windows.Forms.Button listByAge_btn;
        private System.Windows.Forms.Button listByAlpha_btn;
        private System.Windows.Forms.Button listMultiBirths_btn;
        private System.Windows.Forms.Button AddChild_btn;
        private System.Windows.Forms.Button CalcAllowanceMonthly_btn;
        private System.Windows.Forms.Button calcAllowanceYear_btn;
        private System.Windows.Forms.Button produceGraph_btn;
        private System.Windows.Forms.Button nameNewBaby_btn;
        private System.Windows.Forms.Button planSchoolTime_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader colHeaderName;
        private System.Windows.Forms.ColumnHeader colHeaderDOB;
        private System.Windows.Forms.ColumnHeader colHeaderLikes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboSearchBy;
        private System.Windows.Forms.Label lblSearchTerm;
    }
}

