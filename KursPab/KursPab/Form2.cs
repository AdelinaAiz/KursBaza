using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursPab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            dataGridView1.AutoGenerateColumns = true;
            this.Text = "Альтернативная форма";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void btnSUB_BERS_Click(object sender, EventArgs e)
        {
            if (LabelName.Text != "Подписчики")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = sUBBERSBindingSource;
                bindingNavigator1.BindingSource = sUBBERSBindingSource;
                LabelName.Text = "Подписчики";
            }
        }

        private void btnEDITION_Click(object sender, EventArgs e)
        {
            if (LabelName.Text != "Товары")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = eDITIONBindingSource;
                bindingNavigator1.BindingSource = eDITIONBindingSource;
                LabelName.Text = "Товары";
            }
        }

        private void btnSUB_TION_Click(object sender, EventArgs e)
        {
            if (LabelName.Text != "Подписки")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = sUBTIONBindingSource;
                bindingNavigator1.BindingSource = sUBTIONBindingSource;
                LabelName.Text = "Подписки";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.sUB_TIONTableAdapter.Update(this.cursRabDataSet.SUB_TION);
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            this.eDITIONTableAdapter.Update(this.cursRabDataSet.EDITION);
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            MessageBox.Show("Изменения сохранены");
        }
    }
}
