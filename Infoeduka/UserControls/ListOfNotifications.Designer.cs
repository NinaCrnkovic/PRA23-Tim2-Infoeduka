namespace Infoeduka.UserControls
{
    partial class ListOfNotifications
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
            this.btnForListOfNotification = new System.Windows.Forms.Button();
            this.flpHolderForNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnForListOfNotification
            // 
            this.btnForListOfNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.btnForListOfNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForListOfNotification.FlatAppearance.BorderSize = 0;
            this.btnForListOfNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForListOfNotification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForListOfNotification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnForListOfNotification.Location = new System.Drawing.Point(0, 0);
            this.btnForListOfNotification.Name = "btnForListOfNotification";
            this.btnForListOfNotification.Size = new System.Drawing.Size(981, 34);
            this.btnForListOfNotification.TabIndex = 2;
            this.btnForListOfNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForListOfNotification.UseVisualStyleBackColor = false;
            // 
            // flpHolderForNotifications
            // 
            this.flpHolderForNotifications.AutoScroll = true;
            this.flpHolderForNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.flpHolderForNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHolderForNotifications.Location = new System.Drawing.Point(0, 34);
            this.flpHolderForNotifications.Name = "flpHolderForNotifications";
            this.flpHolderForNotifications.Size = new System.Drawing.Size(981, 487);
            this.flpHolderForNotifications.TabIndex = 3;
            // 
            // ListOfNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpHolderForNotifications);
            this.Controls.Add(this.btnForListOfNotification);
            this.Name = "ListOfNotifications";
            this.Size = new System.Drawing.Size(981, 521);
            this.Load += new System.EventHandler(this.ListOfNotifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnForListOfNotification;
        private FlowLayoutPanel flpHolderForNotifications;
    }
}
