using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaCopy.Components
{
    class CustomButton : Button{
        public Color onPressBackColour = Color.FromArgb(255, 242, 208, 59);
        public Color onPressForeColour = Color.FromArgb(255, 36, 42, 52);

        public CustomButton(){
            BackColor = Color.FromArgb(255, 39, 46, 56);
            ForeColor = Color.FromArgb(255, 141, 151, 166);
            FlatStyle = FlatStyle.Flat;
        }

        protected override void OnMouseUp(MouseEventArgs mevent){
            base.OnMouseUp(mevent);

            BackColor = Color.FromArgb(255, 39, 46, 56);
            ForeColor = Color.FromArgb(255, 141, 151, 166);
        }

        protected override void OnMouseLeave(EventArgs e){
            base.OnMouseLeave(e);

            BackColor = Color.FromArgb(255, 39, 46, 56);
            ForeColor = Color.FromArgb(255, 141, 151, 166);
        }

        protected override void OnMouseDown(MouseEventArgs e){
            base.OnMouseDown(e);

            BackColor = onPressBackColour;
            ForeColor = onPressForeColour;
        }
    }
}
