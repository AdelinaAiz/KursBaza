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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION1". При необходимости она может быть перемещена или удалена.
            this.eDITION1TableAdapter.Fill(this.cursRabDataSet.EDITION1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            this.Text = " Запрос, содержащий подзапросы (Record)";
            dataGridView1.AutoGenerateColumns = true;
            zapr();
        }
        public void zapr()
        {
            cursRabDataSet.EDITION1.Clear();
            bool aE, eS;
            aE = false;
            foreach (CursRabDataSet.EDITIONRow eRow in cursRabDataSet.EDITION.Rows)
            {

                if (eRow.TYPE_ED == "газета")
                {
                    aE = true;
                    foreach (CursRabDataSet.SUB_BERSRow rRow in cursRabDataSet.SUB_BERS.Rows)
                    {
                        aE = (rRow.ADRESS.Contains("Казань"));
                        if (aE)
                        {
                            eS = false;
                            foreach (CursRabDataSet.SUB_TIONRow sRow in cursRabDataSet.SUB_TION.Rows)
                            {
                                eS = ((sRow.DATE_SUBTION >= Convert.ToDateTime("01.01.2015")) && (sRow.DATE_SUBTION <= Convert.ToDateTime("31.12.2015"))
                                && (eRow.PUBLIC_CODE == sRow.PUBLIC_CODE) && (rRow.SUBERS_CODE == sRow.SUBERS_CODE));
                                if (eS) break;
                            }
                            aE = eS;
                        }
                        if (!aE) break;
                    }
                    if (aE)
                    {
                        CursRabDataSet.EDITION1Row zRow = cursRabDataSet.EDITION1.NewEDITION1Row();
                        zRow.NAME_ED = eRow.NAME_ED;
                        cursRabDataSet.EDITION1.Rows.Add(zRow);
                    }
                }
            }
            dataGridView1.Refresh();
        }
    }
}
