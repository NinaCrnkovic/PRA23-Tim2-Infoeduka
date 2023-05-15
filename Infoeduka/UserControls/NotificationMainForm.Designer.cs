namespace Infoeduka.UserControls
{
    partial class NotificationMainForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbCourses = new Infoeduka.CustomDesign.CustomComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNotifications.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Controls.Add(this.gbCourse);
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotifications.Location = new System.Drawing.Point(0, 0);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(1122, 689);
            this.pnlNotifications.TabIndex = 0;
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.tbDescription);
            this.gbCourse.Controls.Add(this.label4);
            this.gbCourse.Controls.Add(this.ccbCourses);
            this.gbCourse.Controls.Add(this.dtDate);
            this.gbCourse.Controls.Add(this.btnSave);
            this.gbCourse.Controls.Add(this.label2);
            this.gbCourse.Controls.Add(this.label1);
            this.gbCourse.Controls.Add(this.panel3);
            this.gbCourse.Controls.Add(this.tbName);
            this.gbCourse.Controls.Add(this.label3);
            this.gbCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCourse.Location = new System.Drawing.Point(86, 19);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(951, 651);
            this.gbCourse.TabIndex = 5;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Obavijest";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.Location = new System.Drawing.Point(194, 119);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(701, 173);
            this.tbDescription.TabIndex = 24;
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescription_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(136, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Opis";
            // 
            // ccbCourses
            // 
            this.ccbCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ccbCourses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ccbCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCourses.ForeColor = System.Drawing.Color.White;
            this.ccbCourses.FormattingEnabled = true;
            this.ccbCourses.Location = new System.Drawing.Point(194, 343);
            this.ccbCourses.MaxDropDownItems = 4;
            this.ccbCourses.Name = "ccbCourses";
            this.ccbCourses.Size = new System.Drawing.Size(308, 35);
            this.ccbCourses.TabIndex = 22;
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.dtDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtDate.Location = new System.Drawing.Point(675, 344);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(220, 34);
            this.dtDate.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(267, 575);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(391, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(53, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv kolegija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(532, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum isteka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(194, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 1);
            this.panel3.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.Location = new System.Drawing.Point(194, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(702, 27);
            this.tbName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv obavijesti";
            // 
            // NotificationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlNotifications);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NotificationMainForm";
            this.Size = new System.Drawing.Size(1122, 689);
            this.Load += new System.EventHandler(this.NotificationMainForm_Load);
            this.pnlNotifications.ResumeLayout(false);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlNotifications;
        private GroupBox gbCourse;
        private TextBox tbDescription;
        private Label label4;
        private CustomDesign.CustomComboBox ccbCourses;
        private DateTimePicker dtDate;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TextBox tbName;
        private Label label3;
    }
}
