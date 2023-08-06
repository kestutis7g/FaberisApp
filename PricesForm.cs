using Faberis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faberis
{
    public partial class PricesForm : Form
    {
        Prices prices = new Prices();
        public PricesForm()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Value", typeof(double)));
            dt.Columns.Add(new DataColumn("UpdatedAt", typeof(DateTime)));

            //dt.Columns["colStatus"].Expression = String.Format("IIF(colBestBefore < #{0}#, 'Ok','Not ok')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


            var data = prices.Get();

            foreach (var item in data)
            {
                dt.Rows.Add(item.Id, item.Name, item.Value, item.UpdatedAt);
            }

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["UpdatedAt"].ReadOnly = true;
            //this.dataGridView1.DataSource = prices.Get();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var data = prices.Get();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["Id"].Value == null)
                {
                    continue;
                }

                int id = -1;
                int.TryParse(row.Cells["Id"].Value.ToString(), out id);
                var price = data.FirstOrDefault(x => x.Id == id);

                if(price == null)
                {
                    prices.Add(new Price(row.Cells["Name"].Value.ToString(),
                                         (double)row.Cells["Value"].Value,
                                         "Darbo"));
                    continue;
                }
                else if(!EqualPrices(price, row))
                {
                    prices.Update(id, new Price(row.Cells["Name"].Value.ToString(),
                                                (double)row.Cells["Value"].Value,
                                                "Darbo"));
                    continue;
                }
            }
            this.Close();
        }

        private bool EqualPrices(Price price, DataGridViewRow row)
        {
            if(price.Name == row.Cells["Name"].Value.ToString() &&
               price.Value == (double)row.Cells["Value"].Value)
            {
                return true;
            }
            return false;
        }
    }
}
