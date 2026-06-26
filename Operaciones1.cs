using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AireTour
{
    internal class Operaciones1
    {
        Form2 formulario = new Form2();
        Resultados rsl = new Resultados();
        public void Datos()
        {
             
        }

        public void Datos2(string Ids, string Nmb, string Apll, Boolean Gen, Boolean Gen2, string Est,string dia, 
            string dstn, string clse)
        {

            rsl.ID.Text = Ids;
            rsl.Nmb.Text = Nmb;
            rsl.Apll.Text = Apll;
            if (Gen == true)
            {
                rsl.Gen.Text = "FEMENINO";
            }
            if (Gen2 == true)
            {
                rsl.Gen.Text = "MASCULINO";
            }
            rsl.Est.Text = Est;
            rsl.Dstn.Text = dstn;
            rsl.Dia1.Text = dia;
            rsl.Cls.Text=clse;
            switch (dstn) {
                case "BOGOTA":
                    switch (clse)
                    {
                        case "CLASE A":
                            rsl.Costo1.Text = "$ 300.000";
                            break;
                        case "CLASE B":
                            rsl.Costo1.Text = "$ 225.000";
                            break;
                        case "CLASE C":
                            rsl.Costo1.Text = "$ 150.000";
                            break;
                    }
                 break;
                case "MEDELLIN":
                    switch (clse) {
                        case "CLASE A":
                            rsl.Costo1.Text = "$ 420.000";
                            break;
                        case "CLASE B":
                            rsl.Costo1.Text = "$ 315.000";
                            break;
                        case "CLASE C":
                            rsl.Costo1.Text = "$ 125.000";
                            break;
                    }
                    break;
            }
            rsl.Show();

        }
        
            
        
    

    }
}
