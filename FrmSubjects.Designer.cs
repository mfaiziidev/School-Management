
namespace School_Management
{
    partial class FrmSubjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtName = new System.Windows.Forms.TextBox();
            this.txtSubStandard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridsubjects = new System.Windows.Forms.DataGridView();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name";
            // 
            // txtSubtName
            // 
            this.txtSubtName.Location = new System.Drawing.Point(140, 50);
            this.txtSubtName.Multiline = true;
            this.txtSubtName.Name = "txtSubtName";
            this.txtSubtName.Size = new System.Drawing.Size(218, 31);
            this.txtSubtName.TabIndex = 0;
            this.txtSubtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtName_KeyPress_1);
            // 
            // txtSubStandard
            // 
            this.txtSubStandard.Location = new System.Drawing.Point(140, 82);
            this.txtSubStandard.Multiline = true;
            this.txtSubStandard.Name = "txtSubStandard";
            this.txtSubStandard.Size = new System.Drawing.Size(218, 31);
            this.txtSubStandard.TabIndex = 1;
            this.txtSubStandard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubStandard_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Standard";
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(140, 114);
            this.txtSubCategory.Multiline = true;
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(218, 31);
            this.txtSubCategory.TabIndex = 2;
            this.txtSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubCategory_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject Category";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(190, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(296, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridsubjects
            // 
            this.dataGridsubjects.AllowUserToAddRows = false;
            this.dataGridsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridsubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectID,
            this.SubjectName,
            this.SubjectStandard,
            this.SubjectCategory});
            this.dataGridsubjects.Location = new System.Drawing.Point(1, 236);
            this.dataGridsubjects.Name = "dataGridsubjects";
            this.dataGridsubjects.ReadOnly = true;
            this.dataGridsubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridsubjects.Size = new System.Drawing.Size(658, 252);
            this.dataGridsubjects.TabIndex = 6;
            this.dataGridsubjects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridsubjects_CellMouseDoubleClick);
            // 
            // SubjectID
            // 
            this.SubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectID.HeaderText = "SubjectID";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // SubjectStandard
            // 
            this.SubjectStandard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectStandard.HeaderText = "Subject Standard";
            this.SubjectStandard.Name = "SubjectStandard";
            this.SubjectStandard.ReadOnly = true;
            // 
            // SubjectCategory
            // 
            this.SubjectCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectCategory.HeaderText = "Subject Category";
            this.SubjectCategory.Name = "SubjectCategory";
            this.SubjectCategory.ReadOnly = true;
            // 
            // FrmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 489);
            this.Controls.Add(this.dataGridsubjects);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSubCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubStandard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtName);
            this.Controls.Add(this.label1);
            this.Name = "FrmSubjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.FrmSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridsubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtName;
        private System.Windows.Forms.TextBox txtSubStandard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridsubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCategory;
    }
}

