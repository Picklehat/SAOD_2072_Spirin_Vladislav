namespace MyVector
{
    public partial class Form1 : Form
    {
        MyVector<int> myVector;
        private void showInfo()
        {
            outputListBox.Items.Clear();
            capacityListBox.Items.Clear();
            sizeListBox.Items.Clear();

            capacityListBox.Items.Add($"Вместимость {myVector.Capacity}");
            sizeListBox.Items.Add($"Размер {myVector.Size}");
            /*for (int i = 0; i < myVector.Size; i++)
                outputListBox.Items.Add(myVector[i].ToString() + "\n");*/
            foreach (int item in myVector)
                outputListBox.Items.Add(item.ToString() + "\n");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateVectorButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector = new MyVector<int>(Convert.ToInt32(vectorSizeTextBox.Text));
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector.Add(Convert.ToInt32(addItemTextBox.Text));
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }

        private void setValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector.SetValue(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(indexTextBox.Text));
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }


        private void resizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector.Resize(Convert.ToInt32(resizeTextBox.Text));
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector.Reserve(Convert.ToInt32(reserveTextBox.Text));
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }

        private void shrinkToFitButton_Click(object sender, EventArgs e)
        {
            try
            {
                myVector.ShrinkToFit();
                showInfo();
            }
            catch
            {
                MessageBox.Show("Некорректный размер вектора");
            }
        }
    }
}