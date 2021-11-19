
namespace Student_DB.GUI
{
    partial class form_student
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
            this.textBoxStudentid = new System.Windows.Forms.TextBox();
            this.labelstudentid = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxCours = new System.Windows.Forms.TextBox();
            this.labelcours = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.labelfee = new System.Windows.Forms.Label();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxinputinfo = new System.Windows.Forms.TextBox();
            this.labelinputinfo = new System.Windows.Forms.Label();
            this.labelsearchby = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxStudentid
            // 
            this.textBoxStudentid.Location = new System.Drawing.Point(33, 76);
            this.textBoxStudentid.Name = "textBoxStudentid";
            this.textBoxStudentid.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentid.TabIndex = 0;
            this.textBoxStudentid.TextChanged += new System.EventHandler(this.textBoxStudentid_TextChanged);
            // 
            // labelstudentid
            // 
            this.labelstudentid.AutoSize = true;
            this.labelstudentid.Location = new System.Drawing.Point(42, 56);
            this.labelstudentid.Name = "labelstudentid";
            this.labelstudentid.Size = new System.Drawing.Size(74, 17);
            this.labelstudentid.TabIndex = 1;
            this.labelstudentid.Text = "Student ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(177, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(177, 56);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(100, 17);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "Name Complet";
            // 
            // textBoxCours
            // 
            this.textBoxCours.Location = new System.Drawing.Point(309, 75);
            this.textBoxCours.Name = "textBoxCours";
            this.textBoxCours.Size = new System.Drawing.Size(100, 22);
            this.textBoxCours.TabIndex = 4;
            // 
            // labelcours
            // 
            this.labelcours.AutoSize = true;
            this.labelcours.Location = new System.Drawing.Point(327, 55);
            this.labelcours.Name = "labelcours";
            this.labelcours.Size = new System.Drawing.Size(45, 17);
            this.labelcours.TabIndex = 5;
            this.labelcours.Text = "Cours";
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(452, 75);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(100, 22);
            this.textBoxFee.TabIndex = 6;
            // 
            // labelfee
            // 
            this.labelfee.AutoSize = true;
            this.labelfee.Location = new System.Drawing.Point(472, 52);
            this.labelfee.Name = "labelfee";
            this.labelfee.Size = new System.Drawing.Size(32, 17);
            this.labelfee.TabIndex = 7;
            this.labelfee.Text = "Fee";
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(713, 25);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 8;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(713, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(713, 119);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(75, 23);
            this.buttonList.TabIndex = 10;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(713, 164);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(75, 23);
            this.buttonUPDATE.TabIndex = 11;
            this.buttonUPDATE.Text = "UpDate";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // buttonDelet
            // 
            this.buttonDelet.Location = new System.Drawing.Point(713, 204);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(75, 23);
            this.buttonDelet.TabIndex = 12;
            this.buttonDelet.Text = "Delete";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(391, 151);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(713, 252);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(713, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Search by ID",
            "Search by Name"});
            this.comboBoxSearch.Location = new System.Drawing.Point(33, 148);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearch.TabIndex = 16;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // textBoxinputinfo
            // 
            this.textBoxinputinfo.Location = new System.Drawing.Point(238, 151);
            this.textBoxinputinfo.Name = "textBoxinputinfo";
            this.textBoxinputinfo.Size = new System.Drawing.Size(100, 22);
            this.textBoxinputinfo.TabIndex = 17;
            // 
            // labelinputinfo
            // 
            this.labelinputinfo.AutoSize = true;
            this.labelinputinfo.Location = new System.Drawing.Point(247, 125);
            this.labelinputinfo.Name = "labelinputinfo";
            this.labelinputinfo.Size = new System.Drawing.Size(66, 17);
            this.labelinputinfo.TabIndex = 18;
            this.labelinputinfo.Text = "Input Info";
            // 
            // labelsearchby
            // 
            this.labelsearchby.AutoSize = true;
            this.labelsearchby.Location = new System.Drawing.Point(33, 125);
            this.labelsearchby.Name = "labelsearchby";
            this.labelsearchby.Size = new System.Drawing.Size(73, 17);
            this.labelsearchby.TabIndex = 19;
            this.labelsearchby.Text = "Search By";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 222);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name Complet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cours";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FEE";
            // 
            // form_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelsearchby);
            this.Controls.Add(this.labelinputinfo);
            this.Controls.Add(this.textBoxinputinfo);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelet);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.labelfee);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.labelcours);
            this.Controls.Add(this.textBoxCours);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelstudentid);
            this.Controls.Add(this.textBoxStudentid);
            this.Name = "form_student";
            this.Text = "form_student";
            this.Load += new System.EventHandler(this.form_student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentid;
        private System.Windows.Forms.Label labelstudentid;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxCours;
        private System.Windows.Forms.Label labelcours;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Label labelfee;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxinputinfo;
        private System.Windows.Forms.Label labelinputinfo;
        private System.Windows.Forms.Label labelsearchby;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}