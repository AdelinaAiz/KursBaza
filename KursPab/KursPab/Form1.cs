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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_TION". При необходимости она может быть перемещена или удалена.
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.EDITION". При необходимости она может быть перемещена или удалена.
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cursRabDataSet.SUB_BERS". При необходимости она может быть перемещена или удалена.
            this.sUB_BERSTableAdapter.Fill(this.cursRabDataSet.SUB_BERS);
            this.Text = "Основная форма";
        }

        private void sUBBERSGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigator1.BindingSource = sUBBERSBindingSource;
            lblTable.Text = "Подписчики";
            this.sUBBERSGridView.DataSource = sUBBERSBindingSource;
        }

        private void eDITIONGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigator1.BindingSource = eDITIONBindingSource;
            lblTable.Text = "Издания";
            this.eDITIONGridView.DataSource = eDITIONBindingSource;
        }

        private void sUBTIONGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sUBTIONGridView.DataSource = sUBTIONBindingSource;
        //    this.eDITIONGridView.DataSource = sUBTION_EDITIONBindingSource;
        //    this.sUBBERSGridView.DataSource = sUBTION_SUBBERSBindingSource;//это обратные связи
            lblTable.Text = "Подписки";
        }

        private void sUBTIONGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (sUBTIONGridView.CurrentCell != null)
            {
                int nRow = sUBTIONGridView.CurrentCell.RowIndex;
                //первая строка                 
                if (nRow == 0)
                {
                    btnPrev.Enabled = false;
                    btnFirst.Enabled = false;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                }
                //последняя строка                 
                if (nRow == sUBTIONGridView.RowCount - 1)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Подписки";
            int nCol = sUBTIONGridView.CurrentCell.ColumnIndex;
            sUBTIONGridView.CurrentCell = sUBTIONGridView[nCol, 0];
            btnPrev.Enabled = btnFirst.Enabled = false;
            btnLast.Enabled = btnNext.Enabled = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Подписки";
            int nCol = sUBTIONGridView.CurrentCell.ColumnIndex;
            sUBTIONGridView.CurrentCell = sUBTIONGridView[nCol, sUBTIONGridView.RowCount - 2];
            btnPrev.Enabled = btnFirst.Enabled = true;
            btnLast.Enabled = btnNext.Enabled = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Подписки";
            int nRow = sUBTIONGridView.CurrentCell.RowIndex;
            int nCol = sUBTIONGridView.CurrentCell.ColumnIndex;
            if (nRow > 0)
                sUBTIONGridView.CurrentCell = sUBTIONGridView[nCol, --nRow];
            if (nRow == 0)
                btnPrev.Enabled = btnFirst.Enabled = false;
            if (nRow != sUBTIONGridView.RowCount - 2)
                btnLast.Enabled = btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Подписки";
            int nRow = sUBTIONGridView.CurrentCell.RowIndex;
            int nCol = sUBTIONGridView.CurrentCell.ColumnIndex;
            if (nRow >= 0)
                sUBTIONGridView.CurrentCell = sUBTIONGridView[nCol, ++nRow];
            if (nRow != 0)
                btnPrev.Enabled = btnFirst.Enabled = true;
            if (nRow == sUBTIONGridView.RowCount - 2)
                btnLast.Enabled = btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.sUB_TIONTableAdapter.Update(this.cursRabDataSet.SUB_TION);
            this.sUB_TIONTableAdapter.Fill(this.cursRabDataSet.SUB_TION);
            this.eDITIONTableAdapter.Update(this.cursRabDataSet.EDITION);
            this.eDITIONTableAdapter.Fill(this.cursRabDataSet.EDITION);
            this.sUBTIONGridView_CurrentCellChanged(sUBTIONGridView, e);
            MessageBox.Show("Изменения сохранены");
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            this.sUB_TIONTableAdapter.Fill(cursRabDataSet.SUB_TION);
            this.sUBTIONGridView_CurrentCellChanged(sUBTIONGridView, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sUBTIONGridView.SelectedRows)
            {
                sUBTIONGridView.Rows.Remove(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = btnFirst.Enabled = true;
            btnLast.Enabled = btnNext.Enabled = false;
            sUBTIONGridView.CurrentCell = sUBTIONGridView[0, sUBTIONGridView.RowCount - 1];
        }

                private void bindingNavigator1_RefreshItems(object sender, EventArgs e){ }

        private void альтернативнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void tableAdapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void работаСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void tableAdapterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void тройнойЦиклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void tableAdapterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void подзапросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void tableAdapterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void подзапросыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }
    }
}
