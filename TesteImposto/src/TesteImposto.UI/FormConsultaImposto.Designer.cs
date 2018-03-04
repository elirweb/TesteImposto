namespace TesteImposto.UI
{
    partial class FormConsultaImposto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.CFOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CFOP,
            this.BaseICMS,
            this.ValorICMS,
            this.BaseIPI,
            this.ValorIPI});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(522, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CFOP
            // 
            this.CFOP.DataPropertyName = "CFOP";
            this.CFOP.HeaderText = "CFOP";
            this.CFOP.Name = "CFOP";
            // 
            // BaseICMS
            // 
            this.BaseICMS.DataPropertyName = "BaseIcms";
            this.BaseICMS.HeaderText = "Valor Total da Base de ICMS";
            this.BaseICMS.Name = "BaseICMS";
            // 
            // ValorICMS
            // 
            this.ValorICMS.DataPropertyName = "ValorIcms";
            this.ValorICMS.HeaderText = "Valor Total do ICMS";
            this.ValorICMS.Name = "ValorICMS";
            // 
            // BaseIPI
            // 
            this.BaseIPI.DataPropertyName = "BaseIPI";
            this.BaseIPI.HeaderText = "Valor Total da Base de IPI";
            this.BaseIPI.Name = "BaseIPI";
            // 
            // ValorIPI
            // 
            this.ValorIPI.DataPropertyName = "ValorIPI";
            this.ValorIPI.HeaderText = "Valor Total do IPI";
            this.ValorIPI.Name = "ValorIPI";
            // 
            // FormConsultaImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 331);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConsultaImposto";
            this.Text = "FormConsultaImposto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorIPI;
    }
}