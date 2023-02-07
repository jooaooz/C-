
namespace AppComponentes
{
    partial class frmCompontes
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lstListagem = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.cbbLista = new System.Windows.Forms.ComboBox();
            this.pctimagem = new System.Windows.Forms.PictureBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(110, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "insira seu nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(85, 72);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(120, 20);
            this.txtnome.TabIndex = 1;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(85, 147);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(120, 20);
            this.mskCPF.TabIndex = 2;
            // 
            // lstListagem
            // 
            this.lstListagem.FormattingEnabled = true;
            this.lstListagem.Location = new System.Drawing.Point(85, 212);
            this.lstListagem.Name = "lstListagem";
            this.lstListagem.Size = new System.Drawing.Size(120, 95);
            this.lstListagem.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(115, 398);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(105, 322);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(45, 17);
            this.ckbLivro.TabIndex = 5;
            this.ckbLivro.Text = "livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // cbbLista
            // 
            this.cbbLista.FormattingEnabled = true;
            this.cbbLista.Location = new System.Drawing.Point(363, 72);
            this.cbbLista.Name = "cbbLista";
            this.cbbLista.Size = new System.Drawing.Size(121, 21);
            this.cbbLista.TabIndex = 6;
            // 
            // pctimagem
            // 
            this.pctimagem.Location = new System.Drawing.Point(340, 147);
            this.pctimagem.Name = "pctimagem";
            this.pctimagem.Size = new System.Drawing.Size(158, 142);
            this.pctimagem.TabIndex = 7;
            this.pctimagem.TabStop = false;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(105, 345);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(72, 17);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // frmCompontes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.pctimagem);
            this.Controls.Add(this.cbbLista);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstListagem);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCompontes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ListBox lstListagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.ComboBox cbbLista;
        private System.Windows.Forms.PictureBox pctimagem;
        private System.Windows.Forms.RadioButton rdbMasculino;
    }
}

