namespace MyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyTree<int> tree = new MyTree<int>();
        private void outputRefresh()
        {
            outputTextBox.Clear();
            foreach (int item in tree)
            {
                outputTextBox.Text += $"|{item}| ";
            }
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Insert(Convert.ToInt32(insertTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void containsButton_Click(object sender, EventArgs e)
        {
            try
            {
                containsLabel.Text = "";
                if (tree.Contains(Convert.ToInt32(containsTextBox.Text)))
                    containsLabel.Text = $"Дерево содержит - {containsTextBox.Text}";
                else
                    containsLabel.Text = $"Дерево не содержит - {containsTextBox.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Delete(Convert.ToInt32(deleteTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void CLRButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            foreach (var item in tree.CLR())
            {
                outputTextBox.Text += $"|{item.value}| ";
            }
        }

        private void LCRButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            foreach (var item in tree.LCR())//ашипка
            {
                outputTextBox.Text += $"|{item.value}| ";
            }
        }

        private void RCLButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            foreach (var item in tree.RCL())
            {
                outputTextBox.Text += $"|{item.value}| ";
            }
        }

        private void acrossButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            foreach (var item in tree.Across())
            {
                outputTextBox.Text += $"|{item.value}| ";
            }
        }
    }
}