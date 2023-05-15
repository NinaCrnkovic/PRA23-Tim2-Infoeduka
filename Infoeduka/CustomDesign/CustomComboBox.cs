using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Infoeduka.CustomDesign
{
    public class CustomComboBox : ComboBox
    {
        private Color borderColor = Color.FromArgb(23, 21, 23);


        public CustomComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            BackColor = Color.FromArgb(23, 21, 23);
            ForeColor = Color.WhiteSmoke;
            DropDownStyle = ComboBoxStyle.DropDownList;
            MaxDropDownItems = 4;
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index >= 0)
            {
                // boja pozadine kada je stavka označena
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(202, 35, 80)), e.Bounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(23, 21, 23)), e.Bounds);

                // boja teksta
                e.Graphics.DrawString(Items[e.Index].ToString(), Font, new SolidBrush(Color.White), e.Bounds);
            }
        }

        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // crta se trokut za otvaranje padajućeg izbornika
            int arrowX = Width - 20;
            int arrowY = (Height / 2) - 2;

            Point[] arrow = new Point[]
            {
            new Point(arrowX, arrowY),
            new Point(arrowX + 10, arrowY),
            new Point(arrowX + 5, arrowY + 5),
            };

            e.Graphics.FillPolygon(new SolidBrush(Color.White), arrow);




        }



    }
}
