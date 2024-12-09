using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Buoi03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupListView();
        }
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Thêm các cột
            listView1.Columns.Add("STT", 100);
            listView1.Columns.Add("Mã", 100);
            listView1.Columns.Add("Tên", 100);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSTT.Text != "" && txtMa.Text != "" && txtName.Text != "")
            {
                ListViewItem item = new ListViewItem(txtSTT.Text);
                item.SubItems.Add(txtMa.Text);
                item.SubItems.Add(txtName.Text);
                listView1.Items.Add(item);

                // Xóa text sau khi thêm
                txtSTT.Clear();
                txtMa.Clear();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtSTT.Text;
                selectedItem.SubItems[1].Text = txtMa.Text;
                selectedItem.SubItems[2].Text = txtName.Text;

                // Xóa text sau khi sửa
                txtSTT.Clear();
                txtMa.Clear();
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa!");
            }
        }

        private void txtSTT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

