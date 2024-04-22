using System;

namespace Calculadoradat6
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBarra = new System.Windows.Forms.Button();
            this.buttonVezes = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonMais = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 458);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(291, 108);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "99999999";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonBarra, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonVezes, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonVirgula, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonIgual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonMais, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonMenos, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonTres, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonDois, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonUm, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonSeis, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCinco, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonQuatro, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonNove, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonOito, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSete, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonCopiar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonApagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonLimpar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(291, 338);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonBarra
            // 
            this.buttonBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonBarra.Location = new System.Drawing.Point(219, 70);
            this.buttonBarra.Name = "buttonBarra";
            this.buttonBarra.Size = new System.Drawing.Size(69, 61);
            this.buttonBarra.TabIndex = 18;
            this.buttonBarra.Text = "/";
            this.buttonBarra.UseVisualStyleBackColor = true;
            this.buttonBarra.Click += new System.EventHandler(this.buttonBarra_Click);
            // 
            // buttonVezes
            // 
            this.buttonVezes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonVezes.Location = new System.Drawing.Point(219, 3);
            this.buttonVezes.Name = "buttonVezes";
            this.buttonVezes.Size = new System.Drawing.Size(69, 61);
            this.buttonVezes.TabIndex = 14;
            this.buttonVezes.Text = "x";
            this.buttonVezes.UseVisualStyleBackColor = true;
            this.buttonVezes.Click += new System.EventHandler(this.buttonVezes_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonZero.Location = new System.Drawing.Point(75, 271);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(66, 64);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonVirgula.Location = new System.Drawing.Point(147, 271);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(66, 64);
            this.buttonVirgula.TabIndex = 12;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = true;
            // 
            // buttonIgual
            // 
            this.buttonIgual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonIgual.Location = new System.Drawing.Point(219, 271);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(69, 64);
            this.buttonIgual.TabIndex = 17;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonMais
            // 
            this.buttonMais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonMais.Location = new System.Drawing.Point(219, 204);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(69, 61);
            this.buttonMais.TabIndex = 16;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = true;
            this.buttonMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonMenos.Location = new System.Drawing.Point(219, 137);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(69, 61);
            this.buttonMenos.TabIndex = 15;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonTres
            // 
            this.buttonTres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonTres.Location = new System.Drawing.Point(147, 204);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(66, 61);
            this.buttonTres.TabIndex = 11;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = true;
            this.buttonTres.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonDois
            // 
            this.buttonDois.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonDois.Location = new System.Drawing.Point(75, 204);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(66, 61);
            this.buttonDois.TabIndex = 10;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = true;
            this.buttonDois.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonUm
            // 
            this.buttonUm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonUm.Location = new System.Drawing.Point(3, 204);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(66, 61);
            this.buttonUm.TabIndex = 9;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = true;
            this.buttonUm.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonSeis.Location = new System.Drawing.Point(147, 137);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(66, 61);
            this.buttonSeis.TabIndex = 7;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = true;
            this.buttonSeis.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonCinco
            // 
            this.buttonCinco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonCinco.Location = new System.Drawing.Point(75, 137);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(66, 61);
            this.buttonCinco.TabIndex = 6;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = true;
            this.buttonCinco.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonQuatro.Location = new System.Drawing.Point(3, 137);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(66, 61);
            this.buttonQuatro.TabIndex = 5;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = true;
            this.buttonQuatro.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonNove
            // 
            this.buttonNove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonNove.Location = new System.Drawing.Point(147, 70);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(66, 61);
            this.buttonNove.TabIndex = 3;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = true;
            this.buttonNove.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonOito.Location = new System.Drawing.Point(75, 70);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(66, 61);
            this.buttonOito.TabIndex = 2;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = true;
            this.buttonOito.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonSete
            // 
            this.buttonSete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.buttonSete.Location = new System.Drawing.Point(3, 70);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(66, 61);
            this.buttonSete.TabIndex = 1;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = true;
            this.buttonSete.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCopiar.Location = new System.Drawing.Point(147, 3);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(66, 61);
            this.buttonCopiar.TabIndex = 19;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonApagar.Location = new System.Drawing.Point(75, 3);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(66, 61);
            this.buttonApagar.TabIndex = 20;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click_1);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLimpar.Location = new System.Drawing.Point(3, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(66, 61);
            this.buttonLimpar.TabIndex = 21;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculadora da Isa ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonQuatro;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonVezes;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonBarra;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

