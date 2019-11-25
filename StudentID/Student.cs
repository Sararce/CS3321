using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Configuration;

namespace StudentLogin
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }



        

        private void Student_Load(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.Fill(this.studentDataSet.StudentInfo);




        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                studentInfoBindingSource.EndEdit();
                studentInfoTableAdapter.Update(this.studentDataSet.StudentInfo);
                MessageBox.Show("Save success.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Cursor.Current = Cursors.Default;


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        
    }
}
