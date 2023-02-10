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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnFill1_Click(object sender, EventArgs e)
        {
            cursRabDataSet.DataTable1.Clear();
            int year = Convert.ToInt32(textYEAR.Text);
            foreach (CursRabDataSet.SUB_TIONRow sRow in cursRabDataSet.SUB_TION.Rows)
            {
                if ((sRow.DATE_SUBTION >= Convert.ToDateTime("01.01." + year)) && (sRow.DATE_SUBTION <= Convert.ToDateTime("31.12." + year)))
                {
                    foreach (CursRabDataSet.EDITIONRow eRow in cursRabDataSet.EDITION.Rows)
                    {
                        if (eRow.TYPE_ED == "журнал")
                        {
                            if (eRow.PUBLIC_CODE == sRow.PUBLIC_CODE)
                            {
                                foreach (CursRabDataSet.SUB_BERSRow rRow in cursRabDataSet.SUB_BERS.Rows)
                                {
                                    if (rRow.SUBERS_CODE == sRow.SUBERS_CODE)
                                    {
                                        CursRabDataSet.DataTable1Row zRow = cursRabDataSet.DataTable1.NewDataTable1Row();
                                        zRow.FIO = rRow.FIO;
                                        zRow.ZIP_CODE = rRow.ZIP_CODE;
                                        zRow.ADRESS = rRow.ADRESS;
                                        zRow.NAME_ED = eRow.NAME_ED;
                                        zRow.DATE_SUBTION = sRow.DATE_SUBTION;
                                        cursRabDataSet.DataTable1.AddDataTable1Row(zRow);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через двойной цикл";
        }

        private void btnFill2_Click(object sender, EventArgs e)
        {
            cursRabDataSet.DataTable1.Clear();
            int year = Convert.ToInt32(textYEAR.Text);
            foreach (CursRabDataSet.SUB_TIONRow sRow in cursRabDataSet.SUB_TION.Rows)
            {
                if ((sRow.DATE_SUBTION >= Convert.ToDateTime("01.01." + year)) && (sRow.DATE_SUBTION <= Convert.ToDateTime("31.12." + year)))
                {
                    CursRabDataSet.EDITIONRow eRow = cursRabDataSet.EDITION.Rows.Find(sRow.PUBLIC_CODE) as CursRabDataSet.EDITIONRow;
                    CursRabDataSet.SUB_BERSRow rRow = cursRabDataSet.SUB_BERS.Rows.Find(sRow.SUBERS_CODE) as CursRabDataSet.SUB_BERSRow;
                    if (eRow.TYPE_ED == "журнал")
                    {
                        CursRabDataSet.DataTable1Row zRow = cursRabDataSet.DataTable1.NewDataTable1Row();
                        zRow.FIO = rRow.FIO;
                        zRow.ZIP_CODE = rRow.ZIP_CODE;
                        zRow.ADRESS = rRow.ADRESS;
                        zRow.NAME_ED = eRow.NAME_ED;
                        zRow.DATE_SUBTION = sRow.DATE_SUBTION;
                        cursRabDataSet.DataTable1.AddDataTable1Row(zRow);
                    }
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через поиск по ключу";
        }

        private void btnFill3_Click(object sender, EventArgs e)
        {
            cursRabDataSet.DataTable1.Clear();
            int year = Convert.ToInt32(textYEAR.Text);
            foreach (CursRabDataSet.SUB_TIONRow sRow in cursRabDataSet.SUB_TION.Rows)
            {
                if ((sRow.DATE_SUBTION >= Convert.ToDateTime("01.01." + year)) && (sRow.DATE_SUBTION <= Convert.ToDateTime("31.12." + year)))
                {
                    CursRabDataSet.EDITIONRow eRow = sRow.GetParentRow("FK_EDITION") as CursRabDataSet.EDITIONRow;
                    CursRabDataSet.SUB_BERSRow rRow = sRow.GetParentRow("FK_SUBERS") as CursRabDataSet.SUB_BERSRow;
                    if (eRow.TYPE_ED == "журнал")
                    {
                        CursRabDataSet.DataTable1Row zRow = cursRabDataSet.DataTable1.NewDataTable1Row();
                        zRow.FIO = rRow.FIO;
                        zRow.ZIP_CODE = rRow.ZIP_CODE;
                        zRow.ADRESS = rRow.ADRESS;
                        zRow.NAME_ED = eRow.NAME_ED;
                        zRow.DATE_SUBTION = sRow.DATE_SUBTION;
                        cursRabDataSet.DataTable1.AddDataTable1Row(zRow);
                    }
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через DataRelation";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
