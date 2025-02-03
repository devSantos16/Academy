

using AlunxBrilhantesExample.Class;

namespace AlunxBrilhantesExample
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            this.LeftPanel.BackColor = Color.WhiteSmoke;
            this.LeftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            this.LeftPanel.FlowDirection = FlowDirection.TopDown;

            this.Load += FormLoad;

        }

        private void FormLoad(object? sender, EventArgs e)
        {
            List<CustomButton> customButtons = new List<CustomButton>
            {
                new CustomButton("ADITAMENTO"),
                new CustomButton("COPARTICIPAÇÃO"),
                new CustomButton("SIGA"),
            };

            foreach (CustomButton cb in customButtons)
            {
                Button btn = new Button
                {
                    Text = cb.Name,
                    Width = LeftPanel.Width - 10,
                    Height = 50,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Gray,

                    FlatAppearance =
                    {
                        BorderSize = 0
                    },
                };

                this.LeftPanel.Controls.Add(btn);
            }
        }
    }
}
