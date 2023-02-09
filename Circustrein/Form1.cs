using Circusclasses;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {    
            if (textBox1.Text == "")
            {
                Animal animal = new Animal((Circusclasses.Size)Enum.Parse(typeof(Circusclasses.Size), comboBox1.SelectedItem.ToString()),
                         (Circusclasses.Type)Enum.Parse(typeof(Circusclasses.Type), comboBox2.SelectedItem.ToString()));
                animal.IncrementAnimal();
                listBox1.Items.Add(animal);
            } else
            {
                Animal animal = new Animal(textBox1.Text, (Circusclasses.Size)Enum.Parse(typeof(Circusclasses.Size), comboBox1.SelectedItem.ToString()),
                         (Circusclasses.Type)Enum.Parse(typeof(Circusclasses.Type), comboBox2.SelectedItem.ToString()));

                listBox1.Items.Add(animal);
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}