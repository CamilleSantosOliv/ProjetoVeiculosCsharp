namespace SQLServerC {
    partial class FrmVeiculosAdicionar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculosAdicionar));
            this.label2 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblAutomatico = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtFabricacao = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxAutomatico = new System.Windows.Forms.ComboBox();
            this.cbxCombustivel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAno.Location = new System.Drawing.Point(114, 228);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 20);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano";
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoFabricacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(600, 231);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(161, 20);
            this.lblAnoFabricacao.TabIndex = 3;
            this.lblAnoFabricacao.Text = "Ano de fabricação";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCor.Location = new System.Drawing.Point(114, 267);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(39, 20);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCombustivel.Location = new System.Drawing.Point(647, 306);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(112, 20);
            this.lblCombustivel.TabIndex = 5;
            this.lblCombustivel.Text = "Combustível";
            // 
            // lblAutomatico
            // 
            this.lblAutomatico.AutoSize = true;
            this.lblAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomatico.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAutomatico.Location = new System.Drawing.Point(114, 303);
            this.lblAutomatico.Name = "lblAutomatico";
            this.lblAutomatico.Size = new System.Drawing.Size(103, 20);
            this.lblAutomatico.TabIndex = 6;
            this.lblAutomatico.Text = "Automático";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValor.Location = new System.Drawing.Point(114, 340);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(53, 20);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(329, 153);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(617, 27);
            this.txtNome.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtModelo.Location = new System.Drawing.Point(329, 186);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(617, 27);
            this.txtModelo.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAno.Location = new System.Drawing.Point(329, 228);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(127, 27);
            this.txtAno.TabIndex = 10;
            // 
            // txtFabricacao
            // 
            this.txtFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFabricacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFabricacao.Location = new System.Drawing.Point(788, 228);
            this.txtFabricacao.Name = "txtFabricacao";
            this.txtFabricacao.Size = new System.Drawing.Size(158, 27);
            this.txtFabricacao.TabIndex = 11;
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCor.Location = new System.Drawing.Point(329, 264);
            this.txtCor.MaxLength = 10;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(617, 27);
            this.txtCor.TabIndex = 12;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValor.Location = new System.Drawing.Point(329, 337);
            this.txtValor.MaxLength = 18;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(187, 27);
            this.txtValor.TabIndex = 13;
            // 
            // cbxAutomatico
            // 
            this.cbxAutomatico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAutomatico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxAutomatico.FormattingEnabled = true;
            this.cbxAutomatico.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbxAutomatico.Location = new System.Drawing.Point(329, 298);
            this.cbxAutomatico.Name = "cbxAutomatico";
            this.cbxAutomatico.Size = new System.Drawing.Size(127, 28);
            this.cbxAutomatico.TabIndex = 14;
            // 
            // cbxCombustivel
            // 
            this.cbxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCombustivel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCombustivel.FormattingEnabled = true;
            this.cbxCombustivel.Items.AddRange(new object[] {
            "1 Gasolina",
            "2 Álcool",
            "3 Flex",
            "4 Diesel",
            "5 Gás Natural"});
            this.cbxCombustivel.Location = new System.Drawing.Point(788, 303);
            this.cbxCombustivel.Name = "cbxCombustivel";
            this.cbxCombustivel.Size = new System.Drawing.Size(158, 28);
            this.cbxCombustivel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(344, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 80);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veículos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Maroon;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Location = new System.Drawing.Point(552, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 40);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "txtStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(114, 160);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(168, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Fabricante / Marca";
            // 
            // FrmVeiculosAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1081, 519);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCombustivel);
            this.Controls.Add(this.cbxAutomatico);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtFabricacao);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblAutomatico);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmVeiculosAdicionar";
            this.Text = "Adicionar carros";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblAutomatico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtFabricacao;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxAutomatico;
        private System.Windows.Forms.ComboBox cbxCombustivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblNome;
    }
}