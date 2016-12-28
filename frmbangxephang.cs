using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace xếp_số_h__t
{
    public partial class frmbangxephang : Form
    {
        public frmbangxephang()
        {
            InitializeComponent();
        }
        List<string> Arr = new List<string>();
        int stt = 0;
        private void frmbangxephang_Load(object sender, EventArgs e)
        {
            lsvtennguoichoi.GridLines = true;
            lsvtennguoichoi.FullRowSelect = true;
            lsvtennguoichoi.View = View.Details;
            lsvtennguoichoi.Columns.Add(" stt", 100);
            lsvtennguoichoi.Columns.Add("Ho ten", 300);
            if (File.Exists("test.txt"))
            {
                FileStream file = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
                StreamReader Read_File = new StreamReader(file);
                string str = Read_File.ReadLine();
                while(str != null)
                {
                    Arr.Add(str);
                    ListViewItem item = new ListViewItem((++stt).ToString());
                    item.SubItems.Add(str);
                    lsvtennguoichoi.Items.Add(item);
                    str = Read_File.ReadLine();

                }
                Read_File.Close();
                file.Close();

            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txttennguoichoi.Text == "")
            {
                MessageBox.Show("ban chua nhap ten");
                return;
            }
            Arr.Add(txttennguoichoi.Text);
            ListViewItem item = new ListViewItem((++stt).ToString());
            item.SubItems.Add(txttennguoichoi.Text);
            lsvtennguoichoi.Items.Add(item);
            txttennguoichoi.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string str;
            str = lsvtennguoichoi.SelectedItems[0].SubItems[1].Text.ToString();
            int n = Arr.Count;
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] == str)
                {
                    Arr.RemoveAt(i);
                    n = Arr.Count;
                   
                }
            }
       
            stt = 0;
            lsvtennguoichoi.Items.Remove(lsvtennguoichoi.SelectedItems[0]);
        }


    }
}
