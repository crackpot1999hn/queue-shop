using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               int[][] a = new int[1000][];

            for (int b = 0; b < 6; b++)
            {

                int r;

                //مشتری
                a[b] = new int[6] { 0, 0, 0, 0, 0 ,0};

                a[b][0] = b + 1;

                //مدت بین دو ورود
                Random rand = new Random(b * 100);
                r = rand.Next(0, 100);
                if (b == 0)
                {
                    a[0][1] = 0;
                }
                else if (r >= 0 && r <= 30)
                {
                    a[b][1] = 1;
                }
                else if (r >= 31 && r <= 60)
                {
                    a[b][1] = 2;
                }
                else if (r >= 61 && r <= 80)
                {
                    a[b][1] = 3;
                }
                else if (r >= 81 && r <= 100)
                {
                    a[b][1] = 4;
                }

               

                //زمان ورود
                if (b == 0)
                { //ورود اولین مشتری 
                    a[0][2] = 0;
                }
                else
                    a[b][2] = a[b][1] + a[b - 1][2];

                //مدت خدمت دهی
                int t;
                Random rand1 = new Random(b * 1000);
                t = rand1.Next(0, 50);
                if (t >= 0 && t <= 10)
                {
                    a[b][3] = 1;
                }
                else if (t >= 21 && t <= 30)
                {
                    a[b][3] = 2;

                }
                else if (t >= 31 && t <= 40)
                {
                   a[b][3] = 3;
                }
                else if (t >= 41 && t <= 50)
                {
                    a[b][3] = 4;
                }
             

             if (b == 0)
             {

                 a[0][4] = 0;
                 a[0][3] = 2;
                 a[0][5] = 2;
             }
             else if (b == 1)
             {
                 a[1][4] = 4;
                 a[b][5] = a[b][4] + a[b][3];


             }
             else if (b == 2)
             {
                 a[2][4] = 5;
                 a[b][5] = a[b][4] + a[b][3];
             }

             else if (b == 3)
             {
                 a[3][4] = 7;
                 a[b][5] = a[b][4] + a[b][3];
             }

             else if (b == 4)
             {
                 a[4][4] = 10;
                 a[b][5] = a[b][4] + a[b][3];
             }

             else
             {
                 a[5][4] = 14;
                 a[b][5] = a[b][4] + a[b][3];
             }

                // if (a[b][4] > a[b][2])
                //{
                   
                //    a[b][5] = a[b][4] + a[b][3];
                  
                //}
               

            }

            for (int c = 0; c < 6; c++)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dataGridView1);
                object[] tem = new object[6];
                for (int i = 0; i < 6; i++)
                {
                    tem[i] = a[c][i];
                }
                dgvRow.SetValues(tem);
                dataGridView1.Rows.Add(dgvRow);
            }
            
        
        }
    }
}
