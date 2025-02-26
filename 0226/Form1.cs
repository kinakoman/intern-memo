using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1: Form
    {
        TextBox textbox = new TextBox();
        Label label = new Label();
        Button button = new Button();
        public Form1()
        {
            InitializeComponent();

            textbox.Height = textbox.PreferredHeight;
            textbox.Width = this.ClientSize.Width;
            textbox.ScrollBars = ScrollBars.Both;
            textbox.Multiline = false;
            textbox.WordWrap = false;
            textbox.Font = new Font("Consolas", 12);
            textbox.Location = new Point(0, 10);
            this.Controls.Add(textbox);

            button.Text = "Add Label";
            button.Size = new Size(200, 20);
            button.Location = new Point(0, 40);
            button.Click += new EventHandler(set_labelText);
            this.Controls.Add(button);

            label.AutoSize = true;
            label.Text = "test";
            label.Location = new Point(0, 70);
            label.Font = new Font("Consolas", 12);
            this.Controls.Add(label);
        }
        private void set_labelText(object sender,EventArgs e)
        {
            label.Text = textbox.Text;
        }
    }
}
