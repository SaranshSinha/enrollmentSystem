namespace CourseWork
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbEnrolmentStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dTPRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblProgramEnrol = new System.Windows.Forms.Label();
            this.cmbProgramEnrol = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelReport = new System.Windows.Forms.Panel();
            this.ProgramEnrolChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerateWeeklyReport = new System.Windows.Forms.Button();
            this.dataGridViewWeeklyReport = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnrolmentForm = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEnrolmentReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSortNameAsc = new System.Windows.Forms.Button();
            this.btnSortNameDesc = new System.Windows.Forms.Button();
            this.btnSortDateAsc = new System.Windows.Forms.Button();
            this.btnSortDateDesc = new System.Windows.Forms.Button();
            this.panelStudent.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramEnrolChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(530, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(198, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(318, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 60);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(198, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(530, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // dTPBirthDate
            // 
            this.dTPBirthDate.Location = new System.Drawing.Point(131, 143);
            this.dTPBirthDate.Name = "dTPBirthDate";
            this.dTPBirthDate.Size = new System.Drawing.Size(198, 20);
            this.dTPBirthDate.TabIndex = 10;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(530, 144);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(197, 20);
            this.txtContactNo.TabIndex = 12;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.btnAddNewStudent);
            this.panelStudent.Controls.Add(this.label14);
            this.panelStudent.Controls.Add(this.cmbEnrolmentStatus);
            this.panelStudent.Controls.Add(this.label11);
            this.panelStudent.Controls.Add(this.label10);
            this.panelStudent.Controls.Add(this.label9);
            this.panelStudent.Controls.Add(this.btnUpdate);
            this.panelStudent.Controls.Add(this.label8);
            this.panelStudent.Controls.Add(this.label7);
            this.panelStudent.Controls.Add(this.label1);
            this.panelStudent.Controls.Add(this.txtLastName);
            this.panelStudent.Controls.Add(this.txtEmail);
            this.panelStudent.Controls.Add(this.txtContactNo);
            this.panelStudent.Controls.Add(this.dTPBirthDate);
            this.panelStudent.Controls.Add(this.txtFirstName);
            this.panelStudent.Controls.Add(this.txtAddress);
            this.panelStudent.Controls.Add(this.dTPRegistrationDate);
            this.panelStudent.Controls.Add(this.lblProgramEnrol);
            this.panelStudent.Controls.Add(this.cmbProgramEnrol);
            this.panelStudent.Controls.Add(this.cmbGender);
            this.panelStudent.Controls.Add(this.btnClear);
            this.panelStudent.Controls.Add(this.btnSubmit);
            this.panelStudent.Controls.Add(this.txtId);
            this.panelStudent.Controls.Add(this.label13);
            this.panelStudent.Controls.Add(this.label12);
            this.panelStudent.Location = new System.Drawing.Point(244, 85);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(748, 371);
            this.panelStudent.TabIndex = 15;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudent.Location = new System.Drawing.Point(529, 301);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(158, 60);
            this.btnAddNewStudent.TabIndex = 29;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(374, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Enrolment Status";
            // 
            // cmbEnrolmentStatus
            // 
            this.cmbEnrolmentStatus.FormattingEnabled = true;
            this.cmbEnrolmentStatus.Items.AddRange(new object[] {
            "Processing",
            "Completed"});
            this.cmbEnrolmentStatus.Location = new System.Drawing.Point(529, 248);
            this.cmbEnrolmentStatus.Name = "cmbEnrolmentStatus";
            this.cmbEnrolmentStatus.Size = new System.Drawing.Size(198, 21);
            this.cmbEnrolmentStatus.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(374, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Email ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Address";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(333, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 60);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Birth Date";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(198, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // dTPRegistrationDate
            // 
            this.dTPRegistrationDate.Location = new System.Drawing.Point(530, 197);
            this.dTPRegistrationDate.Name = "dTPRegistrationDate";
            this.dTPRegistrationDate.Size = new System.Drawing.Size(198, 20);
            this.dTPRegistrationDate.TabIndex = 17;
            // 
            // lblProgramEnrol
            // 
            this.lblProgramEnrol.AutoSize = true;
            this.lblProgramEnrol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramEnrol.Location = new System.Drawing.Point(4, 250);
            this.lblProgramEnrol.Name = "lblProgramEnrol";
            this.lblProgramEnrol.Size = new System.Drawing.Size(108, 19);
            this.lblProgramEnrol.TabIndex = 17;
            this.lblProgramEnrol.Text = "Program Enrol";
            // 
            // cmbProgramEnrol
            // 
            this.cmbProgramEnrol.FormattingEnabled = true;
            this.cmbProgramEnrol.Items.AddRange(new object[] {
            "Computing",
            "Networking ",
            "Multimedia"});
            this.cmbProgramEnrol.Location = new System.Drawing.Point(131, 250);
            this.cmbProgramEnrol.Name = "cmbProgramEnrol";
            this.cmbProgramEnrol.Size = new System.Drawing.Size(198, 21);
            this.cmbProgramEnrol.TabIndex = 11;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(131, 198);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(198, 21);
            this.cmbGender.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(113, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 60);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(131, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(374, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Registration Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(374, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Contact Number";
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.ProgramEnrolChart);
            this.panelReport.Controls.Add(this.label17);
            this.panelReport.Controls.Add(this.label16);
            this.panelReport.Controls.Add(this.btnGenerateWeeklyReport);
            this.panelReport.Controls.Add(this.dataGridViewWeeklyReport);
            this.panelReport.Controls.Add(this.label15);
            this.panelReport.Controls.Add(this.dtpReportDate);
            this.panelReport.Location = new System.Drawing.Point(221, 66);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(807, 422);
            this.panelReport.TabIndex = 20;
            // 
            // ProgramEnrolChart
            // 
            chartArea4.Name = "ChartArea1";
            this.ProgramEnrolChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ProgramEnrolChart.Legends.Add(legend4);
            this.ProgramEnrolChart.Location = new System.Drawing.Point(462, 107);
            this.ProgramEnrolChart.Name = "ProgramEnrolChart";
            series4.ChartArea = "ChartArea1";
            series4.LabelBackColor = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "No of Student";
            this.ProgramEnrolChart.Series.Add(series4);
            this.ProgramEnrolChart.Size = new System.Drawing.Size(339, 281);
            this.ProgramEnrolChart.TabIndex = 24;
            this.ProgramEnrolChart.Text = "ProgramEnrolChart";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(19, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(241, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "Weekly Enrolment Report";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(457, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Enrolment Report";
            // 
            // btnGenerateWeeklyReport
            // 
            this.btnGenerateWeeklyReport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateWeeklyReport.Location = new System.Drawing.Point(126, 176);
            this.btnGenerateWeeklyReport.Name = "btnGenerateWeeklyReport";
            this.btnGenerateWeeklyReport.Size = new System.Drawing.Size(192, 59);
            this.btnGenerateWeeklyReport.TabIndex = 21;
            this.btnGenerateWeeklyReport.Text = "Generate Weekly Report";
            this.btnGenerateWeeklyReport.UseVisualStyleBackColor = true;
            this.btnGenerateWeeklyReport.Click += new System.EventHandler(this.btnGenerateWeeklyReport_Click);
            // 
            // dataGridViewWeeklyReport
            // 
            this.dataGridViewWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklyReport.Location = new System.Drawing.Point(39, 275);
            this.dataGridViewWeeklyReport.Name = "dataGridViewWeeklyReport";
            this.dataGridViewWeeklyReport.Size = new System.Drawing.Size(281, 108);
            this.dataGridViewWeeklyReport.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 19;
            this.label15.Text = "Select Date";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Location = new System.Drawing.Point(118, 131);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReportDate.TabIndex = 18;
            // 
            // btnEnrolmentForm
            // 
            this.btnEnrolmentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnrolmentForm.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolmentForm.Location = new System.Drawing.Point(11, 210);
            this.btnEnrolmentForm.Name = "btnEnrolmentForm";
            this.btnEnrolmentForm.Size = new System.Drawing.Size(201, 49);
            this.btnEnrolmentForm.TabIndex = 21;
            this.btnEnrolmentForm.Text = "Enrolment Form";
            this.btnEnrolmentForm.UseVisualStyleBackColor = false;
            this.btnEnrolmentForm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridStudents.Location = new System.Drawing.Point(215, 509);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.ReadOnly = true;
            this.dataGridStudents.Size = new System.Drawing.Size(830, 142);
            this.dataGridStudents.TabIndex = 7;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStudents_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnEnrolmentReport
            // 
            this.btnEnrolmentReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnrolmentReport.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolmentReport.Location = new System.Drawing.Point(11, 279);
            this.btnEnrolmentReport.Name = "btnEnrolmentReport";
            this.btnEnrolmentReport.Size = new System.Drawing.Size(201, 44);
            this.btnEnrolmentReport.TabIndex = 20;
            this.btnEnrolmentReport.Text = "Enrolment Report";
            this.btnEnrolmentReport.UseVisualStyleBackColor = false;
            this.btnEnrolmentReport.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(264, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(627, 65);
            this.label6.TabIndex = 21;
            this.label6.Text = "Student Enrolment System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(179, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(396, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deeya Shrestha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(210, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Application Development Coursework";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(88, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 65);
            this.label5.TabIndex = 22;
            this.label5.Text = "Student Enrolment System";
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.Red;
            this.panelWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelWelcome.Controls.Add(this.label5);
            this.panelWelcome.Controls.Add(this.pictureBox4);
            this.panelWelcome.Controls.Add(this.label4);
            this.panelWelcome.Controls.Add(this.label3);
            this.panelWelcome.Controls.Add(this.label2);
            this.panelWelcome.Controls.Add(this.pictureBox3);
            this.panelWelcome.ForeColor = System.Drawing.Color.Red;
            this.panelWelcome.Location = new System.Drawing.Point(-3, 1);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1056, 650);
            this.panelWelcome.TabIndex = 21;
      
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CourseWork.Properties.Resources.nextArrow;
            this.pictureBox4.Location = new System.Drawing.Point(898, 514);
            this.pictureBox4.Name = "pictureBox4";
             this.pictureBox4.Size = new System.Drawing.Size(89, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ArrowPictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CourseWork.Properties.Resources.SchoolManagementLogo;
            this.pictureBox3.Location = new System.Drawing.Point(129, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(478, 408);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.SchoolManagementLogo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnEnrolmentReport);
            this.panelSidebar.Controls.Add(this.btnEnrolmentForm);
            this.panelSidebar.Controls.Add(this.btnSortNameAsc);
            this.panelSidebar.Controls.Add(this.btnSortNameDesc);
            this.panelSidebar.Controls.Add(this.btnSortDateAsc);
            this.panelSidebar.Controls.Add(this.btnSortDateDesc);
            this.panelSidebar.Location = new System.Drawing.Point(-6, -2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(215, 653);
            this.panelSidebar.TabIndex = 22;
            // 
            // btnSortNameAsc
            // 
            this.btnSortNameAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSortNameAsc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNameAsc.Location = new System.Drawing.Point(11, 344);
            this.btnSortNameAsc.Name = "btnSortNameAsc";
            this.btnSortNameAsc.Size = new System.Drawing.Size(201, 58);
            this.btnSortNameAsc.TabIndex = 23;
            this.btnSortNameAsc.Text = "Sort Name Ascending";
            this.btnSortNameAsc.UseVisualStyleBackColor = false;
            this.btnSortNameAsc.Click += new System.EventHandler(this.btnSortNameAsc_Click);
            // 
            // btnSortNameDesc
            // 
            this.btnSortNameDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSortNameDesc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortNameDesc.Location = new System.Drawing.Point(12, 424);
            this.btnSortNameDesc.Name = "btnSortNameDesc";
            this.btnSortNameDesc.Size = new System.Drawing.Size(201, 60);
            this.btnSortNameDesc.TabIndex = 25;
            this.btnSortNameDesc.Text = "Sort Name Descending";
            this.btnSortNameDesc.UseVisualStyleBackColor = false;
            this.btnSortNameDesc.Click += new System.EventHandler(this.btnSortNameDesc_Click);
            // 
            // btnSortDateAsc
            // 
            this.btnSortDateAsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSortDateAsc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDateAsc.Location = new System.Drawing.Point(11, 500);
            this.btnSortDateAsc.Name = "btnSortDateAsc";
            this.btnSortDateAsc.Size = new System.Drawing.Size(201, 58);
            this.btnSortDateAsc.TabIndex = 22;
            this.btnSortDateAsc.Text = "Sort Date Ascending";
            this.btnSortDateAsc.UseVisualStyleBackColor = false;
            this.btnSortDateAsc.Click += new System.EventHandler(this.btnSortDateAsc_Click);
            // 
            // btnSortDateDesc
            // 
            this.btnSortDateDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSortDateDesc.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDateDesc.Location = new System.Drawing.Point(11, 580);
            this.btnSortDateDesc.Name = "btnSortDateDesc";
            this.btnSortDateDesc.Size = new System.Drawing.Size(201, 64);
            this.btnSortDateDesc.TabIndex = 24;
            this.btnSortDateDesc.Text = "Sort Date Descending";
            this.btnSortDateDesc.UseVisualStyleBackColor = false;
            this.btnSortDateDesc.Click += new System.EventHandler(this.btnSortDateDesc_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.panelStudent);
            this.Name = "StudentForm";
            this.Text = "Student Enrolment System";
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramEnrolChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dTPBirthDate;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblProgramEnrol;
        private System.Windows.Forms.ComboBox cmbProgramEnrol;
        private System.Windows.Forms.DateTimePicker dTPRegistrationDate;
        private System.Windows.Forms.Button btnEnrolmentReport;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnEnrolmentForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.DataGridView dataGridViewWeeklyReport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Button btnGenerateWeeklyReport;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgramEnrolChart;
        private System.Windows.Forms.Button btnSortNameDesc;
        private System.Windows.Forms.Button btnSortDateDesc;
        private System.Windows.Forms.Button btnSortNameAsc;
        private System.Windows.Forms.Button btnSortDateAsc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEnrolmentStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnAddNewStudent;
    }
}

