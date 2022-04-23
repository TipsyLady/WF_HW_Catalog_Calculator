using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CW_Catalog
{
    public partial class Redactor : Form
    {
        Goods goods = null;
        bool addnew;
        public Redactor(Goods _goods, bool _addnew)
        {
            InitializeComponent();
            addnew = _addnew;
            goods = _goods;
            if (addnew == false)
            {
                textBoxName.Text = _goods._name;
                textBoxCountry.Text = _goods._producer;
                textBoxPrice.Text = _goods._price.ToString();
                Text = "Редактирование товара";
            }
            else Text = "Добавление товара";

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text==" "|| textBoxCountry.Text==" " || textBoxPrice.Text==" ")
            {
                MessageBox.Show("Вы не заполнили обязательные поля", "Ошибка");
            }
            if (goods == null) goods = new Goods();
            goods._name = textBoxName.Text;
            goods._producer= textBoxCountry.Text;
            try
            {
                if (Convert.ToDouble(textBoxPrice.Text) < 0)
                {
                    MessageBox.Show("Вы неверно указали стоимость", "Ошибка");
                }
                else
                {
                    goods._price = Convert.ToDouble(textBoxPrice.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы неверно указали стоимость", "Ошибка"); 
            }
           
        }
    }
}
