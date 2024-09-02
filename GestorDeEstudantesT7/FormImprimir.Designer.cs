namespace GestorDeEstudantesT7
{
    partial class FormImprimir
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
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.dataGridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.buttonSalvarEmArquivoDeTexto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(545, 12);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(243, 64);
            this.buttonFiltrar.TabIndex = 1;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // dataGridViewListaDeAlunos
            // 
            this.dataGridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeAlunos.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewListaDeAlunos.Name = "dataGridViewListaDeAlunos";
            this.dataGridViewListaDeAlunos.Size = new System.Drawing.Size(776, 293);
            this.dataGridViewListaDeAlunos.TabIndex = 41;
            // 
            // buttonSalvarEmArquivoDeTexto
            // 
            this.buttonSalvarEmArquivoDeTexto.Location = new System.Drawing.Point(12, 381);
            this.buttonSalvarEmArquivoDeTexto.Name = "buttonSalvarEmArquivoDeTexto";
            this.buttonSalvarEmArquivoDeTexto.Size = new System.Drawing.Size(776, 64);
            this.buttonSalvarEmArquivoDeTexto.TabIndex = 42;
            this.buttonSalvarEmArquivoDeTexto.Text = "Salvar Em Arquivo de Texto";
            this.buttonSalvarEmArquivoDeTexto.UseVisualStyleBackColor = true;
            this.buttonSalvarEmArquivoDeTexto.Click += new System.EventHandler(this.buttonSalvarEmArquivoDeTexto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 69);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerFinal);
            this.groupBox2.Controls.Add(this.dateTimePickerInicial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButtonSim);
            this.groupBox2.Controls.Add(this.radioButtonNao);
            this.groupBox2.Location = new System.Drawing.Point(228, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 69);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nascidos Entre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usar intervalo de datas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(251, 16);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 1;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Location = new System.Drawing.Point(200, 16);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 0;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButtonNao_CheckedChanged);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(167, 29);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 2;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(94, 29);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButtonFeminino_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(15, 29);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButtonMasculino_CheckedChanged);
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.Location = new System.Drawing.Point(93, 43);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(85, 20);
            this.dateTimePickerInicial.TabIndex = 45;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(200, 42);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(85, 20);
            this.dateTimePickerFinal.TabIndex = 48;
            // 
            // FormImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalvarEmArquivoDeTexto);
            this.Controls.Add(this.dataGridViewListaDeAlunos);
            this.Controls.Add(this.buttonFiltrar);
            this.Name = "FormImprimir";
            this.Text = "FormImprimir";
            this.Load += new System.EventHandler(this.FormImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.DataGridView dataGridViewListaDeAlunos;
        private System.Windows.Forms.Button buttonSalvarEmArquivoDeTexto;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton radioButtonFeminino;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        internal System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton radioButtonSim;
        internal System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
    }
}