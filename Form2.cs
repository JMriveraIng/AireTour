using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AireTour
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Convierte de ingles a español el dia seleccionado en el component dateTimePciker

            string date = dateTimePicker1.Value.DayOfWeek.ToString();
            switch (date)
            {
                case "Monday":
                    label9.Text = "LUNES";
               
                    break;
                case "Tuesday":
                    label9.Text = "MARTES";
                  
                    break;
                case "Wednesday":
                    label9.Text = "MIERCOLES";
                   
                    break;
                case "Thursday":
                    label9.Text = "JUEVES";
              
                    break;
                case "Friday":
                    label9.Text = "VIERNES";
                    
                    break;
                case "Saturday":
                    label9.Text = "SABADO";
                 
                    break;
                case "Sunday":
                    label9.Text = "DOMINGO";
                 
                    break;
                default:
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones1 opr= new Operaciones1();
            opr.Datos2(textBox1.Text.ToString(),
                textBox2.Text.ToString(), Apellidos.Text.ToString(),
                radioButton1.Checked, radioButton2.Checked, comboBox1.Text,label9.Text.ToString(),
                comboBox2.Text.ToString(),comboBox3.Text.ToString()
                );
           
            //rsl.ID.Text = textBox1.Text.ToString();
            //rsl.Nmb.Text = textBox2.Text.ToString();
            //rsl.Apll.Text = Apellidos.Text.ToString();
            ////-----------------------------------------
            //if (radioButton1.Checked == true) {
            //    rsl.Gen.Text = "FEMENINO";
            //}
            //if (radioButton2.Checked == true)
            //{
            //   rsl.Gen.Text = "MASCULINO";
            //}
            ////-----------------------------------------
            //rsl.Est.Text= comboBox1.Text.ToString();
            //rsl.Dstn.Text = comboBox2.Text.ToString();
            //rsl.Dia1.Text = label9.Text.ToString();
            ////-----------------------------------------
            //if (radioButton3.Checked == true) {
            //    rsl.Cls.Text = "CLASE A";
            //}
            //if (radioButton4.Checked == true)
            //{
            //    rsl.Cls.Text = "CLASE B";
            //}
            //if (radioButton4.Checked == true)
            //{
            //    rsl.Cls.Text = "CLASE C";
            //}
            ////-----------------------------------------
            //if (rsl.Dstn.Text == "BOGOTA" && rsl.Cls.Text == "CLASE A") 
            //{
            //          int valor = 300000;
            //          string costo = Convert.ToString(valor);
            //          rsl.Sub.Text = "$"+costo;
            //}
            //if (rsl.Dstn.Text == "BOGOTA" && rsl.Cls.Text == "CLASE B")
            //{
            //    int valor = 225000;
            //    string costo = Convert.ToString(valor);
            //    rsl.Sub.Text = "$" + costo;
            //}
            //if (rsl.Dstn.Text == "BOGOTA" && rsl.Cls.Text == "CLASE C")
            //{
            //    int valor = 225000;
            //    string costo = Convert.ToString(valor);
            //    rsl.Sub.Text = "$" + costo;
            //}

       

           
        }

      
    }
}
