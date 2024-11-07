using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form3 : Form
    {
        DataSet ds; 
        DataGridView dg; 

        public Form3()
        {
            InitializeComponent();

            this.Width = 800; 
            this.Height = 400; 

            ds = new DataSet("XML file"); 
            ds.ReadXml(@"..\..\kolmnurgad.xml");

            dg = new DataGridView();
            dg.Location = new Point(10, 10);
            dg.Size = new Size(760, 350);
            dg.DataSource = ds.Tables["Triangle"];
            

            Controls.Add(dg);

            MessageBox.Show("Andmed on üles laetud ja vormil kuvatud.","Edu");

            // Создаем новую строку данных

            DataRow newRow = ds.Tables["Triangle"].NewRow();
            newRow["Külg_A"] = Forms2.txtKylgA.Text;
            newRow["Külg_B"] = txtKylgB.Text;
            newRow["Külg_C"] = txtKylgC.Text;
            newRow["Kõrgus"] = txtKorgus.Text;
            newRow["Nurk"] = txtNurk.Text;
            newRow["Poolperimeeter"] = txtPoolperimeeter.Text;
            newRow["Piirkond"] = txtPiirkond.Text;
            newRow["Täpsustaja"] = txtTäpsustaja.Text;

            // Добавляем новую строку в таблицу
            ds.Tables["Triangle"].Rows.Add(newRow);

            // Сохраняем изменения в XML файл (перезаписываем весь файл)
            try
            {
                ds.WriteXml(@"..\..\kolmnurgad.xml");
                MessageBox.Show("Новый треугольник добавлен и сохранён.", "Успех");

                // Обновляем DataGridView, чтобы отобразить все данные
                dg.DataSource = ds.Tables["Triangle"];

                // Очищаем поля для ввода
                txtKylgA.Clear();
                txtKylgB.Clear();
                txtKylgC.Clear();
                txtKorgus.Clear();
                txtNurk.Clear();
                txtPoolperimeeter.Clear();
                txtPiirkond.Clear();
                txtTäpsustaja.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных в файл: " + ex.Message, "Ошибка");
            }
        }
    }
}
