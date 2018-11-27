using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoInvese
{
    public partial class Form1 : Form
    {
       
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                System.Random random = new System.Random();

                int satir = random.Next(1, 5);
                int sutun = random.Next(1, 5);

                while (satir == sutun)
                {
                    sutun = random.Next(1, 5);
                }

                double[,] matris = new double[satir, sutun];
                double[,] matrist = new double[satir, sutun];
                double[,] matrisc = new double[satir, sutun];
                for (int i = 0; i < satir; i++)
                {
                    for (int j = 0; j < sutun; j++)
                    {
                        matris[i, j] = random.Next(1, 9);
                    }
                }
                for (int i = 0; i < satir; i++)
                {
                    for (int j = 0; j < sutun; j++)
                    {
                        label1.Text += matris[i, j] + " ";
                    }
                    label1.Text += "\n";
                }
                matrist = Transpose(matris);
                int k = matrist.GetLength(0);
                int l = matrist.GetLength(1);
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        label2.Text += matrist[i, j] + " ";
                    }
                    label2.Text += "\n";
                }
                matrisc = multiplication(matris, matrist);
                int g = matrisc.GetLength(0);
                int h = matrisc.GetLength(1);
                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        label4.Text += matrisc[i, j] + " ";
                    }
                    label4.Text += "\n";
                }
            }


            public double[,] Transpose(double[,] matrix)
            {
                int w = matrix.GetLength(0);
                int h = matrix.GetLength(1);

                double[,] transpoz = new double[h, w];

                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        transpoz[j, i] = matrix[i, j];
                    }
                }

                return transpoz;
            }
            public double[,] multiplication(double[,] matrix, double[,] matrix2)
            {
                int s = matrix.GetLength(0);
                int sut = matrix.GetLength(1);
                int s2 = matrix2.GetLength(0);
                int sut2 = matrix2.GetLength(1);
                double[,] c = new double[s, sut2];


                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < sut2; j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < s2; k++) c[i, j] = c[i, j] + matrix[i, k] * matrix2[k, j];
                    }
                }



                return c;

            }
        }
    }


