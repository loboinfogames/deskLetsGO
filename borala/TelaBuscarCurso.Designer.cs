﻿
namespace borala
{
    partial class TelaBuscarCurso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boraLati44DataSet = new borala.BoraLati44DataSet();
            this.btn_cadastrar_curso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cursoTableAdapter = new borala.BoraLati44DataSetTableAdapters.CursoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_cadastrar_curso);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(43, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 545);
            this.panel1.TabIndex = 1;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(549, 497);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(98, 39);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Excluir";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.nomeCursoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataInicoDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn,
            this.idTurmaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cursoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(102, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 353);
            this.dataGridView1.TabIndex = 5;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCursoDataGridViewTextBoxColumn
            // 
            this.nomeCursoDataGridViewTextBoxColumn.DataPropertyName = "NomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.HeaderText = "NomeCurso";
            this.nomeCursoDataGridViewTextBoxColumn.Name = "nomeCursoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // dataInicoDataGridViewTextBoxColumn
            // 
            this.dataInicoDataGridViewTextBoxColumn.DataPropertyName = "DataInico";
            this.dataInicoDataGridViewTextBoxColumn.HeaderText = "DataInico";
            this.dataInicoDataGridViewTextBoxColumn.Name = "dataInicoDataGridViewTextBoxColumn";
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // idTurmaDataGridViewTextBoxColumn
            // 
            this.idTurmaDataGridViewTextBoxColumn.DataPropertyName = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.HeaderText = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.Name = "idTurmaDataGridViewTextBoxColumn";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.boraLati44DataSet;
            // 
            // boraLati44DataSet
            // 
            this.boraLati44DataSet.DataSetName = "BoraLati44DataSet";
            this.boraLati44DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_cadastrar_curso
            // 
            this.btn_cadastrar_curso.Location = new System.Drawing.Point(318, 497);
            this.btn_cadastrar_curso.Name = "btn_cadastrar_curso";
            this.btn_cadastrar_curso.Size = new System.Drawing.Size(98, 39);
            this.btn_cadastrar_curso.TabIndex = 4;
            this.btn_cadastrar_curso.Text = "Cadastrar";
            this.btn_cadastrar_curso.UseVisualStyleBackColor = true;
            this.btn_cadastrar_curso.Click += new System.EventHandler(this.btn_cadastrar_curso_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 27);
            this.textBox1.TabIndex = 0;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // TelaBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 597);
            this.Controls.Add(this.panel1);
            this.Name = "TelaBuscarCurso";
            this.Text = "TelaBuscarCurso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BoraLati44DataSet boraLati44DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BoraLati44DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cadastrar_curso;
    }
}