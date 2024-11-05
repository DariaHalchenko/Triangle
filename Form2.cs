using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    //В этой форме применяю свои методы, аргументы, конструкторы и  свойства.
    public partial class Form2 : Form
    {
        Button btn;
        TextBox txtA, txtB, txtnurkA, txtnurkB, txtnurkC, txtH, txtC;
        ListView listView1;
        Label labelA, labelB, labelnurkA, labelnurkB, labelnurkC, labelH, labelC;
        PictureBox pictureBox;
        public Form2()
        {
            this.Height = 600;
            this.Width = 900;
            this.Text = "Töö kolmnurgaga";
            //Button
            btn = new Button();
            btn.Text = "Käivitamine";
            btn.Font = new Font("Algerian", 18, FontStyle.Italic);
            btn.AutoSize = true;
            btn.FlatAppearance.BorderSize = 6;
            btn.FlatAppearance.BorderColor = Color.Pink;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(450, 20);
            btn.BackColor = Color.Plum;
            Controls.Add(btn);
            btn.Click += Btn_Click;

            //TextBox - txtA
            txtA = new TextBox();
            txtA.Location = new Point(160, 280);
            txtA.Font = new Font("Algerian", 13);
            txtA.Width = 100;
            txtA.Height = 80;
            Controls.Add(txtA);

            //LabelA
            labelA = new Label();
            labelA.Text = "Сторона A";
            labelA.Font = new Font("Arial", 13, FontStyle.Italic);
            labelA.ForeColor = Color.Crimson;
            labelA.AutoSize = true;
            labelA.Location = new Point(50, 280);
            Controls.Add(labelA);

            //TextBox - txtB
            txtB = new TextBox();
            txtB.Location = new Point(160, 310);
            txtB.Font = new Font("Algerian", 13);
            txtB.Width = 100;
            txtB.Height = 80;
            Controls.Add(txtB);

            //labelB
            labelB = new Label();
            labelB.Text = "Сторона B";
            labelB.Font = new Font("Arial", 13, FontStyle.Italic);
            labelB.ForeColor = Color.Crimson;
            labelB.AutoSize = true;
            labelB.Location = new Point(50, 310);
            Controls.Add(labelB);

            //TextBox - txtC
            txtC = new TextBox();
            txtC.Location = new Point(160, 340);
            txtC.Font = new Font("Algerian", 13);
            txtC.Width = 100;
            txtC.Height = 80;
            Controls.Add(txtC);

            //LabelC
            labelC = new Label();
            labelC.Text = "Сторона C";
            labelC.Font = new Font("Arial", 13, FontStyle.Italic);
            labelC.ForeColor = Color.Crimson;
            labelC.AutoSize = true;
            labelC.Location = new Point(50, 340);
            Controls.Add(labelC);

            //TextBox - txtnurkA
            txtnurkA = new TextBox();
            txtnurkA.Location = new Point(160, 370);
            txtnurkA.Font = new Font("Algerian", 13);
            txtnurkA.Width = 100;
            txtnurkA.Height = 80;
            Controls.Add(txtnurkA);

            //labelnurkA
            labelnurkA = new Label();
            labelnurkA.Text = "Угол A";
            labelnurkA.Font = new Font("Arial", 13, FontStyle.Italic);
            labelnurkA.ForeColor = Color.Crimson;
            labelnurkA.AutoSize = true;
            labelnurkA.Location = new Point(50, 370);
            Controls.Add(labelnurkA);

            //TextBox - txtnurkB
            txtnurkB = new TextBox();
            txtnurkB.Location = new Point(160, 400);
            txtnurkB.Font = new Font("Algerian", 13);
            txtnurkB.Width = 100;
            txtnurkB.Height = 80;
            Controls.Add(txtnurkB);

            //labelnurkB
            labelnurkB = new Label();
            labelnurkB.Text = "Угол  B";
            labelnurkB.Font = new Font("Arial", 13, FontStyle.Italic);
            labelnurkB.ForeColor = Color.Crimson;
            labelnurkB.AutoSize = true;
            labelnurkB.Location = new Point(50, 400);
            Controls.Add(labelnurkB);

            //TextBox - txtnurkC
            txtnurkC = new TextBox();
            txtnurkC.Location = new Point(160, 430);
            txtnurkC.Font = new Font("Algerian", 13);
            txtnurkC.Width = 100;
            txtnurkC.Height = 80;
            Controls.Add(txtnurkC);

            //labelnurkC
            labelnurkC = new Label();
            labelnurkC.Text = "Угол C";
            labelnurkC.Font = new Font("Arial", 13, FontStyle.Italic);
            labelnurkC.ForeColor = Color.Crimson;
            labelnurkC.AutoSize = true;
            labelnurkC.Location = new Point(50, 430);
            Controls.Add(labelnurkC);

            //TextBox - txtH
            txtH = new TextBox();
            txtH.Location = new Point(160, 460);
            txtH.Font = new Font("Algerian", 13);
            txtH.Width = 100;
            txtH.Height = 80;
            Controls.Add(txtH);

            //labelH
            labelH = new Label();
            labelH.Text = "Высота";
            labelH.Font = new Font("Arial", 13, FontStyle.Italic);
            labelH.ForeColor = Color.Crimson;
            labelH.AutoSize = true;
            labelH.Location = new Point(50, 460);
            Controls.Add(labelH);

            //listView1
            listView1 = new ListView();
            listView1.Location = new Point(10, 10);
            listView1.Font = new Font("Arial", 10);
            listView1.Width = 370;
            listView1.Height = 250;
            listView1.View = View.Details;
            listView1.Columns.Add("Поле", 150);
            listView1.Columns.Add("Значение", 200);
            listView1.BackColor = Color.Lavender;
            listView1.ForeColor = Color.MediumSlateBlue;
            Controls.Add(listView1);

            //pictureBox
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(500, 500);
            pictureBox.Location = new Point(400, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
            Controls.Add(pictureBox);
            pictureBox.Paint += PictureBox_Paint; 

        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b) || !double.TryParse(txtC.Text, out double angleDegrees))
            {
                return;
            }

            double angleRadians = angleDegrees * Math.PI / 180;
            int x2 = 100 + (int)(a * 10); 
            int y2 = 200;
            int x3 = 100 + (int)(b * Math.Cos(angleRadians) * 10);
            int y3 = 200 - (int)(b * Math.Sin(angleRadians) * 10);

            Point p1 = new Point(100, 200);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 5);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p1);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, nurkA, nurkB, nurkC, h,c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            h = Convert.ToDouble(txtH.Text);
            c = Convert.ToDouble(txtC.Text);
            nurkA = Convert.ToDouble(txtnurkA.Text);
            nurkB = Convert.ToDouble(txtnurkB.Text);
            nurkC = Convert.ToDouble(txtnurkC.Text);

            Triangle triangle = new Triangle(a, b, c, h, nurkA, nurkB, nurkC);
            listView1.Items.Clear();
            listView1.Items.Add("Сторона A");
            listView1.Items.Add("Сторона B");
            listView1.Items.Add("Сторона C");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Угол A");
            listView1.Items.Add("Угол B");
            listView1.Items.Add("Угол C");
            listView1.Items.Add("Полупериметра");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(triangle.outputH());
            listView1.Items[4].SubItems.Add(triangle.outputnurkA());
            listView1.Items[5].SubItems.Add(triangle.outputnurkB());
            listView1.Items[6].SubItems.Add(triangle.outputnurkC());
            listView1.Items[7].SubItems.Add(Convert.ToString(triangle.Poolperimeetrit()));
            listView1.Items[8].SubItems.Add(Convert.ToString(triangle.PindalaArvutamine()));
            if (triangle.ExistTriange)
            {
                listView1.Items[9].SubItems.Add("Существует");
            }
            else
            {
                listView1.Items[9].SubItems.Add("Не существует");
            }
            //Метод, позволяющий определить тип треугольника и определив тип,
            //меняющий отображаемую картинку на соответствующую.
            //Название типа треугольника отобразите в значении спецификатора.
            // В зависимости от типа треугольника меняем картинку
            if (triangle.ExistTriange)
            {
                if (triangle.TriangleType_Form2 == "Võrdkülgne")
                {
                    listView1.Items[10].SubItems.Add("Võrdkülgne");
                }
                else if (triangle.TriangleType_Form2 == "Võrdhaarne")
                {
                    listView1.Items[10].SubItems.Add("Võrdhaarne");
                }
                else if (triangle.TriangleType_Form2 == "Täisnurkne")
                {
                    listView1.Items[10].SubItems.Add("Täisnurkne");
                }
                else if (triangle.TriangleType_Form2 == "Teravnurkne")
                {
                    listView1.Items[10].SubItems.Add("Teravnurkne");
                }
                else if (triangle.TriangleType_Form2 == "Nürinurkne")
                {
                    listView1.Items[10].SubItems.Add("Nürinurkne");
                }
            }
            pictureBox.Invalidate(); // Обновляем PictureBox, чтобы отобразить новую картинку
        }
    }
}