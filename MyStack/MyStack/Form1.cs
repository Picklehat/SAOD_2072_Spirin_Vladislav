namespace MyStack
{
    public partial class Form1 : Form
    {
        MyStack<int> stack;

        private void ShowStack()
        {
            int[] values = stack.Values();
            outputListBox.Items.Clear();
            for (int i = values.Length; 0 < i; i--)
                outputListBox.Items.Add(values[(i - 1)].ToString() + "\n");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateStackButton_Click(object sender, EventArgs e)
        {
            try
            {
                stack = new MyStack<int>(Convert.ToInt32(stackSizeTextBox.Text));
                ShowStack();
            }
            catch
            {
                MessageBox.Show("������������ ������ �����");            
            }
        }

        private void pushItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(Convert.ToInt32(pushItemTextBox.Text));
                ShowStack();
                peekItemListBox.Items.Clear();
            }
            catch
            {
                MessageBox.Show("��� �� ����� �� ���");
            }
        }

        private void popItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                popItemListBox.Items.Clear();
                popItemListBox.Items.Add(stack.Pop());
                ShowStack();
                peekItemListBox.Items.Clear();
            }
            catch
            {
                MessageBox.Show("��� �� ����� �� ���");
            }
        }

        private void peekItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                peekItemListBox.Items.Clear();
                peekItemListBox.Items.Add(stack.Peek().ToString());
            }
            catch
            {
                MessageBox.Show("��� �� ����� �� ���");
            }
        }
    }
}