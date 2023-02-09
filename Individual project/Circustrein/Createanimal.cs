using Circusclasses;

namespace Circustrein
{
    public partial class Createanimal : Form
    {
        public Createanimal()
        {
            InitializeComponent();

        }
        private bool Validation()
        {
            if (string.IsNullOrEmpty(comboBox1.Text)  )
            {
                return false;
            } else { return true; }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                return false;
            } else { return true; }
        }
        private bool CheckList()
        {
            if (listBox1.Items.Count == 0)
            {
                return false;
            } 
            else 
            { 
                return true; 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {    
            if (Validation())
            {
                if (textBox1.Text == "")
                {
                    Animal animal = new Animal((Circusclasses.Size)Enum.Parse(typeof(Circusclasses.Size), comboBox1.SelectedItem.ToString()),
                             (Circusclasses.Type)Enum.Parse(typeof(Circusclasses.Type), comboBox2.SelectedItem.ToString()));
                    animal.IncrementAnimal();
                    listBox1.Items.Add(animal);
                }
                else
                {
                    Animal animal = new Animal(textBox1.Text, (Circusclasses.Size)Enum.Parse(typeof(Circusclasses.Size), comboBox1.SelectedItem.ToString()),
                             (Circusclasses.Type)Enum.Parse(typeof(Circusclasses.Type), comboBox2.SelectedItem.ToString()));

                    listBox1.Items.Add(animal);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all choiches!, name can be blank.");
            }
                     
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckList() == true)
            {
                Form trainform = new Form();
                trainform.Show();
                this.Close();
            }
          
        }
    }
}