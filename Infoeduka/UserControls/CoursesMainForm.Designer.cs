namespace Infoeduka.UserControls
{
    partial class CoursesMainForm
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
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpLecturersOnCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllLecturers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbEcts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCourse.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourse
            // 
            this.pnlCourse.Controls.Add(this.gbCourse);
            this.pnlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(982, 517);
            this.pnlCourse.TabIndex = 0;
            // 
            // gbCourse
            // 
            this.gbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCourse.Controls.Add(this.label5);
            this.gbCourse.Controls.Add(this.label4);
            this.gbCourse.Controls.Add(this.flpLecturersOnCourse);
            this.gbCourse.Controls.Add(this.flpAllLecturers);
            this.gbCourse.Controls.Add(this.btnSaveCourse);
            this.gbCourse.Controls.Add(this.panel3);
            this.gbCourse.Controls.Add(this.tbEcts);
            this.gbCourse.Controls.Add(this.label2);
            this.gbCourse.Controls.Add(this.panel2);
            this.gbCourse.Controls.Add(this.tbCode);
            this.gbCourse.Controls.Add(this.label1);
            this.gbCourse.Controls.Add(this.panel4);
            this.gbCourse.Controls.Add(this.tbCourseName);
            this.gbCourse.Controls.Add(this.label3);
            this.gbCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCourse.Location = new System.Drawing.Point(86, 14);
            this.gbCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCourse.Size = new System.Drawing.Size(811, 488);
            this.gbCourse.TabIndex = 4;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Kolegij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(506, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Predavači na kolegiju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(172, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Svi predavači";
            // 
            // flpLecturersOnCourse
            // 
            this.flpLecturersOnCourse.AllowDrop = true;
            this.flpLecturersOnCourse.AutoScroll = true;
            this.flpLecturersOnCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLecturersOnCourse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLecturersOnCourse.Location = new System.Drawing.Point(450, 140);
            this.flpLecturersOnCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpLecturersOnCourse.Name = "flpLecturersOnCourse";
            this.flpLecturersOnCourse.Size = new System.Drawing.Size(270, 274);
            this.flpLecturersOnCourse.TabIndex = 21;
            this.flpLecturersOnCourse.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpLecturersOnCourse_DragDrop);
            this.flpLecturersOnCourse.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpLecturersOnCourse_DragEnter);
            // 
            // flpAllLecturers
            // 
            this.flpAllLecturers.AllowDrop = true;
            this.flpAllLecturers.AutoScroll = true;
            this.flpAllLecturers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllLecturers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAllLecturers.Location = new System.Drawing.Point(91, 140);
            this.flpAllLecturers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpAllLecturers.Name = "flpAllLecturers";
            this.flpAllLecturers.Size = new System.Drawing.Size(270, 274);
            this.flpAllLecturers.TabIndex = 20;
            this.flpAllLecturers.WrapContents = false;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            this.btnSaveCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveCourse.FlatAppearance.BorderSize = 0;
            this.btnSaveCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btnSaveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCourse.Location = new System.Drawing.Point(234, 431);
            this.btnSaveCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSaveCourse.Size = new System.Drawing.Size(342, 34);
            this.btnSaveCourse.TabIndex = 19;
            this.btnSaveCourse.Text = "Spremi";
            this.btnSaveCourse.UseVisualStyleBackColor = false;
            this.btnSaveCourse.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(613, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 1);
            this.panel3.TabIndex = 11;
            // 
            // tbEcts
            // 
            this.tbEcts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbEcts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEcts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEcts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbEcts.Location = new System.Drawing.Point(613, 68);
            this.tbEcts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEcts.Name = "tbEcts";
            this.tbEcts.Size = new System.Drawing.Size(106, 22);
            this.tbEcts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(450, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj ECTS bodova";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(215, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 1);
            this.panel2.TabIndex = 8;
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCode.Location = new System.Drawing.Point(215, 63);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(145, 22);
            this.tbCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Šifra kolegija";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(234, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 1);
            this.panel4.TabIndex = 5;
            // 
            // tbCourseName
            // 
            this.tbCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCourseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCourseName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCourseName.Location = new System.Drawing.Point(234, 18);
            this.tbCourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(486, 22);
            this.tbCourseName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv kolegija";
            // 
            // CoursesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlCourse);
            this.Name = "CoursesMainForm";
            this.Size = new System.Drawing.Size(982, 517);
            this.Load += new System.EventHandler(this.CoursesMainForm_Load);
            this.pnlCourse.ResumeLayout(false);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCourse;
        private GroupBox gbCourse;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flpLecturersOnCourse;
        private FlowLayoutPanel flpAllLecturers;
        private Button btnSaveCourse;
        private Panel panel3;
        private TextBox tbEcts;
        private Label label2;
        private Panel panel2;
        private TextBox tbCode;
        private Label label1;
        private Panel panel4;
        private TextBox tbCourseName;
        private Label label3;
    }
}
