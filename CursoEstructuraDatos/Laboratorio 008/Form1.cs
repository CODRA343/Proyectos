namespace Laboratorio_008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> listaSemana;
        private void Form1_Load(object sender, EventArgs e)
        {
            listaSemana.Add("Lunes");
            listaSemana.Add("Martes");
            listaSemana.Add("Mi�rcoles");
            listaSemana.Add("Jueves");
            listaSemana.Add("Viernes");

            var martes = listaSemana[1];
            var martes1 = listaSemana.FirstOrDefault(x => x == "Martes");
            var b�squeda = listaSemana.Where(x => x.Contains("nes"));

            var cantidad = listaSemana.Count;

            MessageBox.Show(cantidad.ToString());

            listaSemana.Add("S�bado");
            listaSemana.Add("Domingo");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
