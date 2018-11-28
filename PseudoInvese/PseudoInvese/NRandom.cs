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
    public partial class NRandom : Form
    {
        public NRandom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Text.Equals(numericUpDown3.Text))
            {
                MessageBox.Show("Please change value row or column!");
                return;
            }
            int satir = Int32.Parse(numericUpDown1.Text);
            int sutun = Int32.Parse(numericUpDown3.Text);
            if (satir == 1 && sutun == 2)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Hide();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion
            }
            else if (satir == 1 && sutun == 3)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Hide();
                n5.Hide();
                n6.Hide();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 1 && sutun == 4)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Hide();
                n6.Hide();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 1 && sutun == 5)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Show();
                n6.Hide();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 2 && sutun == 1)
            {
                #region 
                n1.Show();
                n2.Hide();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion
            }
            else if (satir == 2 && sutun == 3)
            {
                #region 
                
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Hide();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 2 && sutun == 4)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Hide();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                

                #endregion


            }
            else if (satir == 2 && sutun == 5)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Show();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Show();
                n11.Hide();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                 #endregion

            }
            else if (satir == 3 && sutun == 1)
            {
                #region
                n1.Show();
                n2.Hide();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                 #endregion
            }
            else if (satir == 3 && sutun == 2)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();            

                #endregion

            }
            else if (satir == 3 && sutun == 4)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Show();
                n15.Hide();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
               
                #endregion


            }
            else if (satir == 3 && sutun == 5)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Show();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Show();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Show();
                n15.Show();
                n16.Hide();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
              #endregion

            }
            else if (satir == 4 && sutun == 1)
            {
                #region 
                n1.Show();
                n2.Hide();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion
            }
            else if (satir == 4 && sutun == 2)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Show();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 4 && sutun == 3)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Show();
                n18.Show();
                n19.Hide();
                n20.Hide();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                 #endregion

            }
            else if (satir == 4 && sutun == 5)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Show();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Show();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Show();
                n15.Show();
                n16.Show();
                n17.Show();
                n18.Show();
                n19.Show();
                n20.Show();
                n21.Hide();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 5 && sutun == 1)
            {
                #region
                n1.Show();
                n2.Hide();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Hide();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Hide();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Hide();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Show();
                n22.Hide();
                n23.Hide();
                n24.Hide();
                n25.Hide();
               #endregion
            }
            else if (satir == 5 && sutun == 2)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Hide();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Hide();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Hide();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Show();
                n18.Hide();
                n19.Hide();
                n20.Hide();
                n21.Show();
                n22.Show();
                n23.Hide();
                n24.Hide();
                n25.Hide();
                #endregion

            }
            else if (satir == 5 && sutun == 3)
            {
                #region
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Hide();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Hide();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Hide();
                n15.Hide();
                n16.Show();
                n17.Show();
                n18.Show();
                n19.Hide();
                n20.Hide();
                n21.Show();
                n22.Show();
                n23.Show();
                n24.Hide();
                n25.Hide();
               #endregion

            }
            else if (satir == 5 && sutun == 4)
            {
                #region 
                n1.Show();
                n2.Show();
                n3.Show();
                n4.Show();
                n5.Hide();
                n6.Show();
                n7.Show();
                n8.Show();
                n9.Show();
                n10.Hide();
                n11.Show();
                n12.Show();
                n13.Show();
                n14.Show();
                n15.Hide();
                n16.Show();
                n17.Show();
                n18.Show();
                n19.Show();
                n20.Hide();
                n21.Show();
                n22.Show();
                n23.Show();
                n24.Show();
                n25.Hide();
               #endregion
            }
        }


        private void NonRandom_Load(object sender, EventArgs e)
        {
            #region 
            n1.Hide();
            n2.Hide();
            n3.Hide();
            n4.Hide();
            n5.Hide();
            n6.Hide();
            n7.Hide();
            n8.Hide();
            n9.Hide();
            n10.Hide();
            n11.Hide();
            n12.Hide();
            n13.Hide();
            n14.Hide();
            n15.Hide();
            n16.Hide();
            n17.Hide();
            n18.Hide();
            n19.Hide();
            n20.Hide();
            n21.Hide();
            n22.Hide();
            n23.Hide();
            n24.Hide();
            n25.Hide();
           #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int satir = Int32.Parse(numericUpDown1.Text);
            int sutun = Int32.Parse(numericUpDown3.Text);
            double[,] matris = new double[satir, sutun];
            if (satir == 1 && sutun == 2)
            {
                matris[0,0] = Double.Parse(n1.Text);
                matris[0, 1] = Double.Parse(n2.Text);
            }
            else if (satir == 1 && sutun == 3)
            {
                matris[0, 0] = Double.Parse(n1.Text);
                matris[0, 1] = Double.Parse(n2.Text);
                matris[0,2]= Double.Parse(n3.Text);

            }
            else if (satir == 1 && sutun == 4)
            {
                matris[0, 0] = Double.Parse(n1.Text);
                matris[0, 1] = Double.Parse(n2.Text);
                matris[0, 2] = Double.Parse(n3.Text);
                matris[0, 3] = Double.Parse(n4.Text);
                

            }
            else if (satir == 1 && sutun == 5)
            {
                matris[0, 0] = Double.Parse(n1.Text);
                matris[0, 1] = Double.Parse(n2.Text);
                matris[0, 2] = Double.Parse(n3.Text);
                matris[0, 3] = Double.Parse(n4.Text);
                matris[0, 4] = Double.Parse(n5.Text);
                

            }
            else if (satir == 2 && sutun == 1)
            {
                matris[0, 0] = Double.Parse(n1.Text);
                matris[0, 1] = Double.Parse(n2.Text);
                matris[0, 2] = Double.Parse(n3.Text);
                matris[0, 3] = Double.Parse(n4.Text);
                matris[0, 4] = Double.Parse(n5.Text);
            }
            else if (satir == 2 && sutun == 3)
            {
               

            }
            else if (satir == 2 && sutun == 4)
            {
               


            }
            else if (satir == 2 && sutun == 5)
            {
              

            }
            else if (satir == 3 && sutun == 1)
            {
                
            }
            else if (satir == 3 && sutun == 2)
            {
                

            }
            else if (satir == 3 && sutun == 4)
            {
                


            }
            else if (satir == 3 && sutun == 5)
            {
                

            }
            else if (satir == 4 && sutun == 1)
            {
            }
            else if (satir == 4 && sutun == 2)
            {
               

            }
            else if (satir == 4 && sutun == 3)
            {
               

            }
            else if (satir == 4 && sutun == 5)
            {
              

            }
            else if (satir == 5 && sutun == 1)
            {
               
            }
            else if (satir == 5 && sutun == 2)
            {
                

            }
            else if (satir == 5 && sutun == 3)
            {
              

            }
            else if (satir == 5 && sutun == 4)
            {
                
            }
            
        }
    }
}
 