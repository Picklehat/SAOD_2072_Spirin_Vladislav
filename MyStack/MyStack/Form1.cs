namespace MyStack
{
    public partial class Form1 : Form
    {
        MyStack<char> stack;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateStackButton_Click(object sender, EventArgs e)
        {
            try
            {
                stack = new MyStack<char>(Convert.ToInt32(stackSizeTextBox.Text));

            }
            catch
            {
                MessageBox.Show("Некорректный размер стека");            
            }
        }
    }
}