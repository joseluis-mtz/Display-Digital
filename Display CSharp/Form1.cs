using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo para desactivar todos los botones
        public void numerosInactivos()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        // Metodo para activar todos los botones
        public void numerosActivos()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        // Mostrar cada uno de los números
        public void ver0()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = false;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
        }
        public void ver1()
        {
            lbl1.Visible = false;
            lbl2.Visible = true;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = false;
        }
        public void ver2()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = true;
            lbl7.Visible = true;
        }
        public void ver3()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = false;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = false;
        }
        public void ver4()
        {
            lbl1.Visible = false;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = false;
        }
        public void ver5()
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = false;
        }
        public void ver6()
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
        }
        public void ver7()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = false;
        }
        public void ver8()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
        }
        public void ver9()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
            lbl7.Visible = false;
        }
        // Al arrancar la aplicación se desactivan los botones de los números
        private void Form1_Load(object sender, EventArgs e)
        {
            numerosInactivos();
        }

        // Creo una variables para ver numeros pares e impares y así activar o desactivar los controles
        private int numero = 0;
        private void btnOn_Click(object sender, EventArgs e)
        {
            // Algoritmo para determinar pares e impares
            numero = numero + 1;
            if (numero % 2 == 0)
            {
                btnOnDos.Enabled = true;
                txtNum.Enabled = true;
                numerosInactivos();
            }
            else
            {
                btnOnDos.Enabled = false;
                txtNum.Enabled = false;
                numerosActivos();
            }
        }

        // Se muestra el número al presionar el botón
        private void btn0_Click(object sender, EventArgs e)
        {
            ver0();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ver1();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ver2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ver3();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ver4();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ver5();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ver6();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ver7();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ver8();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ver9();
        }

        // Se valida la caja de texto
        public bool validar()
        {
            // Se establece como falso el resultado
            bool resultado = false;
            // Se revisa que solo se presionen teclas del 0 al 9
            if (txtNum.Text == "0" || txtNum.Text == "1" || txtNum.Text == "2" || txtNum.Text == "3" || txtNum.Text == "4" || txtNum.Text == "5" || txtNum.Text == "6" || txtNum.Text == "7" || txtNum.Text == "8" || txtNum.Text == "9")
            {
                // Si se presiona alguno de esos numeros se establece verdadero el resultado
                resultado = true;
            }
            else
            {
                // Si NO se presiona uno de los numeros se limpia la caja y se muestra el 0
                txtNum.Clear();
                ver0();
            }
            // Se retorna el resultado
            return resultado;
        }
        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            // Se valida la información
            if (validar())
            {
                try
                {
                    // Se obtiene el valor y se compara en el switch para mostrar el número
                    int valor = int.Parse(txtNum.Text);
                    switch (valor)
                    {
                        case 0:
                            ver0();
                            break;
                        case 1:
                            ver1();
                            break;
                        case 2:
                            ver2();
                            break;
                        case 3:
                            ver3();
                            break;
                        case 4:
                            ver4();
                            break;
                        case 5:
                            ver5();
                            break;
                        case 6:
                            ver6();
                            break;
                        case 7:
                            ver7();
                            break;
                        case 8:
                            ver8();
                            break;
                        case 9:
                            ver9();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    ver0();
                    txtNum.Clear();
                }
            }
        }
        // Se comienza el temporizador para mostrar los numeros
        private void btnOnDos_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // Se define el valor del timer
        int timerValor = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Se agrega el valor de intervalo al valor del timer
            timerValor += timer1.Interval;
            // Se compara que no supere el valor final del último dígito para mostrar cada número
            if (timerValor <= 4500)
            {
                // Se compara el valor  y se muestra el numero correspondiente
                switch (timerValor)
                {
                    case 0:
                        ver0();
                        break;
                    case 500:
                        ver1();
                        break;
                    case 1000:
                        ver2();
                        break;
                    case 1500:
                        ver3();
                        break;
                    case 2000:
                        ver4();
                        break;
                    case 2500:
                        ver5();
                        break;
                    case 3000:
                        ver6();
                        break;
                    case 3500:
                        ver7();
                        break;
                    case 4000:
                        ver8();
                        break;
                    case 4500:
                        ver9();
                        break;
                }
            }
            // Si el valor excede el del último dígito se resetea todo, timer, valor y se muestra el 0
            else
            {
                timer1.Dispose();
                timerValor = 0;
                ver0();
            }
        }

        // Termina la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
