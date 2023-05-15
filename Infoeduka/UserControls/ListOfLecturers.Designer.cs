namespace Infoeduka.UserControls
{
    partial class ListOfLecturers
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblTitleForListOfLecturers = new System.Windows.Forms.Label();
            this.lvLecturers = new System.Windows.Forms.ListView();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.pnlList.Controls.Add(this.lblTitleForListOfLecturers);
            this.pnlList.Controls.Add(this.lvLecturers);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(982, 517);
            this.pnlList.TabIndex = 2;
            // 
            // lblTitleForListOfLecturers
            // 
            this.lblTitleForListOfLecturers.AutoSize = true;
            this.lblTitleForListOfLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleForListOfLecturers.Location = new System.Drawing.Point(62, 27);
            this.lblTitleForListOfLecturers.Name = "lblTitleForListOfLecturers";
            this.lblTitleForListOfLecturers.Size = new System.Drawing.Size(170, 21);
            this.lblTitleForListOfLecturers.TabIndex = 1;
            this.lblTitleForListOfLecturers.Text = "Pregled svih predavača";
            // 
            // lvLecturers
            // 
            this.lvLecturers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.lvLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvLecturers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvLecturers.Location = new System.Drawing.Point(62, 70);
            this.lvLecturers.Name = "lvLecturers";
            this.lvLecturers.Size = new System.Drawing.Size(858, 379);
            this.lvLecturers.TabIndex = 0;
            this.lvLecturers.UseCompatibleStateImageBehavior = false;
            this.lvLecturers.View = System.Windows.Forms.View.Details;
            // 
            // ListOfLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Name = "ListOfLecturers";
            this.Size = new System.Drawing.Size(982, 517);
            this.Load += new System.EventHandler(this.ListOfLecturers_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlList;
        private ListView lvLecturers;
        private Label lblTitleForListOfLecturers;
    }
}
