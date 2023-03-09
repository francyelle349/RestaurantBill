namespace Despesas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.despesa = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDaConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // despesa
            // 
            this.despesa.AutoSize = true;
            this.despesa.Location = new System.Drawing.Point(12, 18);
            this.despesa.Name = "despesa";
            this.despesa.Size = new System.Drawing.Size(52, 13);
            this.despesa.TabIndex = 0;
            this.despesa.Text = "Despesa:";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(70, 15);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(124, 20);
            this.txtDespesa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total com 10%:";
            // 
            // txtTotalDaConta
            // 
            this.txtTotalDaConta.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalDaConta.Location = new System.Drawing.Point(98, 49);
            this.txtTotalDaConta.Name = "txtTotalDaConta";
            this.txtTotalDaConta.Size = new System.Drawing.Size(162, 20);
            this.txtTotalDaConta.TabIndex = 4;
            this.txtTotalDaConta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 87);
            this.Controls.Add(this.txtTotalDaConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.despesa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gasto em um restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label despesa;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalDaConta;
    }
}

