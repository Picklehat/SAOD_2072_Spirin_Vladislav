using System.Collections;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MyHashTable
{
    public partial class Form1 : Form
    {
        MyHashTable<string, int> hashtable = new MyHashTable<string, int>();

        private void hashDataRefresh()
        {
            outputListBox.Items.Clear();
            foreach (var item in hashtable)
            {
                outputListBox.Items.Add($"| Key = {item.Key}, Value = {item.Value}, Hash = {item.Hash}|");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                hashtable.Add(addKeyTextBox.Text, Convert.ToInt32(addValueTextBox.Text));
                hashDataRefresh();
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
                label5.Text = "";
                label5.Text = hashtable.Find(findKeyTextBox.Text).ToString();
                hashDataRefresh();
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
                hashtable.Delete(deleteKeyTextBox.Text);
                hashDataRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}