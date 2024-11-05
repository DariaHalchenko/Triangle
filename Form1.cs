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
    public partial class Form1 : Form
    {
        Button btn;
        TextBox txtA, txtB, txtC;
        ListView listView1;
        Label labelA, labelB, labelC;
        PictureBox pictureBox;
        public Form1()
        {
            this.Height = 500;
            this.Width = 800;
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
            txtA.Location = new Point(160,350);
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
            labelA.Location = new Point(50, 350);
            Controls.Add(labelA);


            //TextBox - txtB
            txtB = new TextBox();
            txtB.Location = new Point(160, 380);
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
            labelB.Location = new Point(50, 380);
            Controls.Add(labelB);

            //TextBox - txtC
            txtC = new TextBox();
            txtC.Location = new Point(160, 410);
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
            labelC.Location = new Point(50, 410);
            Controls.Add(labelC);

            //listView1
            listView1 = new ListView();
            listView1.Location = new Point(10, 10);
            listView1.Font = new Font("Arial", 10);
            listView1.Width = 350;
            listView1.Height = 200;
            listView1.View = View.Details;
            listView1.Columns.Add("Поле", 150);
            listView1.Columns.Add("Значение", 200);
            Controls.Add(listView1);

            //pictureBox
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(450, 150);
            pictureBox.Size = new Size(300, 300);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(pictureBox);    
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Clear();
            listView1.Items.Add("Сторона A");
            listView1.Items.Add("Сторона B");
            listView1.Items.Add("Сторона C");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriange)
            {
                listView1.Items[5].SubItems.Add("Существует");
            }
            else
            {
                listView1.Items[5].SubItems.Add("Не существует");
            }
            //Метод, позволяющий определить тип треугольника и определив тип,
            //меняющий отображаемую картинку на соответствующую.
            //Название типа треугольника отобразите в значении спецификатора.
            if (triangle.ExistTriange)
            {
                if (triangle.TriangleType == "Võrdkülgne")
                {
                    listView1.Items[6].SubItems.Add("Võrdkülgne");
                    pictureBox.Image = Image.FromFile(@"..\..\Vordkulgne.png"); // Картинка для равностороннего треугольника
                }
                else if (triangle.TriangleType == "Võrdhaarne")
                {
                    listView1.Items[6].SubItems.Add("Võrdhaarne");
                    pictureBox.Image = Image.FromFile(@"..\..\Vordhaarne.png"); // Картинка для равнобедренного треугольника
                }
                else if (triangle.TriangleType == "Skaleeni kolmnurk")
                {
                    listView1.Items[6].SubItems.Add("Skaleeni kolmnurk");
                    pictureBox.Image = Image.FromFile(@"..\..\Skaleeni kolmnurk.jpg"); // Картинка для разностороннего треугольника
                }
                else
                {
                    pictureBox.Image = null; // Если тип треугольника не определен
                }
            }
            else
            {
                pictureBox.Image = null; // Если треугольник не существует
            }

            pictureBox.Invalidate(); // Обновляем PictureBox, чтобы отобразить новую картинку

            // Добавьте еще один метод на кнопку Запуск. Для перехода с первой формы на вторую.
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}