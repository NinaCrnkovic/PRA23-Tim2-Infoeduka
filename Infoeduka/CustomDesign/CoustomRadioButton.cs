using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.CustomDesign
{
    public class CustomRadioButton : RadioButton
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // crvena boja kružića kada je RadioButton označen
            Color circleColor = Checked ? Color.FromArgb(202, 35, 80) : SystemColors.Control;

            // narančasta boja ruba kružića kada je RadioButton označen
            Color borderColor = Checked ? Color.FromArgb(220, 95, 32) : SystemColors.ControlDark;

            // veličina kružića
            int circleSize = 14;

            // izračunajte poziciju kružića
            int circleX = 2;
            int circleY = (this.Height / 2) - (circleSize / 2);

            // nacrtajte kružić
            using (Pen pen = new Pen(borderColor, 3))
            {
                pevent.Graphics.DrawEllipse(pen, circleX, circleY, circleSize, circleSize);
                pevent.Graphics.FillEllipse(new SolidBrush(circleColor), circleX + 2, circleY + 2, circleSize - 4, circleSize - 4);
            }
        }
    }
}
