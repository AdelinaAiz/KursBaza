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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            this.Text = "TableAdapter";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFill1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textYEAR.Text);
            this.dataTable1TableAdapter.Fill(cursRabDataSet.DataTable1, year);
        }

        private void textYEAR_TextChanged(object sender, EventArgs e) { }
    }
}
