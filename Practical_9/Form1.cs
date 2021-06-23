using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_9
{
    public partial class Form1 : Form
    {
        int all_total = 0, i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int quantity;
            int price;
            int item_total;
            quantity = int.Parse(numericUpDown1.Text);
            price = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);

            item_total = price * quantity;

            ListViewItem item = new ListViewItem();
            item.Text = listView1.SelectedItems[0].Text;
            item.SubItems.Add(price.ToString());
            item.SubItems.Add(quantity.ToString());

            listView2.Items.Add(item);

            i++;
            all_total = all_total + item_total;

            label2.Text = "₹ " + all_total;
            label2.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            int subtract = 0;
            MessageBox.Show("Are you sure ?");
            ListView.SelectedListViewItemCollection Ls = this.listView2.SelectedItems;
            foreach (ListViewItem a in Ls)
            {
                subtract += (int.Parse(a.SubItems[1].Text) * int.Parse(a.SubItems[2].Text));
            }

            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].Selected)
                {
                    listView2.Items[i].Remove();
                    i--;
                }
            }
            all_total = all_total - subtract;
            label2.Text = "₹ " + all_total;
            label2.Show();
        }
    }
}


        
