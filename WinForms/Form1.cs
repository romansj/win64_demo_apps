using ClassLibraryNETSt;
using System.Collections.ObjectModel;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;


            var randomGenerator = new RandomGenerator("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ");
            for (int i = 0; i < 100; i++)
            {
                var title = randomGenerator.getRandomString(5, 20);
                var descr = randomGenerator.getRandomString(5, 20);


                listView1.Items.Add(new ListViewItem(title + "\n" + descr));

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}