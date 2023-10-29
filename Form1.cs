namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.BackColor = Color.Gray;
            button1.Text = "Рассчитать";
            button1.BackColor = Color.Green;
            textBox1.BackColor = Color.Bisque;
            textBox2.BackColor = Color.Bisque;
            textBox3.BackColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = Convert.ToDouble(textBox1.Text);
                double side2 = Convert.ToDouble(textBox2.Text);
                double side3 = Convert.ToDouble(textBox3.Text);
                if (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2)
                {
                    if (side1 == side2 && side2 == side3 && side1 == side3)
                    {
                        MessageBox.Show("Треугольник равносторонний");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        MessageBox.Show("Треугольник равнобедренный");
                    }
                    else
                    {
                        MessageBox.Show("Треугольник разносторонний");
                    }
                }
                else
                {
                    MessageBox.Show("Треугольника не существует");
                }


                
            }
            catch
            {
                MessageBox.Show(
                    "Введите значения сторон треугольника"
                    ); 
            }
            
        }
    }
}