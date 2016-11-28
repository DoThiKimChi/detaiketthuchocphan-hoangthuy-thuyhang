using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baithi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x, y;
        private int[] Arr = new int[9];
        private int diem;
        private int Time;
        private int Level;
        private bool TT_game = true;

        private void initArr()
        {
            for (int i = 1; i < 10; i++)
            {
                Arr[i - 1] = i;
            }
        }
        private void init()
        {
            x = 2;
            y = 2;
            diem = 0;
            Time = 0;
            Level = 1;
            initArr();

        }
        private int get(int x, int y)
        {
            return x + 3 * y;
        }
        private void getanh(PictureBox pb, int a)
        {
            switch (a)
            {
                case 1: pb.Image = baithi.Properties.Resources.DRMN_01; break;
                case 2: pb.Image = baithi.Properties.Resources.DRMN_02; break;
                case 3: pb.Image = baithi.Properties.Resources.DRMN_03; break;
                case 4: pb.Image = baithi.Properties.Resources.DRMN_04; break;
                case 5: pb.Image = baithi.Properties.Resources.DRMN_05; break;
                case 6: pb.Image = baithi.Properties.Resources.DRMN_06; break;
                case 7: pb.Image = baithi.Properties.Resources.DRMN_07; break;
                case 8: pb.Image = baithi.Properties.Resources.DRMN_08; break;
                case 9: pb.Image = null; pb.BackColor = Color.White; break;
            }
        }
        private void showPb()
        {
            getanh(pb1, Arr[0]);
            getanh(pb2, Arr[1]);
            getanh(pb3, Arr[2]);
            getanh(pb4, Arr[3]);
            getanh(pb5, Arr[4]);
            getanh(pb6, Arr[5]);
            getanh(pb7, Arr[6]);
            getanh(pb8, Arr[7]);
            getanh(pb9, Arr[8]);
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            init();
            setmap();
        }
        private void intmap()
        {
            for (int i = 0; i < 200; i++) ;
        }

        private void go_left()
        {
            if (x > 0)
            {
                int temp = Arr[get(x, y)];
                Arr[get(x, y)] = Arr[get(x - 1, y)];
                Arr[get(x - 1, y)] = temp;
                x--;
                diem++;

                showPb();
            }
        }
        private void go_right()
        {
            if (x < 2)
            {
                int temp = Arr[get(x, y)];
                Arr[get(x, y)] = Arr[get(x + 1, y)];
                Arr[get(x + 1, y)] = temp;
                x--;
                diem++;

                showPb();
            }
        }
        private void go_top()
        {
            if (y > 0)
            {
                int temp = Arr[get(x, y)];
                Arr[get(x, y)] = Arr[get(x, y - 1)];
                Arr[get(x, y - 1)] = temp;
                y--;
                diem++;

                showPb();
            }
        }
        private void go_bottom()
        {
            if (y < 2)
            {
                int temp = Arr[get(x, y)];
                Arr[get(x, y)] = Arr[get(x, y + 1)];
                Arr[get(x, y + 1)] = temp;
                y--;
                diem++;

                showPb();
            }
        }
        private void setmap()
        {
            for (int i = 0; i < 200; i++)
            {
                Random rd = new Random();
                int rdn = rd.Next(1, 5);

                switch (rdn)
                {
                    case 1: go_top(); break;
                    case 2: go_right(); break;
                    case 3: go_left(); break;
                    case 4: go_bottom(); break;
                }
            }
            int temp = Arr[get(x, y)];
            Arr[get(x, y)] = Arr[8];
            Arr[8] = temp;
            x = 2;
            y = 2;
            showPb();
        
        }
    }
}
