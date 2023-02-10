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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            this.Text = "Запрос через тройной цикл";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cursRabDataSet.SUB_BERS1.Clear();
            int year = Convert.ToInt32(textYEAR.Text);
            bool aE, eS;
            int max = 0;
            int col = 0;
            foreach (CursRabDataSet.EDITIONRow eRow in cursRabDataSet.EDITION.Rows)
            {
                if (eRow.TYPE_ED == "газета") max++;
            }
            foreach (CursRabDataSet.SUB_BERSRow rRow in cursRabDataSet.SUB_BERS.Rows)
            {
                aE = true; //не любой журнал
                foreach (CursRabDataSet.EDITIONRow eRow in cursRabDataSet.EDITION.Rows)
                {
                    aE = (eRow.TYPE_ED == "газета");
                    if (aE)
                    {
                        eS = false;
                        foreach (CursRabDataSet.SUB_TIONRow sRow in cursRabDataSet.SUB_TION.Rows)
                        {
                            eS = ((sRow.DATE_SUBTION >= Convert.ToDateTime("01.01." + year)) && (sRow.DATE_SUBTION <= Convert.ToDateTime("31.12." + year))
                            && (eRow.PUBLIC_CODE == sRow.PUBLIC_CODE) && (rRow.SUBERS_CODE == sRow.SUBERS_CODE));
                            if (eS) break;
                        }
                        aE = eS;
                    }
                    if (aE) col++;
                }
                if (col != 0 && col != max)
                // if(!aE||aE&&col!=max)
                {
                    CursRabDataSet.SUB_BERS1Row zRow = cursRabDataSet.SUB_BERS1.NewSUB_BERS1Row();
                    zRow.FIO = rRow.FIO;
                    cursRabDataSet.SUB_BERS1.Rows.Add(zRow);
                    col = 0;
                }
            }
            dataGridView1.Refresh();
        
        }
    }
}
