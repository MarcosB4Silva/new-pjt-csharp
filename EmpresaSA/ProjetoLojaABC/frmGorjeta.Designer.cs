﻿
namespace ProjetoLojaABC
{
    partial class frmGorjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorjeta));
            this.lblValorConta = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbbAvalia = new System.Windows.Forms.ComboBox();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.txtGorjeta = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.txtCodGorjeta = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConta.Location = new System.Drawing.Point(73, 158);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(129, 18);
            this.lblValorConta.TabIndex = 0;
            this.lblValorConta.Text = "Valor da conta:";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(73, 199);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(98, 18);
            this.lblQualidade.TabIndex = 1;
            this.lblQualidade.Text = "Qualidade :";
            // 
            // txtValorConta
            // 
            this.txtValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConta.Location = new System.Drawing.Point(204, 158);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(90, 26);
            this.txtValorConta.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(54, 269);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 40);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(240, 317);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 40);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbbAvalia
            // 
            this.cbbAvalia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAvalia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAvalia.FormattingEnabled = true;
            this.cbbAvalia.ItemHeight = 20;
            this.cbbAvalia.Items.AddRange(new object[] {
            "Exelente - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbAvalia.Location = new System.Drawing.Point(171, 199);
            this.cbbAvalia.Name = "cbbAvalia";
            this.cbbAvalia.Size = new System.Drawing.Size(123, 28);
            this.cbbAvalia.TabIndex = 6;
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(177, 79);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(190, 28);
            this.cbbFuncionario.TabIndex = 1;
            this.cbbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbbFuncionario_SelectedIndexChanged);
            // 
            // txtGorjeta
            // 
            this.txtGorjeta.Enabled = false;
            this.txtGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGorjeta.Location = new System.Drawing.Point(450, 158);
            this.txtGorjeta.Name = "txtGorjeta";
            this.txtGorjeta.Size = new System.Drawing.Size(77, 26);
            this.txtGorjeta.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(431, 201);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGorjeta.Location = new System.Drawing.Point(304, 162);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(140, 18);
            this.lblValorGorjeta.TabIndex = 10;
            this.lblValorGorjeta.Text = "Valor da gorjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor da final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Funcionário:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(177, 269);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 40);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "GORJETA";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Enabled = false;
            this.txtCodFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFunc.Location = new System.Drawing.Point(257, 116);
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(37, 26);
            this.txtCodFunc.TabIndex = 2;
            // 
            // txtCodGorjeta
            // 
            this.txtCodGorjeta.Enabled = false;
            this.txtCodGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodGorjeta.Location = new System.Drawing.Point(474, 116);
            this.txtCodGorjeta.Name = "txtCodGorjeta";
            this.txtCodGorjeta.Size = new System.Drawing.Size(53, 26);
            this.txtCodGorjeta.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(300, 269);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 40);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Código da gorjeta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo do funcionário:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(373, 79);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 18);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(423, 81);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(104, 20);
            this.dtpData.TabIndex = 22;
            // 
            // frmGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCodGorjeta);
            this.Controls.Add(this.txtCodFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorGorjeta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtGorjeta);
            this.Controls.Add(this.cbbFuncionario);
            this.Controls.Add(this.cbbAvalia);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorConta);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.lblValorConta);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGorjeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbbAvalia;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.TextBox txtGorjeta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.TextBox txtCodGorjeta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}