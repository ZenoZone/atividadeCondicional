﻿namespace condicionalNiviaDois
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblnomes = new System.Windows.Forms.Label();
            this.txtapnome = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblabono = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(319, 56);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(319, 107);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(97, 20);
            this.txtidade.TabIndex = 1;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(319, 152);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 2;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(319, 205);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(613, 149);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(257, 59);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Nome";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(258, 110);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(34, 13);
            this.lblidade.TabIndex = 6;
            this.lblidade.Text = "Idade";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(261, 159);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 7;
            this.lblsexo.Text = "Sexo";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(253, 208);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(39, 13);
            this.lblsalario.TabIndex = 8;
            this.lblsalario.Text = "Salario";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(237, 303);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(55, 13);
            this.lblresult.TabIndex = 9;
            this.lblresult.Text = "Resultado";
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(308, 296);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 10;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(613, 198);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblnomes
            // 
            this.lblnomes.AutoSize = true;
            this.lblnomes.Location = new System.Drawing.Point(257, 340);
            this.lblnomes.Name = "lblnomes";
            this.lblnomes.Size = new System.Drawing.Size(35, 13);
            this.lblnomes.TabIndex = 12;
            this.lblnomes.Text = "Nome";
            // 
            // txtapnome
            // 
            this.txtapnome.Enabled = false;
            this.txtapnome.Location = new System.Drawing.Point(308, 333);
            this.txtapnome.Name = "txtapnome";
            this.txtapnome.Size = new System.Drawing.Size(100, 20);
            this.txtapnome.TabIndex = 13;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(613, 259);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 14;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblabono
            // 
            this.lblabono.AutoSize = true;
            this.lblabono.Location = new System.Drawing.Point(253, 261);
            this.lblabono.Name = "lblabono";
            this.lblabono.Size = new System.Drawing.Size(38, 13);
            this.lblabono.TabIndex = 15;
            this.lblabono.Text = "Abono";
            // 
            // txtabono
            // 
            this.txtabono.Enabled = false;
            this.txtabono.Location = new System.Drawing.Point(308, 254);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(100, 20);
            this.txtabono.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.lblabono);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtapnome);
            this.Controls.Add(this.lblnomes);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblnomes;
        private System.Windows.Forms.TextBox txtapnome;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblabono;
        private System.Windows.Forms.TextBox txtabono;
    }
}

