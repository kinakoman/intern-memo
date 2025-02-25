using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        //Label label = new Label();

        Button button1;
        Button button2;
        Panel panel;
        public Form1()
        {
            InitializeComponent();
            button1 = new Button();
            button2 = new Button();

            panel = new Panel();

            //フォームサイズの最小値
            this.MinimumSize = new Size(200+20, 400);

            //label.Text = "hello";
            //label.Location = new Point(10, 10);
            //label.AutoSize = true;
            //this.Controls.Add(label);
            button1.Text = "button text";
            button1.Location = new Point(0, 30);
            // Form.ClientSize.Heightでフォームの高さを取得可
            button1.Size=new Size(120, this.ClientSize.Height-40);
            button2 = new Button();
            button2.Text = "button text2";
            button2.Location = new Point(0, 0);
            button2.AutoSize = true;
            button2.Click += new EventHandler(button2_Click);


            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(200, this.ClientSize.Height);
            panel.Location = new Point((this.ClientSize.Width-panel.Width) / 2, 0);

            //this.Controls.AddRange(new Control[]{ button2, button1 });

            panel.Controls.AddRange(new Control[] { button2, button1 });
            this.Controls.Add(panel);

            // リサイズ用のハンドラーを登録
            this.Resize += new EventHandler(Form1_Resize);
        }

        // リサイズ関数
        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Height = this.ClientSize.Height-40;
            panel.Height = this.ClientSize.Height;
            panel.Location = new Point((this.ClientSize.Width - panel.Width) / 2, 0);
            //panel.Location = new Point((200 - this.ClientSize.Width) / 2, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button2_Click");
        }
    }
    
    
}
