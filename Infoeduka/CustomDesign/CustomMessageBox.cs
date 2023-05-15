using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Infoeduka.CustomDesign
{


    public class CustomMessageBox
    {
        public static DialogResult Show(string message, string title, MessageBoxButtons buttons)
        {
            Form form = new Form();
            Label label = new Label();
            Button button1 = new Button();
            Button button2 = new Button();
           

            form.Text = title;
            label.Text = message;

            switch (buttons)
            {
                case MessageBoxButtons.OKCancel:
                    button1.Text = "Obriši";
                    button2.Text = "Odustani";
                    
                    form.AcceptButton = button1;
                    form.CancelButton = button2;
                    break;

                case MessageBoxButtons.YesNo:
                    button1.Text = "Da";
                    button2.Text = "Ne";
                    form.AcceptButton = button1;
                    form.CancelButton = button2;
                    break;

                default:
                    button1.Visible = false;
                    button2.Text = "OK";
                 
                    form.AcceptButton = button2;
                    break;
            }

            button1.BackColor = Color.FromArgb(220, 95, 32);
            button2.BackColor = Color.FromArgb(220, 95, 32);
         

            button1.ForeColor = Color.WhiteSmoke;
            button2.ForeColor = Color.WhiteSmoke;
    

            button1.DialogResult = DialogResult.Yes;
            button2.DialogResult = DialogResult.No;
                //(buttons == MessageBoxButtons.YesNo) ? DialogResult.Yes : DialogResult.OK;
      

            label.SetBounds(9, 20, 372, 13);
         
            button1.SetBounds(215, 210, 85, 30);
            button2.SetBounds(304, 210, 85, 30);

           


            label.AutoSize = true;
            label.Font = new Font("Arial", 12);
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
          
           
            form.ClientSize = new Size(400, 250);
            form.Controls.AddRange(new Control[] { label, button1, button2});
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Color.FromArgb(23,21,23);
            label.ForeColor = Color.WhiteSmoke;

            DialogResult dialogResult = form.ShowDialog();
            form.Dispose();
            return dialogResult;
        }
    }
}
