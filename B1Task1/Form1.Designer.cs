
using System;

namespace B1Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b1t1dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1t1englishStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1t1russianStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1t1evenNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1t1lessNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b1Task1DataSet = new B1Task1.B1Task1DataSet();
            this.b1t1TableAdapter = new B1Task1.B1Task1DataSetTableAdapters.B1t1TableAdapter();
            this.buttonAddDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1Task1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFolder.Location = new System.Drawing.Point(27, 9);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.ReadOnly = true;
            this.textBoxFolder.Size = new System.Drawing.Size(348, 26);
            this.textBoxFolder.TabIndex = 0;
            this.textBoxFolder.Text = "C:\\Users\\Anatol\\Documents";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonChooseFolder.Location = new System.Drawing.Point(381, 8);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(131, 28);
            this.buttonChooseFolder.TabIndex = 1;
            this.buttonChooseFolder.Text = "Выбор папки";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGenerate.Location = new System.Drawing.Point(518, 7);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(162, 28);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonJoin.Location = new System.Drawing.Point(541, 57);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(139, 28);
            this.buttonJoin.TabIndex = 3;
            this.buttonJoin.Text = "Объединить";
            this.buttonJoin.UseVisualStyleBackColor = true;
            this.buttonJoin.Click += new System.EventHandler(this.buttonJoin_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFile.Location = new System.Drawing.Point(392, 58);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(143, 26);
            this.textBoxFile.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b1t1dateDataGridViewTextBoxColumn,
            this.b1t1englishStringDataGridViewTextBoxColumn,
            this.b1t1russianStringDataGridViewTextBoxColumn,
            this.b1t1evenNumberDataGridViewTextBoxColumn,
            this.b1t1lessNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.b1t1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 255);
            this.dataGridView1.TabIndex = 6;
            // 
            // b1t1dateDataGridViewTextBoxColumn
            // 
            this.b1t1dateDataGridViewTextBoxColumn.DataPropertyName = "b1t1_date";
            this.b1t1dateDataGridViewTextBoxColumn.HeaderText = "b1t1_date";
            this.b1t1dateDataGridViewTextBoxColumn.Name = "b1t1dateDataGridViewTextBoxColumn";
            this.b1t1dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1t1englishStringDataGridViewTextBoxColumn
            // 
            this.b1t1englishStringDataGridViewTextBoxColumn.DataPropertyName = "b1t1_englishString";
            this.b1t1englishStringDataGridViewTextBoxColumn.HeaderText = "b1t1_englishString";
            this.b1t1englishStringDataGridViewTextBoxColumn.Name = "b1t1englishStringDataGridViewTextBoxColumn";
            this.b1t1englishStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1t1russianStringDataGridViewTextBoxColumn
            // 
            this.b1t1russianStringDataGridViewTextBoxColumn.DataPropertyName = "b1t1_russianString";
            this.b1t1russianStringDataGridViewTextBoxColumn.HeaderText = "b1t1_russianString";
            this.b1t1russianStringDataGridViewTextBoxColumn.Name = "b1t1russianStringDataGridViewTextBoxColumn";
            this.b1t1russianStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1t1evenNumberDataGridViewTextBoxColumn
            // 
            this.b1t1evenNumberDataGridViewTextBoxColumn.DataPropertyName = "b1t1_evenNumber";
            this.b1t1evenNumberDataGridViewTextBoxColumn.HeaderText = "b1t1_evenNumber";
            this.b1t1evenNumberDataGridViewTextBoxColumn.Name = "b1t1evenNumberDataGridViewTextBoxColumn";
            this.b1t1evenNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1t1lessNumberDataGridViewTextBoxColumn
            // 
            this.b1t1lessNumberDataGridViewTextBoxColumn.DataPropertyName = "b1t1_lessNumber";
            this.b1t1lessNumberDataGridViewTextBoxColumn.HeaderText = "b1t1_lessNumber";
            this.b1t1lessNumberDataGridViewTextBoxColumn.Name = "b1t1lessNumberDataGridViewTextBoxColumn";
            this.b1t1lessNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // b1t1BindingSource
            // 
            this.b1t1BindingSource.DataMember = "B1t1";
            this.b1t1BindingSource.DataSource = this.b1Task1DataSet;
            // 
            // b1Task1DataSet
            // 
            this.b1Task1DataSet.DataSetName = "B1Task1DataSet";
            this.b1Task1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b1t1TableAdapter
            // 
            this.b1t1TableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddDB
            // 
            this.buttonAddDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddDB.Location = new System.Drawing.Point(602, 128);
            this.buttonAddDB.Name = "buttonAddDB";
            this.buttonAddDB.Size = new System.Drawing.Size(134, 52);
            this.buttonAddDB.TabIndex = 7;
            this.buttonAddDB.Text = "Загрузить файлы в БД";
            this.buttonAddDB.UseVisualStyleBackColor = true;
            this.buttonAddDB.Click += new System.EventHandler(this.buttonAddDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(578, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "Импортировано строк: \r\n\r\nСтрок осталось:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Строка удаления (при объединении файлов) -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddDB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.textBoxFolder);
            this.Name = "Form1";
            this.Text = "B1Task1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1Task1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.TextBox textBoxFile;
        public System.Windows.Forms.DataGridView dataGridView1;
        public B1Task1DataSet b1Task1DataSet;
        public System.Windows.Forms.BindingSource b1t1BindingSource;
        public B1Task1DataSetTableAdapters.B1t1TableAdapter b1t1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1t1dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1t1englishStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1t1russianStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1t1evenNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1t1lessNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

