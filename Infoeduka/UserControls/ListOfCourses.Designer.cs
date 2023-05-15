namespace Infoeduka.UserControls
{
    partial class ListOfCourses
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
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.lvCourses = new System.Windows.Forms.ListView();
            this.lblTitleForCollegeView = new System.Windows.Forms.Label();
            this.pnlCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourses
            // 
            this.pnlCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.pnlCourses.Controls.Add(this.lvCourses);
            this.pnlCourses.Controls.Add(this.lblTitleForCollegeView);
            this.pnlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCourses.Location = new System.Drawing.Point(0, 0);
            this.pnlCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(982, 517);
            this.pnlCourses.TabIndex = 0;
            // 
            // lvCourses
            // 
            this.lvCourses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.lvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvCourses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvCourses.Location = new System.Drawing.Point(62, 69);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(858, 379);
            this.lvCourses.TabIndex = 3;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
            // 
            // lblTitleForCollegeView
            // 
            this.lblTitleForCollegeView.AutoSize = true;
            this.lblTitleForCollegeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleForCollegeView.Location = new System.Drawing.Point(62, 36);
            this.lblTitleForCollegeView.Name = "lblTitleForCollegeView";
            this.lblTitleForCollegeView.Size = new System.Drawing.Size(153, 21);
            this.lblTitleForCollegeView.TabIndex = 2;
            this.lblTitleForCollegeView.Text = "Pregled svih kolegija";
            // 
            // ListOfCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCourses);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListOfCourses";
            this.Size = new System.Drawing.Size(982, 517);
            this.Load += new System.EventHandler(this.ListOfCourses_Load);
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCourses;
        private Label lblTitleForCollegeView;
        private ListView lvCourses;
    }
}
