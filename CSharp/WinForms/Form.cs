



namespace WinForms
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // Form
            this.Text = "My app";
            this.Size = new System.Drawing.Size(500, 500);
            this.BackColor = Color.DarkSlateGray;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormClosing += AppClosing;
            this.FormClosed += AppClosed;
            this.KeyPress += AppKeyPress;

            this.KeyPress += (s, e) =>
            {
                if(e.KeyChar == (char)13)
                {
                    MessageBox.Show("yes");
                }
            };

            this.AddButon();
            this.test();

        }

        private void AddButon()
        {
            Button btn = new Button
            {
                Text = "Click",
                Location = new Point(100, 200),
                Size = new Size(300, 50),
                BackColor = Color.WhiteSmoke,
                Name = "Joaozinho"
            };

            btn.Click += (s, e) =>
            {
                MessageBox.Show("It's a button");
            };

            this.Controls.Add(btn);
        }

        private void test()
        {
            foreach(var control in this.Controls)
            {
                if(control is Button btn)
                {
                    btn.Enabled = true;
                }
            }
        }

        private void AppKeyPress(object sender, KeyPressEventArgs e)
        {
            /// F Key
            var isKey = e.KeyChar == (char)102;

            if (isKey)
            {
                this.BackColor = Color.AliceBlue;
            }
        }

        private void AppClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closed hehe");
        }

        private void AppClosing(object sender, FormClosingEventArgs args)
        {
            var result = MessageBox.Show("Are you sure?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                args.Cancel = true;
            }
        }
    }
}
