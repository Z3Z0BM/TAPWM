namespace PEmpregado
{
    partial class frmMensalista
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_instanciar_mensalista = new System.Windows.Forms.Button();
            this.btn_instanciar_mensalista_passando_parametros = new System.Windows.Forms.Button();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_salario_mensal = new System.Windows.Forms.Label();
            this.lbl_data_entrada_na_empresa = new System.Windows.Forms.Label();
            this.txtbox_matricula = new System.Windows.Forms.TextBox();
            this.txtbox_data_entrada_na_empresa = new System.Windows.Forms.TextBox();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.txtbox_salario_mensal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_instanciar_mensalista
            // 
            this.btn_instanciar_mensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instanciar_mensalista.Location = new System.Drawing.Point(72, 269);
            this.btn_instanciar_mensalista.Name = "btn_instanciar_mensalista";
            this.btn_instanciar_mensalista.Size = new System.Drawing.Size(250, 125);
            this.btn_instanciar_mensalista.TabIndex = 0;
            this.btn_instanciar_mensalista.Text = "Instanciar Mensalista";
            this.btn_instanciar_mensalista.UseVisualStyleBackColor = true;
            this.btn_instanciar_mensalista.Click += new System.EventHandler(this.btn_instanciar_mensalista_Click);
            // 
            // btn_instanciar_mensalista_passando_parametros
            // 
            this.btn_instanciar_mensalista_passando_parametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instanciar_mensalista_passando_parametros.Location = new System.Drawing.Point(490, 269);
            this.btn_instanciar_mensalista_passando_parametros.Name = "btn_instanciar_mensalista_passando_parametros";
            this.btn_instanciar_mensalista_passando_parametros.Size = new System.Drawing.Size(250, 125);
            this.btn_instanciar_mensalista_passando_parametros.TabIndex = 1;
            this.btn_instanciar_mensalista_passando_parametros.Text = "Instanciar Mensalista passando parâmetros";
            this.btn_instanciar_mensalista_passando_parametros.UseVisualStyleBackColor = true;
            this.btn_instanciar_mensalista_passando_parametros.Click += new System.EventHandler(this.btn_instanciar_mensalista_passando_parametros_Click);
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matricula.Location = new System.Drawing.Point(120, 50);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(100, 25);
            this.lbl_matricula.TabIndex = 2;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(120, 100);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(68, 25);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_salario_mensal
            // 
            this.lbl_salario_mensal.AutoSize = true;
            this.lbl_salario_mensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario_mensal.Location = new System.Drawing.Point(120, 150);
            this.lbl_salario_mensal.Name = "lbl_salario_mensal";
            this.lbl_salario_mensal.Size = new System.Drawing.Size(156, 25);
            this.lbl_salario_mensal.TabIndex = 4;
            this.lbl_salario_mensal.Text = "Salário Mensal";
            // 
            // lbl_data_entrada_na_empresa
            // 
            this.lbl_data_entrada_na_empresa.AutoSize = true;
            this.lbl_data_entrada_na_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_entrada_na_empresa.Location = new System.Drawing.Point(120, 200);
            this.lbl_data_entrada_na_empresa.Name = "lbl_data_entrada_na_empresa";
            this.lbl_data_entrada_na_empresa.Size = new System.Drawing.Size(259, 25);
            this.lbl_data_entrada_na_empresa.TabIndex = 5;
            this.lbl_data_entrada_na_empresa.Text = "Data Entrada na Empresa";
            // 
            // txtbox_matricula
            // 
            this.txtbox_matricula.Location = new System.Drawing.Point(463, 50);
            this.txtbox_matricula.Name = "txtbox_matricula";
            this.txtbox_matricula.Size = new System.Drawing.Size(250, 20);
            this.txtbox_matricula.TabIndex = 6;
            // 
            // txtbox_data_entrada_na_empresa
            // 
            this.txtbox_data_entrada_na_empresa.Location = new System.Drawing.Point(463, 200);
            this.txtbox_data_entrada_na_empresa.Name = "txtbox_data_entrada_na_empresa";
            this.txtbox_data_entrada_na_empresa.Size = new System.Drawing.Size(250, 20);
            this.txtbox_data_entrada_na_empresa.TabIndex = 7;
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(463, 100);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(250, 20);
            this.txtbox_nome.TabIndex = 8;
            // 
            // txtbox_salario_mensal
            // 
            this.txtbox_salario_mensal.Location = new System.Drawing.Point(463, 150);
            this.txtbox_salario_mensal.Name = "txtbox_salario_mensal";
            this.txtbox_salario_mensal.Size = new System.Drawing.Size(250, 20);
            this.txtbox_salario_mensal.TabIndex = 9;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox_salario_mensal);
            this.Controls.Add(this.txtbox_nome);
            this.Controls.Add(this.txtbox_data_entrada_na_empresa);
            this.Controls.Add(this.txtbox_matricula);
            this.Controls.Add(this.lbl_data_entrada_na_empresa);
            this.Controls.Add(this.lbl_salario_mensal);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.btn_instanciar_mensalista_passando_parametros);
            this.Controls.Add(this.btn_instanciar_mensalista);
            this.Name = "frmMensalista";
            this.Text = "Mensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_instanciar_mensalista;
        private System.Windows.Forms.Button btn_instanciar_mensalista_passando_parametros;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_salario_mensal;
        private System.Windows.Forms.Label lbl_data_entrada_na_empresa;
        private System.Windows.Forms.TextBox txtbox_matricula;
        private System.Windows.Forms.TextBox txtbox_data_entrada_na_empresa;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.TextBox txtbox_salario_mensal;
    }
}

