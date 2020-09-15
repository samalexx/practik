using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.PracticaDataSetTableAdapters;

namespace практика
{
    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter.Fill(this.practicaDataSet.Факультеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.practicaDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this.practicaDataSet.Специальность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Сессия". При необходимости она может быть перемещена или удалена.
            this.сессияTableAdapter.Fill(this.practicaDataSet.Сессия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Семестровые_оценки". При необходимости она может быть перемещена или удалена.
            this.семестровые_оценкиTableAdapter.Fill(this.practicaDataSet.Семестровые_оценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Предметы". При необходимости она может быть перемещена или удалена.
            this.предметыTableAdapter.Fill(this.practicaDataSet.Предметы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.practicaDataSet.Кафедры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.practicaDataSet.Кафедры);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.practicaDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practicaDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.practicaDataSet.Группы);
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = true;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = true;
            button17.Visible = false;
            button18.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = true;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = true;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }







        private void button1_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = true;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = true;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            



        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = true;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = true;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = true;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = true;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = true;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = true;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = false;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            группыDataGridView.Visible = false;
            кафедрыDataGridView.Visible = false;
            предметыDataGridView.Visible = false;
            семестровые_оценкиDataGridView.Visible = false;
            сессияDataGridView.Visible = false;
            специальностьDataGridView.Visible = true;
            студентыDataGridView.Visible = false;
            факультетыDataGridView.Visible = false;
            button10.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = true;
            button18.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ларионов Денис vk.com/uk.kozak" + '\n' + "Билалов Артур - vk.com/ktoyaartur");
        }

        private void группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.practicaDataSet);
            
        }

        private void группыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.practicaDataSet);

        }

        private void кафедрыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void предметыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void семестровые_оценкиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void семестровые_оценкиDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сессияDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void специальностьDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void студентыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void факультетыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.practicaDataSet);



        }

        private void группыBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.practicaDataSet);

        }

        private void группыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void группыBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.practicaDataSet);

        }

        private void группыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void кафедрыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void предметыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void семестровые_оценкиDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void семестровые_оценкиDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сессияDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void специальностьDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void студентыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void факультетыDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.предметыDataGridView.Rows.Remove(this.предметыDataGridView.CurrentRow);



        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.группыDataGridView.Rows.Remove(this.группыDataGridView.CurrentRow);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.сессияDataGridView.Rows.Remove(this.сессияDataGridView.CurrentRow);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.семестровые_оценкиDataGridView.Rows.Remove(this.семестровые_оценкиDataGridView.CurrentRow);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.студентыDataGridView.Rows.Remove(this.студентыDataGridView.CurrentRow);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.факультетыDataGridView.Rows.Remove(this.факультетыDataGridView.CurrentRow);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.специальностьDataGridView.Rows.Remove(this.специальностьDataGridView.CurrentRow);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.кафедрыDataGridView.Rows.Remove(this.кафедрыDataGridView.CurrentRow);
        }
    }
}
