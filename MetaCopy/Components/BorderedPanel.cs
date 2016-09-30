using System;
using System.Drawing;
using System.Windows.Forms;

namespace MetaCopy.Components
{
    public class BorderedPanel : Panel
    {
        Panel panel;
        TextBox textBox;

        public BorderedPanel()
        {
            panel = new Panel()
            {
                BorderStyle = BorderStyle.None,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right,
                
                BackColor = Color.FromArgb(255, 29, 34, 41),
                ForeColor = Color.FromArgb(255, 141, 151, 166)
                //Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 1)
            };

            textBox = new TextBox(){
                BorderStyle = BorderStyle.None,
                Location = new Point(8, 6),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right,

                BackColor = Color.FromArgb(255, 29, 34, 41),
                ForeColor = Color.FromArgb(255, 141, 151, 166),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point, 1),
                TabIndex = 0,
                TabStop = false,
            };

            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1),
                //Visible = false
            };
            
            container.Controls.Add(textBox);
            container.Controls.Add(panel);
            this.Controls.Add(container);

            DefaultBorderColor = Color.FromArgb(255, 49, 54, 61);
            FocusedBorderColor = Color.FromArgb(255, 49, 54, 61);
            BackColor = Color.FromArgb(255, 29, 34, 41);

            Padding = new Padding(1);
            Size = panel.Size;

            this.SendToBack();
        }

        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }

        public void SelectAll(){
            textBox.SelectAll();
        }

        public void hideTextbox(){
            textBox.Visible = false;
        }

        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = Color.FromArgb(255, 49, 54, 61);
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = Color.FromArgb(255, 49, 54, 61);
            base.OnLeave(e);
        }
    }
}
