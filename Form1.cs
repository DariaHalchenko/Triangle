using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        Button btn;
        TextBox txtA, txtB, txtC;
        ListView listView1;
        public Form1()
        {
            this.Height = 800;
            this.Width = 900;
            this.Text = "Töö kolmnurgaga";
            //Button
            btn = new Button();
            btn.Text = "Käivitamine";
            btn.Font = new Font("Algerian", 28, FontStyle.Italic);
            btn.AutoSize = true;
            btn.FlatAppearance.BorderSize = 6;
            btn.FlatAppearance.BorderColor = Color.Pink;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(550, 40);
            btn.BackColor = Color.Plum;
            Controls.Add(btn);
            btn.Click += Btn_Click;

            //TextBox - txtA
            txtA = new TextBox();
            txtA.Location = new Point(150 + btn.Width + 10, btn.Height);
            txtA.Font = new Font("Algerian", 10);
            txtA.Width = 200;
            Controls.Add(txtA);

            //TextBox - txtB
            txtB = new TextBox();
            txtB.Location = new Point(150 + btn.Width + 10, btn.Height);
            txtB.Font = new Font("Algerian", 10);
            txtB.Width = 200;
            Controls.Add(txtB);

            //TextBox - txtC
            txtC = new TextBox();
            txtC.Location = new Point(150 + btn.Width + 10, btn.Height);
            txtC.Font = new Font("Algerian", 10);
            txtC.Width = 200;
            Controls.Add(txtC);

            //listView1
            listView1 = new ListView();
            listView1.Location = new Point(0, 0);
            listView1.Font = new Font("Algerian", 10);
            listView1.AutoSize = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
        }
        
    }
}