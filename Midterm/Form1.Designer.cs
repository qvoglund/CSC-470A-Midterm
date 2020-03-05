namespace Midterm
{
    partial class frmRecArea
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
            this.peopleAreaDataGridView = new System.Windows.Forms.DataGridView();
            this.tbxFname = new System.Windows.Forms.TextBox();
            this.tbxLname = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleAreaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midtermDBDataSet = new Midterm.MidtermDBDataSet();
            this.peopleAreaTableAdapter = new Midterm.MidtermDBDataSetTableAdapters.peopleAreaTableAdapter();
            this.tableAdapterManager = new Midterm.MidtermDBDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAreaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAreaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleAreaDataGridView
            // 
            this.peopleAreaDataGridView.AllowUserToAddRows = false;
            this.peopleAreaDataGridView.AllowUserToDeleteRows = false;
            this.peopleAreaDataGridView.AutoGenerateColumns = false;
            this.peopleAreaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleAreaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.peopleAreaDataGridView.DataSource = this.peopleAreaBindingSource;
            this.peopleAreaDataGridView.Location = new System.Drawing.Point(12, 28);
            this.peopleAreaDataGridView.Name = "peopleAreaDataGridView";
            this.peopleAreaDataGridView.ReadOnly = true;
            this.peopleAreaDataGridView.Size = new System.Drawing.Size(744, 220);
            this.peopleAreaDataGridView.TabIndex = 1;
            this.peopleAreaDataGridView.TabStop = false;
            // 
            // tbxFname
            // 
            this.tbxFname.Location = new System.Drawing.Point(146, 308);
            this.tbxFname.Name = "tbxFname";
            this.tbxFname.Size = new System.Drawing.Size(133, 20);
            this.tbxFname.TabIndex = 2;
            // 
            // tbxLname
            // 
            this.tbxLname.Location = new System.Drawing.Point(146, 334);
            this.tbxLname.Name = "tbxLname";
            this.tbxLname.Size = new System.Drawing.Size(133, 20);
            this.tbxLname.TabIndex = 3;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(146, 360);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(133, 20);
            this.tbxEmail.TabIndex = 4;
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(644, 290);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(112, 20);
            this.tbxWidth.TabIndex = 5;
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(458, 360);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(112, 20);
            this.tbxLength.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(644, 358);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate and Add";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email Address";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AFname";
            this.dataGridViewTextBoxColumn5.HeaderText = "AFname";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ALname";
            this.dataGridViewTextBoxColumn6.HeaderText = "ALname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AEmail";
            this.dataGridViewTextBoxColumn7.HeaderText = "AEmail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ALength";
            this.dataGridViewTextBoxColumn3.HeaderText = "ALength";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AWidth";
            this.dataGridViewTextBoxColumn2.HeaderText = "AWidth";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AArea";
            this.dataGridViewTextBoxColumn4.HeaderText = "AArea";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // peopleAreaBindingSource
            // 
            this.peopleAreaBindingSource.DataMember = "peopleArea";
            this.peopleAreaBindingSource.DataSource = this.midtermDBDataSet;
            // 
            // midtermDBDataSet
            // 
            this.midtermDBDataSet.DataSetName = "MidtermDBDataSet";
            this.midtermDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleAreaTableAdapter
            // 
            this.peopleAreaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.areaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.peopleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Midterm.MidtermDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Midterm.Properties.Resources.rectangle;
            this.pictureBox1.Location = new System.Drawing.Point(411, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmRecArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxLname);
            this.Controls.Add(this.tbxFname);
            this.Controls.Add(this.peopleAreaDataGridView);
            this.Name = "frmRecArea";
            this.Text = "RecArea";
            this.Load += new System.EventHandler(this.frmRecArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleAreaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAreaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MidtermDBDataSet midtermDBDataSet;
        private System.Windows.Forms.BindingSource peopleAreaBindingSource;
        private MidtermDBDataSetTableAdapters.peopleAreaTableAdapter peopleAreaTableAdapter;
        private MidtermDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView peopleAreaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox tbxFname;
        private System.Windows.Forms.TextBox tbxLname;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

