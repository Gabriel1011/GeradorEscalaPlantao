namespace GeradorEscalaPlantao.FORM
{
    partial class CadastroFuncionario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.mskFimFerias = new System.Windows.Forms.MaskedTextBox();
            this.mskInicioFerias = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOrdem = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orderm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioFerias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FimFerias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.mskFimFerias);
            this.groupBox1.Controls.Add(this.mskInicioFerias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numOrdem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(359, 61);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(63, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // mskFimFerias
            // 
            this.mskFimFerias.Location = new System.Drawing.Point(219, 50);
            this.mskFimFerias.Mask = "00/00/0000";
            this.mskFimFerias.Name = "mskFimFerias";
            this.mskFimFerias.Size = new System.Drawing.Size(67, 20);
            this.mskFimFerias.TabIndex = 8;
            this.mskFimFerias.ValidatingType = typeof(System.DateTime);
            // 
            // mskInicioFerias
            // 
            this.mskInicioFerias.Location = new System.Drawing.Point(83, 50);
            this.mskInicioFerias.Mask = "00/00/0000";
            this.mskInicioFerias.Name = "mskInicioFerias";
            this.mskInicioFerias.Size = new System.Drawing.Size(67, 20);
            this.mskInicioFerias.TabIndex = 7;
            this.mskInicioFerias.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fim Férias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Início Férias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordem:";
            // 
            // numOrdem
            // 
            this.numOrdem.Location = new System.Drawing.Point(263, 17);
            this.numOrdem.Name = "numOrdem";
            this.numOrdem.Size = new System.Drawing.Size(32, 20);
            this.numOrdem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(358, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(13, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AllowUserToAddRows = false;
            this.dtgFuncionario.AllowUserToDeleteRows = false;
            this.dtgFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Orderm,
            this.InicioFerias,
            this.FimFerias});
            this.dtgFuncionario.Location = new System.Drawing.Point(9, 19);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.ReadOnly = true;
            this.dtgFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionario.Size = new System.Drawing.Size(416, 310);
            this.dtgFuncionario.TabIndex = 0;
            this.dtgFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Orderm
            // 
            this.Orderm.DataPropertyName = "Ordem";
            this.Orderm.HeaderText = "Orderm";
            this.Orderm.Name = "Orderm";
            this.Orderm.ReadOnly = true;
            this.Orderm.Width = 66;
            // 
            // InicioFerias
            // 
            this.InicioFerias.DataPropertyName = "InicioFerias";
            this.InicioFerias.HeaderText = "Início Férias";
            this.InicioFerias.Name = "InicioFerias";
            this.InicioFerias.ReadOnly = true;
            this.InicioFerias.Width = 90;
            // 
            // FimFerias
            // 
            this.FimFerias.DataPropertyName = "Fimferias";
            this.FimFerias.HeaderText = "Fim Férias";
            this.FimFerias.Name = "FimFerias";
            this.FimFerias.ReadOnly = true;
            this.FimFerias.Width = 79;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(359, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskFimFerias;
        private System.Windows.Forms.MaskedTextBox mskInicioFerias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOrdem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderm;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioFerias;
        private System.Windows.Forms.DataGridViewTextBoxColumn FimFerias;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
    }
}