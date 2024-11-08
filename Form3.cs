using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form3 : Form
    {
        private DataGridView dg;
        private DataSet ds;

        public Form3()
        {
            this.Width = 700;
            this.Height = 200;

            dg = new DataGridView();
            dg.Location = new Point(10, 10);
            dg.Size = new Size(760, 350);
            Controls.Add(dg);

            ds = new DataSet("XML file");

            string filePath = @"..\..\kolmnurgad.xml";
            if (File.Exists(filePath))
            {
                try
                {
                    ds.ReadXml(filePath);

                    if (ds.Tables.Contains("Triangle"))
                    {
                        dg.DataSource = ds.Tables["Triangle"];
                    }
                    else
                    {
                        MessageBox.Show("Tabelit ei leitud.", "Viga");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga laadimisel" + ex.Message, "Viga");
                }
            }
            else
            {
                MessageBox.Show("Faili ei leitud", "Viga");
            }
        }
    }
}
