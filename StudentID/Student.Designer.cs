namespace StudentLogin
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new StudentID.studentDataSet();
            this.add = new System.Windows.Forms.Button();
            this.studentInfoTableAdapter = new StudentID.studentDataSetTableAdapters.StudentInfoTableAdapter();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.studentDataSet2 = new StudentID.studentDataSet2();
            this.studentInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoTableAdapter2 = new StudentID.studentDataSet2TableAdapters.StudentInfoTableAdapter();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new StudentID.studentDataSet2TableAdapters.GradeTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource3)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInfoBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentInfoBindingSource3
            // 
            this.studentInfoBindingSource3.DataMember = "StudentInfo";
            
            // 
            
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(850, 45);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 56);
            this.add.TabIndex = 1;
            this.add.Text = "save";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // studentInfoBindingSource2
            // 
            this.studentInfoBindingSource2.DataMember = "StudentInfo";
            this.studentInfoBindingSource2.DataSource = this.studentDataSetBindingSource;
            // 
           
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "studentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource4
            // 
            this.studentInfoBindingSource4.DataMember = "StudentInfo";
            this.studentInfoBindingSource4.DataSource = this.studentDataSet2;
            // 
            // studentInfoTableAdapter2
            // 
            this.studentInfoTableAdapter2.ClearBeforeFill = true;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.studentDataSet2;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 588);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource3)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private StudentID.studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentID.studentDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
      
        private System.Windows.Forms.BindingSource studentInfoBindingSource1;
        
        private System.Windows.Forms.BindingSource studentInfoBindingSource2;
        
        private System.Windows.Forms.BindingSource studentDataSet2BindingSource;
        
        private System.Windows.Forms.BindingSource studentInfoBindingSource3;
        
        private StudentID.studentDataSet2 studentDataSet2;
        private System.Windows.Forms.BindingSource studentInfoBindingSource4;
        private StudentID.studentDataSet2TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter2;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private StudentID.studentDataSet2TableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
    }
}