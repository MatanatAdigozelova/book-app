using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_registration
{

    public partial class AddBooks : Form
    {
        public static List<Book> listbooks = new List<Book>();
        public AddBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" && txtGenre.Text == "" && txtPrice.Text == "")
            {

                MessageBox.Show("Please writing all data");

            }
            else
            {
                
                Book book = new Book(txtBookName.Text, txtGenre.Text, int.Parse(txtPrice.Text));
                
                listbooks.Add(book);

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtGenre.Clear();
                txtPrice.Clear();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }

    public class Book
    {
        
        private static int count = 0;
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public int isbn { get; set; }
        public string BookName { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public Book(string n, string g, int p)
        {
            Random randoms = new Random();
            isbn = randoms.Next(1000, 10000);
            BookName = n;
            Genre = g;
            Price = p;
            count++;
            _id = count;
        }

        public Book()
        {
        }
    }
    public class Genre
    {
        private static int count = 0;
        private int _id;
        public string GenreName { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }

        }
        public Genre(string n)
        {
            GenreName = n;
            count++;
            _id = count;

        }


    }
}
