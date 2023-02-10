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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            dataGridView2.AutoGenerateColumns = true;
            this.sUB_BERS2TableAdapter.Fill(cursRabDataSet.SUB_BERS2, YEAR: 0);
            this.Text = "Запрос на основании объекта TableAdapter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            this.sUB_BERS2TableAdapter.Fill(cursRabDataSet.SUB_BERS2, year);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
