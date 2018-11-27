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

            int satir = 3;
            int sutun = 4;

            while (satir == sutun)
            {
                sutun = random.Next(1, 5);
            }

            double[,] matris = new double[satir, sutun];
            double[,] matrist = new double[satir, sutun];
            double[,] matrisc = new double[satir, sutun];
            double[,] matrisdi = new double[satir, sutun];
            //rastgele sayi atama
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
            if (satir < sutun)
            {
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
                if (matrisc.GetLength(0) == 2 && matrisc.GetLength(1) == 2)
                {
                    matrisdi = inverse_2(matrisc);
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            label3.Text += matrisdi[i, j] + " ";
                        }
                        label3.Text += "\n";
                    }

                    double[,] inverse = new double[sutun, satir];
                    inverse = multiplication(matrist, matrisdi);
                    int y = inverse.GetLength(0);
                    int f = inverse.GetLength(1);
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < f; j++)
                        {
                            label5.Text += inverse[i, j] + " ";
                        }
                        label5.Text += "\n";
                    }
                }
                else if (matrisc.GetLength(0) == 3 && matrisc.GetLength(1) == 3)
                {
                    matrisdi = inverse_3(matrisc);
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            label3.Text += matrisdi[i, j] + " ";
                        }
                        label3.Text += "\n";
                    }

                    double[,] inverse = new double[sutun, satir];
                    inverse = multiplication(matrist, matrisdi);
                    int y = inverse.GetLength(0);
                    int f = inverse.GetLength(1);
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < f; j++)
                        {
                            label5.Text += inverse[i, j] + " ";
                        }
                        label5.Text += "\n";
                    }

                }
            }
            else if (satir > sutun)
            {
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
                matrisc = multiplication(matrist, matris);
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
                if (matrisc.GetLength(0) == 2 && matrisc.GetLength(1) == 2)
                {
                    matrisdi = inverse_2(matrisc);
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            label3.Text += matrisdi[i, j] + " ";
                        }
                        label3.Text += "\n";
                    }

                }
                double[,] inverse = new double[sutun, satir];
                inverse = multiplication(matrisdi, matrist);
                int y = inverse.GetLength(0);
                int f = inverse.GetLength(1);
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < f; j++)
                    {
                        label5.Text += inverse[i, j] + " ";
                    }
                    label5.Text += "\n";
                }


            }
        }


        public double DET(double[,] a, int n)
        {
            int i, j, k;
            double det = 0;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    det = a[j, i] / a[i, i];
                    for (k = i; k < n; k++)
                        a[j, k] = a[j, k] - det * a[i, k]; // HERE
                }
            }
            det = 1;
            for (i = 0; i < n; i++)
                det = det * a[i, i];
            return det;
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
        public double[,] inverse_2(double[,] matrix)
        {
            double[,] matrix2 = new double[2, 2]{ { matrix[1, 1] , -1 * matrix[0, 1] }, { -1 * matrix[1, 0] , matrix[0, 0] } };
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            double[,] matrix3 = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix3[i, j] = (1 / det) * matrix2[i, j];
                }
                label3.Text += "\n";
            }
            return matrix3;
        }
        public double[,] inverse_3(double[,] matrix)
        {
            double[,] matrix2 = new double[3, 3] { { matrix[1,1]*matrix[2,2]-matrix[1,2]*matrix[2,1], matrix[0, 2]*matrix[2, 1] - matrix[0,1] * matrix[2, 2] , matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1] },
                                                   { matrix[1,2]*matrix[2,0]-matrix[1,0]*matrix[2,2], matrix[0, 0]*matrix[2, 2] - matrix[0,2] * matrix[2, 0] , matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2] },
                                                   { matrix[1,0]*matrix[2,1]-matrix[1,1]*matrix[2,0], matrix[0, 1]*matrix[2, 0] - matrix[0,0] * matrix[2, 1] , matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0] }};

            double[,] matrix3 = new double[3,3];
            double a = DET(matrix, matrix.GetLength(0));
            label6.Text += a;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3[i, j] = (1 / a) * matrix2[i, j];
                }
                label3.Text += "\n";
            }
            return matrix3;
            
        }
    }
}


