﻿
namespace Zoologico
{
    partial class frmPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltbPesquisa = new System.Windows.Forms.ListBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gpbPesquisa.Controls.Add(this.cbbTipo);
            this.gpbPesquisa.Controls.Add(this.rdbTipo);
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbCodigo);
            this.gpbPesquisa.Location = new System.Drawing.Point(20, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(416, 87);
            this.gpbPesquisa.TabIndex = 1;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa por :";
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(198, 35);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(46, 17);
            this.rdbTipo.TabIndex = 3;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(106, 35);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(14, 35);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(78, 148);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(358, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(20, 204);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(175, 137);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(259, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(177, 58);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ltbPesquisa
            // 
            this.ltbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisa.FormattingEnabled = true;
            this.ltbPesquisa.ItemHeight = 20;
            this.ltbPesquisa.Location = new System.Drawing.Point(478, 12);
            this.ltbPesquisa.Name = "ltbPesquisa";
            this.ltbPesquisa.Size = new System.Drawing.Size(290, 324);
            this.ltbPesquisa.TabIndex = 9;
            this.ltbPesquisa.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisa_SelectedIndexChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(17, 151);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(259, 283);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(177, 58);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.ItemHeight = 13;
            this.cbbTipo.Items.AddRange(new object[] {
            "Elefante",
            "Leão",
            "Trigre",
            "Tatu",
            "Pato",
            "Macaco",
            "Girafa",
            "Crocodilo",
            "Zebra",
            "Urso",
            "Gato(a)"});
            this.cbbTipo.Location = new System.Drawing.Point(251, 35);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(159, 21);
            this.cbbTipo.TabIndex = 4;
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.ltbPesquisa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gpbPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoologico - Menu";
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbPesquisa;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbbTipo;
    }
}

