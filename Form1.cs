namespace AireTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Boton de INGRESO
        private void button1_Click(object sender, EventArgs e)
        {
            //Condicional IF para validar la contraseña 
            if (textBox1.Text == "123")
            {
                //INICIA EL SIGUIENTE FORMULARIO SI LA CONDICION SE CUMPLE
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else {
                //SI LA CONDICION NO SE CUMPLE POR FORMULARIO VACIO
                if (textBox1.Text == "")
                {
                    MessageBox.Show("INGRESE CONTRASEÑA");
                }
                else
                {
                    //SI LA CONDICION NO SE CUMPLE POR CONTRASEÑA ERRONEA
                    if (textBox1.Text != "123")
                    {
                        MessageBox.Show("CONTRASEÑA NO VALIDA");
                    }
                }
            }
        }

       
    }
}