namespace PEmpregado
{
    partial class frmSelecao
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
            this.lbl_selecione_uma_das_opcoes = new System.Windows.Forms.Label();
            this.btn_para_mensalista = new System.Windows.Forms.Button();
            this.btn_para_horista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selecione_uma_das_opcoes
            // 
            this.lbl_selecione_uma_das_opcoes.AutoSize = true;
            this.lbl_selecione_uma_das_opcoes.Location = new System.Drawing.Point(311, 113);
            this.lbl_selecione_uma_das_opcoes.Name = "lbl_selecione_uma_das_opcoes";
            this.lbl_selecione_uma_das_opcoes.Size = new System.Drawing.Size(141, 13);
            this.lbl_selecione_uma_das_opcoes.TabIndex = 4;
            this.lbl_selecione_uma_das_opcoes.Text = "Selecione Uma Das Opções";
            // 
            // btn_para_mensalista
            // 
            this.btn_para_mensalista.Location = new System.Drawing.Point(363, 214);
            this.btn_para_mensalista.Name = "btn_para_mensalista";
            this.btn_para_mensalista.Size = new System.Drawing.Size(75, 23);
            this.btn_para_mensalista.TabIndex = 5;
            this.btn_para_mensalista.Text = "Mensalista";
            this.btn_para_mensalista.UseVisualStyleBackColor = true;
            this.btn_para_mensalista.Click += new System.EventHandler(this.btn_para_mensalista_Click);
            // 
            // btn_para_horista
            // 
            this.btn_para_horista.Location = new System.Drawing.Point(470, 214);
            this.btn_para_horista.Name = "btn_para_horista";
            this.btn_para_horista.Size = new System.Drawing.Size(75, 23);
            this.btn_para_horista.TabIndex = 6;
            this.btn_para_horista.Text = "Horista";
            this.btn_para_horista.UseVisualStyleBackColor = true;
            this.btn_para_horista.Click += new System.EventHandler(this.btn_para_horista_Click);
            // 
            // frmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_para_horista);
            this.Controls.Add(this.btn_para_mensalista);
            this.Controls.Add(this.lbl_selecione_uma_das_opcoes);
            this.Name = "frmSelecao";
            this.Text = "frmSelecao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_selecione_uma_das_opcoes;
        private System.Windows.Forms.Button btn_para_mensalista;
        private System.Windows.Forms.Button btn_para_horista;
    }
}