using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string parcela1, parcela2;
        private double result;
        private bool par1_ok, par2_ok,soma,div,sub,mult,porc,raz,exp;
        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "1";

            }
            else if (!par2_ok)
            {
                parcela2 += "1";

            }

        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "2";

            }
            else if (!par2_ok)
            {
                parcela2 += "2";

            }

        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "3";

            }
            else if (!par2_ok)
            {
                parcela2 += "3";

            }

        }
        private void n4_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "4";

            }
            else if (!par2_ok)
            {
                parcela2 += "4";

            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "5";

            }
            else if (!par2_ok)
            {
                parcela2 += "5";

            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "6";

            }
            else if (!par2_ok)
            {
                parcela2 += "6";

            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "7";

            }
            else if (!par2_ok)
            {
                parcela2 += "7";

            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "8";

            }
            else if (!par2_ok)
            {
                parcela2 += "8";

            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "9";

            }
            else if (!par2_ok)
            {
                parcela2 += "9";

            }
        }
        private void b0_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "0";

            }
            else if (!par2_ok)
            {
                parcela2 += "0";

            }
        }
        private void b00_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                parcela1 += "00";

            }
            else if (!par2_ok)
            {
                parcela2 += "00";

            }
        }

        private void bSoma_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                par1_ok = true;
                soma = true;
            }
            else if (par1_ok && !par2_ok&& parcela2 != "")
            {
               
                par2_ok = true;
                result = Convert.ToDouble(parcela1) + Convert.ToDouble(parcela2);
                
            }
            else if (par1_ok&& par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                soma = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                label1.Text = parcela1;
            }
            else if (!par2_ok)
            {
                label1.Text = parcela2;
            }
            else if (par1_ok&&par2_ok)
            {
                label1.Text = result.ToString();
            }
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            par1_ok = false;
            par2_ok = false;
            parcela1 = "";
            parcela2 = "";
            result = 0;

        }

        

        private void ponto_Click(object sender, EventArgs e)
        {
            
            if (!par1_ok)
            {
                parcela1 += ",";

            }
            else if (!par2_ok)
            {
                parcela2 += ",";

            }
        }

        private void igual_Click(object sender, EventArgs e)
        {

             if (par1_ok && !par2_ok&& parcela2 != "")
            {
                par2_ok = true;
                
                if (soma) {result = Convert.ToDouble(parcela1) + Convert.ToDouble(parcela2); 
                    soma = false ;
                    
                }
                else if (sub){ result = Convert.ToDouble(parcela1) - Convert.ToDouble(parcela2);
                 sub = false ; 
                   
                 }
                else if (mult) { result = Convert.ToDouble(parcela1) * Convert.ToDouble(parcela2);
                mult = false; 
                }
                else if (div)
                {
                    result = Convert.ToDouble(parcela1) / Convert.ToDouble(parcela2);
                    div = false;
                }
                else if (porc)
                {
                    result = Convert.ToDouble(parcela1) * Convert.ToDouble(parcela2);
                    porc = false;
                }
                else if (exp)
                {
                    result = (Math.Pow(Convert.ToDouble(parcela1), Convert.ToDouble(parcela2)));
                    exp = false;
                }
                                
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                par1_ok = true;
                sub = true; 
            }
            else if (par1_ok && !par2_ok && parcela2 != "")
            {
                par2_ok = true;
                result = (Convert.ToDouble(parcela1) - Convert.ToDouble(parcela2));
                

            }
            else if (par1_ok && par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                sub = true;
            }
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                par1_ok = true;
                mult= true;
            }
            else if (par1_ok && !par2_ok && parcela2 != "")
            {
                par2_ok = true;
                result = (Convert.ToDouble(parcela1) * Convert.ToDouble(parcela2));


            }
            else if (par1_ok && par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                mult = true;
            }
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                par1_ok = true;
                div= true;
            }
            else if (par1_ok && !par2_ok && parcela2 != "")
            {
                par2_ok = true;
                result = (Convert.ToDouble(parcela1) / Convert.ToDouble(parcela2));


            }
            else if (par1_ok && par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                div = true;
            }
        }

        private void Porcentage_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                double temp;
                par1_ok = true;
                porc= true;
                temp = Convert.ToDouble(parcela1) / 100;
                parcela1 = temp.ToString();
            }
            else if (par1_ok && !par2_ok && parcela2 != "")
            {
                par2_ok = true;
                result = (Convert.ToDouble(parcela1) * Convert.ToDouble(parcela2));


            }
            else if (par1_ok && par2_ok)
            {
                double tmp;
                parcela1 = result.ToString();
                tmp = Convert.ToDouble(parcela1) / 100;
                parcela1 = tmp.ToString();
                parcela2 = "";
                par2_ok = false;
                porc = true;
            }
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            if (!par1_ok) parcela1 = "";
            else if (!par2_ok) parcela2 = "";
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (parcela1!="")
            {
                if (result != 0) parcela1 = result.ToString();
                par1_ok = true;
                raz= true;
                par2_ok= true ;
                result = Math.Sqrt(Convert.ToDouble(parcela1));
            }
          
            else if (par1_ok && par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                raz= true;
            }

        }

        private void expo_Click(object sender, EventArgs e)
        {
            if (!par1_ok)
            {
                par1_ok = true;
                exp = true;
            }
            else if (par1_ok && !par2_ok && parcela2 != "")
            {
                par2_ok = true;
                result = (Math.Pow(Convert.ToDouble(parcela1),Convert.ToDouble(parcela2)));


            }
            else if (par1_ok && par2_ok)
            {
                parcela1 = result.ToString();
                parcela2 = "";
                par2_ok = false;
                exp = true;
            }
        }

        

        

       

       
    }
}
