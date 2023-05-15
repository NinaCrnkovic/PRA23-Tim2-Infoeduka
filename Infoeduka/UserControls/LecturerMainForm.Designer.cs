namespace Infoeduka.UserControls
{
    partial class LecturerMainForm
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
            this.pnlLecturer = new System.Windows.Forms.Panel();
            this.gbLecturer = new System.Windows.Forms.GroupBox();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.rbtnAdmin = new Infoeduka.CustomDesign.CustomRadioButton();
            this.rbtnLecturer = new Infoeduka.CustomDesign.CustomRadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLecturer.SuspendLayout();
            this.gbLecturer.SuspendLayout();
            this.gbRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLecturer
            // 
            this.pnlLecturer.Controls.Add(this.gbLecturer);
            this.pnlLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLecturer.Location = new System.Drawing.Point(0, 0);
            this.pnlLecturer.Name = "pnlLecturer";
            this.pnlLecturer.Size = new System.Drawing.Size(982, 517);
            this.pnlLecturer.TabIndex = 0;
            // 
            // gbLecturer
            // 
            this.gbLecturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLecturer.Controls.Add(this.gbRoles);
            this.gbLecturer.Controls.Add(this.btnSave);
            this.gbLecturer.Controls.Add(this.panel4);
            this.gbLecturer.Controls.Add(this.tbPassword);
            this.gbLecturer.Controls.Add(this.label4);
            this.gbLecturer.Controls.Add(this.panel3);
            this.gbLecturer.Controls.Add(this.tbEmail);
            this.gbLecturer.Controls.Add(this.label2);
            this.gbLecturer.Controls.Add(this.panel2);
            this.gbLecturer.Controls.Add(this.tbLastName);
            this.gbLecturer.Controls.Add(this.label1);
            this.gbLecturer.Controls.Add(this.panel5);
            this.gbLecturer.Controls.Add(this.tbFirstName);
            this.gbLecturer.Controls.Add(this.label3);
            this.gbLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbLecturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbLecturer.Location = new System.Drawing.Point(227, 49);
            this.gbLecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLecturer.Name = "gbLecturer";
            this.gbLecturer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLecturer.Size = new System.Drawing.Size(528, 418);
            this.gbLecturer.TabIndex = 3;
            this.gbLecturer.TabStop = false;
            this.gbLecturer.Text = "Predavač";
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.rbtnAdmin);
            this.gbRoles.Controls.Add(this.rbtnLecturer);
            this.gbRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbRoles.Location = new System.Drawing.Point(87, 235);
            this.gbRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRoles.Size = new System.Drawing.Size(342, 64);
            this.gbRoles.TabIndex = 20;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "Tip korisnika";
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AccessibleDescription = "";
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnAdmin.Location = new System.Drawing.Point(189, 23);
            this.rbtnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(124, 25);
            this.rbtnAdmin.TabIndex = 22;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Administrator";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnLecturer
            // 
            this.rbtnLecturer.AutoSize = true;
            this.rbtnLecturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnLecturer.Location = new System.Drawing.Point(19, 23);
            this.rbtnLecturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnLecturer.Name = "rbtnLecturer";
            this.rbtnLecturer.Size = new System.Drawing.Size(91, 25);
            this.rbtnLecturer.TabIndex = 21;
            this.rbtnLecturer.TabStop = true;
            this.rbtnLecturer.Text = "Predavač\r\n";
            this.rbtnLecturer.UseVisualStyleBackColor = true;
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
            this.btnSave.Location = new System.Drawing.Point(87, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(342, 34);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(166, 214);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 14;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Location = new System.Drawing.Point(166, 194);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(262, 22);
            this.tbPassword.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(87, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lozinka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(166, 165);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 1);
            this.panel3.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Location = new System.Drawing.Point(166, 146);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(262, 22);
            this.tbEmail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(87, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "E-mail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(166, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 1);
            this.panel2.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbLastName.Location = new System.Drawing.Point(166, 96);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(262, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(87, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prezime";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(166, 72);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 1);
            this.panel5.TabIndex = 5;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbFirstName.Location = new System.Drawing.Point(166, 52);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(262, 22);
            this.tbFirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(87, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime";
            // 
            // LecturerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlLecturer);
            this.Name = "LecturerMainForm";
            this.Size = new System.Drawing.Size(982, 517);
            this.Load += new System.EventHandler(this.LecturerMainForm_Load);
            this.pnlLecturer.ResumeLayout(false);
            this.gbLecturer.ResumeLayout(false);
            this.gbLecturer.PerformLayout();
            this.gbRoles.ResumeLayout(false);
            this.gbRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLecturer;
        private GroupBox gbLecturer;
        private GroupBox gbRoles;
        private CustomDesign.CustomRadioButton rbtnAdmin;
        private CustomDesign.CustomRadioButton rbtnLecturer;
        private Button btnSave;
        private Panel panel4;
        private TextBox tbPassword;
        private Label label4;
        private Panel panel3;
        private TextBox tbEmail;
        private Label label2;
        private Panel panel2;
        private TextBox tbLastName;
        private Label label1;
        private Panel panel5;
        private TextBox tbFirstName;
        private Label label3;
    }
}
