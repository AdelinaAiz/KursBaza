using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursPab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

    private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            this.Text = "Совместно с БД";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.CursRabConnectionString);
            con.Open();
            int year = Convert.ToInt32(textYEAR.Text);
            String command = "SELECT DISTINCT SUB_BERS.FIO, SUB_BERS.ZIP_CODE, SUB_BERS.ADRESS, EDITION.NAME_ED, SUB_TION.DATE_SUBTION FROM SUB_BERS, EDITION, SUB_TION WHERE EDITION.PUBLIC_CODE = SUB_TION.PUBLIC_CODE AND SUB_BERS.SUBERS_CODE = SUB_TION.SUBERS_CODE AND EDITION.TYPE_ED = 'журнал'" +
                "AND YEAR(SUB_TION.DATE_SUBTION) = " + year + ';';
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }
    }
}
