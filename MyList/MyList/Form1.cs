using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace MyList
{
    public partial class Form1 : Form
    {
        MyList<int> myList;
        private void showList()
        {
            outputListBox.Items.Clear();
            foreach (int item in myList)
                outputListBox.Items.Add(item.ToString());
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList = new MyList<int>();
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void appendItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.Append(Convert.ToInt32(appendItemTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void prependItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.Prepend(Convert.ToInt32(prependItemTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchResultListBox.Items.Clear();
                searchResultListBox.Items.Add(myList.Find(Convert.ToInt32(findTextBox.Text)));
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
                containsListBox.Items.Clear();
                if (myList.Contains(Convert.ToInt32(containsTextBox.Text)))
                    containsListBox.Items.Add("Да");
                else
                    containsListBox.Items.Add("Нет");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void setValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.SetValue(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(indexTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void atButton_Click(object sender, EventArgs e)
        {
            try
            {
                atListBox.Items.Clear();
                atListBox.Items.Add(myList.At(Convert.ToInt32(atTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void removeAtButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.RemoveAt(Convert.ToInt32(removeAtTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.Remove(Convert.ToInt32(removeTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                myList.Insert(Convert.ToInt32(insertIndexTextBox.Text), Convert.ToInt32(insertValueTextBox.Text));
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}