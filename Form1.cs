using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF_CW_Catalog
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали элемент для удаления", "Ошибка");
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonAdd_MouseClick(object sender, MouseEventArgs e)
        {
           Goods g = new Goods();
           Redactor addform = new Redactor(g, true);
           if (addform.ShowDialog() == DialogResult.OK)
           listBox1.Items.Add(g);

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1)
                MessageBox.Show("Вы не выбрали элемент для редактирования", "Ошибка");
            else
            {
                int index = listBox1.SelectedIndex;
                Goods editG = (Goods)listBox1.SelectedItem;
                Redactor editForm = new Redactor(editG, false);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(index);
                    listBox1.Items.Insert(index, editG);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            WriteToFile(listBox1);
        }

         private void WriteToFile(ListBox listBox)
        {
            StreamWriter sw = new StreamWriter("TEST.dat");
            if (listBox.Items.Count !=0)
                {
                    foreach (var item in listBox.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    MessageBox.Show("Запись в файл прошла успешно");
                sw.Close();
                }
                else MessageBox.Show("В списке нет товаров");
            sw.Close();
        }
    }
}
