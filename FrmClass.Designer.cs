
namespace School_Management
{
    partial class FrmClass
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
            this.dataGridClass = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtClassStandard = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClass
            // 
            this.dataGridClass.AllowUserToAddRows = false;
            this.dataGridClass.AllowUserToDeleteRows = false;
            this.dataGridClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName,
            this.ClassSection,
            this.ClassStandard,
            this.SubjectID});
            this.dataGridClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridClass.Location = new System.Drawing.Point(2, 196);
            this.dataGridClass.Name = "dataGridClass";
            this.dataGridClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClass.Size = new System.Drawing.Size(678, 253);
            this.dataGridClass.StandardTab = true;
            this.dataGridClass.TabIndex = 7;
            this.dataGridClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClass_CellDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(131, 95);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(197, 21);
            this.cmbSubject.TabIndex = 3;
            // 
            // txtClassStandard
            // 
            this.txtClassStandard.Location = new System.Drawing.Point(131, 70);
            this.txtClassStandard.Multiline = true;
            this.txtClassStandard.Name = "txtClassStandard";
            this.txtClassStandard.Size = new System.Drawing.Size(197, 24);
            this.txtClassStandard.TabIndex = 2;
            this.txtClassStandard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassStandard_KeyPress_1);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(131, 45);
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(197, 24);
            this.txtSection.TabIndex = 1;
            this.txtSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSection_KeyPress_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(131, 20);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(197, 24);
            this.txtClassName.TabIndex = 0;
            this.txtClassName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClassName_KeyPress_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Class Standard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Class Name\r\n";
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            // 
            // ClassSection
            // 
            this.ClassSection.HeaderText = "Class Section";
            this.ClassSection.Name = "ClassSection";
            // 
            // ClassStandard
            // 
            this.ClassStandard.HeaderText = "Class Standard";
            this.ClassStandard.Name = "ClassStandard";
            // 
            // SubjectID
            // 
            this.SubjectID.HeaderText = "Subject Name";
            this.SubjectID.Name = "SubjectID";
            // 
            // FrmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridClass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.txtClassStandard);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtClassName);
            this.Name = "FrmClass";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.FrmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtClassStandard;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
    }
}