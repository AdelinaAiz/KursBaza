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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int g = 0, kod = -1, j = 0;
            cursRabDataSet.SUB_BERS2.Clear();
            CursRabDataSet.SUB_BERS2Row zRow = null;
            foreach (CursRabDataSet.SUB_TIONRow rRow in cursRabDataSet.SUB_TION.Rows)
            {
                if (rRow.DATE_SUBTION.Year.ToString() == Convert.ToString(textBox1.Text))
                {

                    CursRabDataSet.EDITIONRow tRow = cursRabDataSet.EDITION.Rows.Find(rRow.PUBLIC_CODE) as CursRabDataSet.EDITIONRow;
                    CursRabDataSet.SUB_BERSRow oRow = cursRabDataSet.SUB_BERS.Rows.Find(rRow.SUBERS_CODE) as CursRabDataSet.SUB_BERSRow;
                    
                    if (zRow == null)
                    {
                        kod = rRow.SUBERS_CODE;
                        if (tRow.TYPE_ED == "журнал")
                            j = 1;
                        if (tRow.TYPE_ED == "газета")
                            g = 1;
                        zRow = cursRabDataSet.SUB_BERS2.NewSUB_BERS2Row();
                    }
                    else 
                        if (kod == rRow.SUBERS_CODE)
                        {
                            if (tRow.TYPE_ED == "журнал")
                                j++;
                            if (tRow.TYPE_ED == "газета")
                                g++;
                        }

                        else
                        {
                         
                            zRow.FIO = cursRabDataSet.SUB_BERS.FindBySUBERS_CODE(kod).FIO;
                            zRow.COUNT_M = j;
                            zRow.COUNT_N = g;
                            cursRabDataSet.SUB_BERS2.Rows.Add(zRow);
                            kod = rRow.SUBERS_CODE;//подготовливаем новую строку
                            if (tRow.TYPE_ED == "журнал")
                            { j = 1; g = 0; }
                            if (tRow.TYPE_ED == "газета")
                            { g = 1; j = 0; }
                            zRow = cursRabDataSet.SUB_BERS2.NewSUB_BERS2Row();

                    }
                }
            }
            if (zRow != null)
            {
                //создали новую строку таблицы «Zadacha1»
                zRow.COUNT_M = j;
                zRow.COUNT_N = g;
                zRow.FIO = cursRabDataSet.SUB_BERS.FindBySUBERS_CODE(kod).FIO;
                cursRabDataSet.SUB_BERS2.Rows.Add(zRow);
                dataGridView2.Refresh();
                this.Text = "Запрос через поиск по ключу";
            }
        }
    

    
    /*
            int g = 0, kod = -1, j = 0;
            cursRabDataSet.SUB_BERS2.Clear();
            foreach (CursRabDataSet.SUB_BERSRow sRow in cursRabDataSet.SUB_BERS.Rows)
            {
                foreach (CursRabDataSet.SUB_TIONRow tRow in cursRabDataSet.SUB_TION.Rows)
                {
                        if (sRow.SUBERS_CODE == tRow.SUBERS_CODE)
                        {
                        CursRabDataSet.EDITIONRow eRow = cursRabDataSet.EDITION.Rows.Find(tRow.PUBLIC_CODE) as CursRabDataSet.EDITIONRow;
                        if (eRow.TYPE_ED == "журнал")
                        {
                            j++;
                        }
                        if (eRow.TYPE_ED == "газета")
                        {
                            g++;
                        }
                    }
                }
                CursRabDataSet.SUB_BERS2Row zRow = cursRabDataSet.SUB_BERS2.NewSUB_BERS2Row();
                zRow.FIO = sRow.FIO;
                zRow.COUNT_M = j;
                zRow.COUNT_N = g;
                cursRabDataSet.SUB_BERS2.Rows.Add(zRow);
                dataGridView2.Refresh();
                this.Text = "Запрос через поиск по ключу";
            }
        }
        */
    }
}   


