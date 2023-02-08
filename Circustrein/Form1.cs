using Circusclasses;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Animal animal = new Animal(Circusclasses.Size.medium, Circusclasses.Type.Carnivore);
            label1.Text = animal.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}