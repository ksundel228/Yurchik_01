using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка "Проверить палиндром"
        private void btnCheckPalindrome_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                label1.Text = "Выберите строку!";
                return;
            }

            string input = listBox1.Items[index].ToString();
            string cleaned = new string(input.Where(c => char.IsLetter(c)).ToArray()).ToLower();
            bool isPalindrome = cleaned.SequenceEqual(cleaned.Reverse());

            label1.Text = isPalindrome ? "Это палиндром!" : "Не палиндром!";
        }
    }
}
