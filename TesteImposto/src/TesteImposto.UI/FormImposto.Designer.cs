namespace TesteImposto.UI
{
    partial class FormImposto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEstadoOrigem = new System.Windows.Forms.TextBox();
            this.txtEstadoDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.buttonGerarNotaFiscal = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEditarNF = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Origem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Destino";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(95, 9);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(939, 20);
            this.textBoxNomeCliente.TabIndex = 3;
            // 
            // txtEstadoOrigem
            // 
            this.txtEstadoOrigem.Location = new System.Drawing.Point(95, 31);
            this.txtEstadoOrigem.Name = "txtEstadoOrigem";
            this.txtEstadoOrigem.Size = new System.Drawing.Size(939, 20);
            this.txtEstadoOrigem.TabIndex = 4;
            // 
            // txtEstadoDestino
            // 
            this.txtEstadoDestino.Location = new System.Drawing.Point(95, 53);
            this.txtEstadoDestino.Name = "txtEstadoDestino";
            this.txtEstadoDestino.Size = new System.Drawing.Size(939, 20);
            this.txtEstadoDestino.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Itens do pedido";
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToOrderColumns = true;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(6, 109);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.Size = new System.Drawing.Size(1028, 325);
            this.dataGridViewPedidos.TabIndex = 7;
            // 
            // buttonGerarNotaFiscal
            // 
            this.buttonGerarNotaFiscal.Location = new System.Drawing.Point(250, 442);
            this.buttonGerarNotaFiscal.Name = "buttonGerarNotaFiscal";
            this.buttonGerarNotaFiscal.Size = new System.Drawing.Size(127, 23);
            this.buttonGerarNotaFiscal.TabIndex = 8;
            this.buttonGerarNotaFiscal.Text = "Gerar Nota Fiscal";
            this.buttonGerarNotaFiscal.UseVisualStyleBackColor = true;
            this.buttonGerarNotaFiscal.Click += new System.EventHandler(this.buttonGerarNotaFiscal_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(519, 442);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(97, 23);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta Imposto";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEditarNF
            // 
            this.btnEditarNF.Location = new System.Drawing.Point(394, 442);
            this.btnEditarNF.Name = "btnEditarNF";
            this.btnEditarNF.Size = new System.Drawing.Size(97, 23);
            this.btnEditarNF.TabIndex = 10;
            this.btnEditarNF.Text = "Editar Nota Fiscal";
            this.btnEditarNF.UseVisualStyleBackColor = true;
            this.btnEditarNF.Click += new System.EventHandler(this.btnEditarNF_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(934, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditarNF);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.buttonGerarNotaFiscal);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstadoDestino);
            this.Controls.Add(this.txtEstadoOrigem);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormImposto";
            this.Text = "Calculo de imposto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox txtEstadoOrigem;
        private System.Windows.Forms.TextBox txtEstadoDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Button buttonGerarNotaFiscal;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnEditarNF;
        private System.Windows.Forms.Button btnClose;
    }
}

