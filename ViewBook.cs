using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_registration
{
    public partial class ViewBook : Form
    {
        int indexrow;
        public ViewBook()
        {
            InitializeComponent();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ISBN", typeof(int));
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("BookName", typeof(string));
            dataTable.Columns.Add("Genre", typeof(string));
            dataTable.Columns.Add("Price", typeof(int));

            foreach (var book in AddBooks.listbooks)
            {
                dataTable.Rows.Add(book.isbn, book.Id, book.BookName, book.Genre, book.Price);
            }

            dataGridView1.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexrow];
            txtvname.Text = row.Cells[2].Value.ToString();
            txtvgenre.Text = row.Cells[3].Value.ToString();
            txtvprice.Text = row.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdataRow = dataGridView1.Rows[indexrow];
            newdataRow.Cells[2].Value = txtvname.Text;
            newdataRow.Cells[3].Value = txtvgenre.Text;
            newdataRow.Cells[4].Value = txtvprice.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtvname.Text = "";
            txtvgenre.Text = "";
            txtvprice.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (dataGridView1.DataSource != null)
            {
                string keyword = textBox1.Text;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("BookName LIKE '%{0}%'", keyword);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
        }
    }
}
