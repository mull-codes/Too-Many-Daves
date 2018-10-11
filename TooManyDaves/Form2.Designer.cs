namespace TooManyDaves
{
    partial class Form2
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
            this.sbmt_btn = new System.Windows.Forms.Button();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sbmt_btn
            // 
            this.sbmt_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbmt_btn.Location = new System.Drawing.Point(24, 67);
            this.sbmt_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sbmt_btn.Name = "sbmt_btn";
            this.sbmt_btn.Size = new System.Drawing.Size(181, 32);
            this.sbmt_btn.TabIndex = 0;
            this.sbmt_btn.Text = "Plan School";
            this.sbmt_btn.UseVisualStyleBackColor = true;
            this.sbmt_btn.Click += new System.EventHandler(this.sbmt_btn_Click);
            // 
            // year_txt
            // 
            this.year_txt.AcceptsTab = true;
            this.year_txt.Location = new System.Drawing.Point(24, 37);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(181, 20);
            this.year_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Year ( yyyy )";
            // 
            // Form2
            // 
            this.AcceptButton = this.sbmt_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.sbmt_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "School Planner";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sbmt_btn;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.Label label1;
    }
}