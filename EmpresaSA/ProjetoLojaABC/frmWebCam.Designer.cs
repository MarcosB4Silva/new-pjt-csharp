
namespace ProjetoLojaABC
{
    partial class frmWebCam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebCam));
            this.pctCaptura = new System.Windows.Forms.PictureBox();
            this.cbbDispositivos = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDispositivos = new System.Windows.Forms.Label();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCaptura
            // 
            this.pctCaptura.Location = new System.Drawing.Point(12, 23);
            this.pctCaptura.Name = "pctCaptura";
            this.pctCaptura.Size = new System.Drawing.Size(355, 326);
            this.pctCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCaptura.TabIndex = 0;
            this.pctCaptura.TabStop = false;
            // 
            // cbbDispositivos
            // 
            this.cbbDispositivos.FormattingEnabled = true;
            this.cbbDispositivos.Location = new System.Drawing.Point(373, 39);
            this.cbbDispositivos.Name = "cbbDispositivos";
            this.cbbDispositivos.Size = new System.Drawing.Size(269, 21);
            this.cbbDispositivos.TabIndex = 1;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(438, 101);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(162, 60);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(438, 167);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(162, 60);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDispositivos
            // 
            this.lblDispositivos.AutoSize = true;
            this.lblDispositivos.Location = new System.Drawing.Point(370, 23);
            this.lblDispositivos.Name = "lblDispositivos";
            this.lblDispositivos.Size = new System.Drawing.Size(64, 13);
            this.lblDispositivos.TabIndex = 4;
            this.lblDispositivos.Text = "Dispositivo :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(438, 233);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(162, 60);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblDispositivos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.cbbDispositivos);
            this.Controls.Add(this.pctCaptura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWebCam";
            this.Text = "Loja - WebCam";
            this.Load += new System.EventHandler(this.frmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCaptura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCaptura;
        private System.Windows.Forms.ComboBox cbbDispositivos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDispositivos;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
    }
}