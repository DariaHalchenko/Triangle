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
        Button btn, color, btn2;
        TextBox txtA, txtB, txtnurk, txtH, txtC;
        ListView listView1;
        Label labelA, labelB, labelnurk, labelH, labelC;
        PictureBox pictureBox;
        List<Triangle> triangles = new List<Triangle> {};
        ColorDialog colordialog;
        private Color taidab = Color.White;
        public Form2()
        {
            this.Height = 600;
            this.Width = 920;
            this.Text = "Töötamine kolmnurgaga";
            this.BackColor = Color.MintCream;
            //Button - btn
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

            //Button - btn2
            btn2 = new Button();
            btn2.Text = "Tabel";
            btn2.Font = new Font("Algerian", 18, FontStyle.Italic);
            btn2.AutoSize = true;
            btn2.FlatAppearance.BorderSize = 6;
            btn2.FlatAppearance.BorderColor = Color.Pink;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(650, 20);
            btn2.BackColor = Color.Plum;
            Controls.Add(btn2);
            btn2.Click += Btn2_Click; 

            //Button - color
            color = new Button();
            color.Text = "Värvi";
            color.Font = new Font("Algerian", 18, FontStyle.Italic);
            color.AutoSize = true;
            color.FlatAppearance.BorderSize = 6;
            color.FlatAppearance.BorderColor = Color.Pink;
            color.FlatStyle = FlatStyle.Flat;
            color.Location = new Point(450, 80);
            color.BackColor = Color.Plum;
            Controls.Add(color);
            color.Click += Color_Click;

            //TextBox - txtA
            txtA = new TextBox();
            txtA.Location = new Point(160, 280);
            txtA.Font = new Font("Arial", 13, FontStyle.Bold);
            txtA.Width = 100;
            txtA.Height = 80;
            txtA.BackColor = Color.MistyRose;
            txtA.ForeColor = Color.MediumVioletRed;
            Controls.Add(txtA);

            //Label - labelA
            labelA = new Label();
            labelA.Text = "Külg A";
            labelA.Font = new Font("Algerian", 13, FontStyle.Bold | FontStyle.Italic);
            labelA.ForeColor = Color.Crimson;
            labelA.AutoSize = true;
            labelA.Location = new Point(70, 280);
            Controls.Add(labelA);

            //TextBox - txtB
            txtB = new TextBox();
            txtB.Location = new Point(160, 310);
            txtB.Font = new Font("Arial", 13, FontStyle.Bold);
            txtB.Width = 100;
            txtB.Height = 80;
            txtB.BackColor = Color.MistyRose;
            txtB.ForeColor = Color.MediumVioletRed;
            Controls.Add(txtB);

            //Label - labelB
            labelB = new Label();
            labelB.Text = "Külg B";
            labelB.Font = new Font("Algerian", 13, FontStyle.Bold | FontStyle.Italic);
            labelB.ForeColor = Color.Crimson;
            labelB.AutoSize = true;
            labelB.Location = new Point(70, 310);
            Controls.Add(labelB);

            //TextBox - txtC
            txtC = new TextBox();
            txtC.Location = new Point(160, 340);
            txtC.Font = new Font("Arial", 13, FontStyle.Bold);
            txtC.Width = 100;
            txtC.Height = 80;
            txtC.BackColor = Color.MistyRose;
            txtC.ForeColor = Color.MediumVioletRed;
            Controls.Add(txtC);

            //Label - labelC
            labelC = new Label();
            labelC.Text = "Külg C";
            labelC.Font = new Font("Algerian", 13, FontStyle.Bold | FontStyle.Italic);
            labelC.ForeColor = Color.Crimson;
            labelC.AutoSize = true;
            labelC.Location = new Point(70, 340);
            Controls.Add(labelC);

            //TextBox - txtnurk
            txtnurk = new TextBox();
            txtnurk.Location = new Point(160, 370);
            txtnurk.Font = new Font("Arial", 13, FontStyle.Bold);
            txtnurk.Width = 100;
            txtnurk.Height = 80;
            txtnurk.BackColor = Color.MistyRose;
            txtnurk.ForeColor = Color.MediumVioletRed;
            Controls.Add(txtnurk);

            //Label - labelnurk
            labelnurk = new Label();
            labelnurk.Text = "Nurk";
            labelnurk.Font = new Font("Algerian", 13, FontStyle.Bold | FontStyle.Italic);
            labelnurk.ForeColor = Color.Crimson;
            labelnurk.AutoSize = true;
            labelnurk.Location = new Point(70, 370);
            Controls.Add(labelnurk);

            //TextBox - txtH
            txtH = new TextBox();
            txtH.Location = new Point(160, 400);
            txtH.Font = new Font("Arial", 13, FontStyle.Bold);
            txtH.Width = 100;
            txtH.Height = 80;
            txtH.BackColor = Color.MistyRose;
            txtH.ForeColor = Color.MediumVioletRed;
            Controls.Add(txtH);

            //Label - labelH
            labelH = new Label();
            labelH.Text = "Kõrgus";
            labelH.Font = new Font("Algerian", 13, FontStyle.Bold | FontStyle.Italic);
            labelH.ForeColor = Color.Crimson;
            labelH.AutoSize = true;
            labelH.Location = new Point(70, 400);
            Controls.Add(labelH);

            //ListView - listView1
            listView1 = new ListView();
            listView1.Location = new Point(10, 10);
            listView1.Font = new Font("Arial", 12);
            listView1.Width = 360;
            listView1.Height = 250;
            listView1.View = View.Details;
            listView1.Columns.Add("Väli", 165);
            listView1.Columns.Add("Väärtused", 190);
            listView1.BackColor = Color.Lavender;
            listView1.ForeColor = Color.MediumSlateBlue;
            Controls.Add(listView1);

            //pictureBox
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(480, 350);
            pictureBox.Location = new Point(400, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
            pictureBox.BackColor = Color.LavenderBlush;
            Controls.Add(pictureBox);
            pictureBox.Paint += PictureBox_Paint;

            //colordialog
            colordialog = new ColorDialog();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        //В диалоговом окне можно выбрать цвет заливки для треугольника
        private void Color_Click(object sender, EventArgs e)
        {
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                taidab = colordialog.Color; // Сохраняем выбранный цвет
                pictureBox.Invalidate(); // Обновляем PictureBox для отображения нового цвета
            }
        }
        //Рисует треугольник используя длины сторон (a, b, c) и угол между сторонами 
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            //Проверяет, могут ли значения, введённые в текстовые поля быть преобразованы в числа типа double
            // если числа введённые правильно то преобразовывают в числа double для рисование треугольника
            if (!double.TryParse(txtA.Text, out double a) || 
                !double.TryParse(txtB.Text, out double b) ||
                !double.TryParse(txtC.Text, out double c) ||
                !double.TryParse(txtnurk.Text, out double nurgaAste))
            {
                return;
            }
            // Переводим угла в радиан, так как функции Math.Cos() и Math.Sin() ожидают угол в радианах, а не в градусах
            double raadiaan = nurgaAste * Math.PI / 180;

            // Вычисляем координаты вершин треугольника
            int x2 = 100 + (int)(a * 10);
            int y2 = 200;
            int x3 = 100 + (int)(b * Math.Cos(raadiaan) * 10);
            int y3 = 200 - (int)(b * Math.Sin(raadiaan) * 10);

            // Создаются точки для вершин 
            Point p1 = new Point(100, 200);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            // Рисуем треугольник
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(taidab); // Кисть для заполнение треугольника цветом
            Point[] punktid = { p1, p2, p3 }; // Массив точек треугольника
            g.FillPolygon(brush, punktid); // Заполняем треугольник цветом

            // Рисуем контур треугольника
            Pen pen = new Pen(Color.Blue, 5);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p1);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, nurk, h,c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            h = Convert.ToDouble(txtH.Text);
            c = Convert.ToDouble(txtC.Text);
            nurk = Convert.ToDouble(txtnurk.Text);

            Triangle triangle = new Triangle(a, b, c, h, nurk);
            triangles.Add(triangle);

            listView1.Items.Clear();

            listView1.Items.Add("Külg A");
            listView1.Items.Add("Külg B");
            listView1.Items.Add("Külg C");
            listView1.Items.Add("Kõrgus");
            listView1.Items.Add("Nurk");
            listView1.Items.Add("Poolperimeeter");
            listView1.Items.Add("Piirkond");
            listView1.Items.Add("Kas see on olemas?");
            listView1.Items.Add("Täpsustaja");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(triangle.outputH());
            listView1.Items[4].SubItems.Add(triangle.outputnurk());
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Poolperimeetrit()));
            listView1.Items[6].SubItems.Add(Convert.ToString(triangle.PindalaArvutamine()));
            if (triangle.ExistTriange)
            {
                listView1.Items[7].SubItems.Add("On olemas");
            }
            else
            {
                listView1.Items[7].SubItems.Add("Ei ole olemas");
            }
            //Метод, позволяющий определить тип треугольника и определив тип,
            //меняющий отображаемую картинку на соответствующую.
            //Название типа треугольника отобразите в значении спецификатора.
            // В зависимости от типа треугольника меняем картинку
            if (triangle.ExistTriange)
            {
                if (triangle.TriangleType_Form2 == "Võrdkülgne")
                {
                    listView1.Items[8].SubItems.Add("Võrdkülgne");
                }
                else if (triangle.TriangleType_Form2 == "Võrdhaarne")
                {
                    listView1.Items[8].SubItems.Add("Võrdhaarne");
                }
                else if (triangle.TriangleType_Form2 == "Täisnurkne")
                {
                    listView1.Items[8].SubItems.Add("Täisnurkne");
                }
                else if (triangle.TriangleType_Form2 == "Teravnurkne")
                {
                    listView1.Items[8].SubItems.Add("Teravnurkne");
                }
                else if (triangle.TriangleType_Form2 == "Nürinurkne")
                {
                    listView1.Items[8].SubItems.Add("Nürinurkne");
                }
            }
            pictureBox.Invalidate(); // Обновляем PictureBox, чтобы отобразить новую картинку
            Triangle.Salvesta(triangles);
        }
    }
}