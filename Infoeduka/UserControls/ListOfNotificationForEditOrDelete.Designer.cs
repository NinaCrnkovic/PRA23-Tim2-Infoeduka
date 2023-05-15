namespace Infoeduka.UserControls
{
    partial class ListOfNotificationForEditOrDelete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvNotifications = new System.Windows.Forms.ListView();
            this.lblTitleForCollegeView = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.lvNotifications);
            this.panel1.Controls.Add(this.lblTitleForCollegeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 517);
            this.panel1.TabIndex = 0;
            // 
            // lvNotifications
            // 
            this.lvNotifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.lvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvNotifications.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvNotifications.Location = new System.Drawing.Point(62, 69);
            this.lvNotifications.Name = "lvNotifications";
            this.lvNotifications.Size = new System.Drawing.Size(858, 379);
            this.lvNotifications.TabIndex = 4;
            this.lvNotifications.UseCompatibleStateImageBehavior = false;
            this.lvNotifications.View = System.Windows.Forms.View.Details;
            // 
            // lblTitleForCollegeView
            // 
            this.lblTitleForCollegeView.AutoSize = true;
            this.lblTitleForCollegeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleForCollegeView.Location = new System.Drawing.Point(62, 24);
            this.lblTitleForCollegeView.Name = "lblTitleForCollegeView";
            this.lblTitleForCollegeView.Size = new System.Drawing.Size(153, 21);
            this.lblTitleForCollegeView.TabIndex = 3;
            this.lblTitleForCollegeView.Text = "Pregled svih kolegija";
            // 
            // ListOfNotificationForEditOrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListOfNotificationForEditOrDelete";
            this.Size = new System.Drawing.Size(982, 517);
            this.Load += new System.EventHandler(this.ListOfNotificationForEditOrDelete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitleForCollegeView;
        private ListView lvNotifications;
    }
}
