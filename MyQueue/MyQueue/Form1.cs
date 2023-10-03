using System.Collections;
using System.Collections.Generic;

namespace MyQueue
{
    public partial class Form1 : Form
    {
        MyQueue<int> queue;

        private void ShowStack()
        {
            int[] values = queue.ToArray();
            outputListBox.Items.Clear();
            for (int i = values.Length; 0 < i; i--)
                outputListBox.Items.Add(values[(i - 1)].ToString() + "\n");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateQueueButton_Click(object sender, EventArgs e)
        {
            try
            {
                queue = new MyQueue<int>(Convert.ToInt32(queueSizeTextBox.Text));
                ShowStack();
            }
            catch 
            {
                MessageBox.Show("Некорректный размер очереди");
            }
        }

        private void pushItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Enqueue(Convert.ToInt32(pushItemTextBox.Text));
                ShowStack();
                peekItemListBox.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Что то пошло не так");
            }
        }

        private void popItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                popItemListBox.Items.Clear();
                popItemListBox.Items.Add(queue.Dequeue());
                ShowStack();
                peekItemListBox.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Что то пошло не так");
            }
        }

        private void peekItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                peekItemListBox.Items.Clear();
                peekItemListBox.Items.Add(queue.Peek().ToString());
            }
            catch
            {
                MessageBox.Show("Что то пошло не так");
            }
        }
    }
}