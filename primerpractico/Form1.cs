namespace primerpractico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Form2 form2 = new Form2();

            // Mostrar el segundo formulario
            form2.Show();

            // Opcional: Ocultar el formulario actual si deseas que no sea visible despu�s de hacer clic en el bot�n
            this.Hide();
        }
    }
}