using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAPPLICATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double cost_of_item()
        {
            Double sum = 0;
            int i = 0;

            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void addCost()
        {
            Double tax, x;
            tax = 1.5;
            if (dataGridView1.Rows.Count > 0)
            {
                lblTax.Text = String.Format("{0:c2}", ((cost_of_item() * tax) / 100));
                lblSubTot.Text = String.Format("{0:c2}", (cost_of_item()));
                x = (cost_of_item() * tax) / 100;
                lblTotal.Text = String.Format("{0:c2}", (cost_of_item() + x));

            }
        }

        private void Change()
        {
            Double tax, x, c;
            tax = 1.5;
            if (dataGridView1.Rows.Count > 0)
            {
                x = ((cost_of_item() * tax) / 100) + cost_of_item();
                c = Convert.ToInt32(lblCost.Text);
                lblChange.Text = String.Format("{0:c2}", c - x);
            }
        }
        Bitmap bitmap;
        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int hight = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = hight;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                lblChange.Text = "";
                lblCost.Text = "0";
                lblSubTot.Text = "";
                lblTax.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                comboBox1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Ovo");
            comboBox1.Items.Add("Gopay");
            comboBox1.Items.Add("LinkAja");
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (lblCost.Text == "0")
            {
                lblCost.Text = "";
                lblCost.Text = b.Text;
            }
            else if (b.Text == "."){
                if(!lblCost.Text.Contains("."))
                {
                    lblCost.Text = lblCost.Text + b.Text;
                }
            }
            else
            {
                lblCost.Text = lblCost.Text + b.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblCost.Text = "0";
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCost.Text = "0";
            }
        }

        private void removeBtn(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            addCost();
            if (comboBox1.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCost.Text = "0";
            }
        }

        private void VanlilaLateBtn_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if((bool)(row.Cells[0].Value="Vanilla Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;
                     
                }
            }
            dataGridView1.Rows.Add("Vanilla Latte", "1", costOfItem);
            addCost();

        }

        private void MatchaBtn_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Matcha Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Matcha Latte", "1", costOfItem);
            addCost();
        }

        private void Americano_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Americano"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Americano", "1", costOfItem);
            addCost();
        }

        private void Espresso_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Espresso"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Espresso", "1", costOfItem);
            addCost();
        }

        private void CaramelLatte_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Caramel Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Caramel Latte", "1", costOfItem);
            addCost();
        }

        private void Cappucino_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cappucino"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Cappucino", "1", costOfItem);
            addCost();
        }

        private void Latte_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Latte", "1", costOfItem);
            addCost();
        }

        private void Tubruk_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kopi Tubruk"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Kopi Tubruk", "1", costOfItem);
            addCost();
        }

        private void KopiSusu_Click(object sender, EventArgs e)
        {
            Double costOfItem = 18.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kopi Susu"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Kopi Susu", "1", costOfItem);
            addCost();
        }

        private void TaroLatte_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Taro Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Taro Latte", "1", costOfItem);
            addCost();
        }

        private void RedVelvet_Click(object sender, EventArgs e)
        {
            Double costOfItem = 20.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Red Velvet Latte"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Red Velvet Latte", "1", costOfItem);
            addCost();
        }

        private void Chocolate_Click(object sender, EventArgs e)
        {
            Double costOfItem = 18.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chocolate"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Chocolate", "1", costOfItem);
            addCost();
        }

        private void LemonTea_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Lemon Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Lemon Tea", "1", costOfItem);
            addCost();
        }

        private void Lychee_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Lychee Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Lychee Tea", "1", costOfItem);
            addCost();
        }

        private void ThaiTea_Click(object sender, EventArgs e)
        {
            Double costOfItem = 15.000;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Thai Tea"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costOfItem;

                }
            }
            dataGridView1.Rows.Add("Thai Tea", "1", costOfItem);
            addCost();
        }
    }
}
