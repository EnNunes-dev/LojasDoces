namespace LojasDoces
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeDoces = new Label();
            textNomeDoce = new TextBox();
            lblPrecoUnitario = new Label();
            lblIdadeCliente = new Label();
            lblQuantidade = new Label();
            lblParcela = new Label();
            lblValorFinal = new Label();
            lblNome = new Label();
            lblDesconto = new Label();
            lblStatus = new Label();
            textPrecoUnitario = new TextBox();
            textQuantidade = new TextBox();
            textIdadeCliente = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNomeDoces
            // 
            lblNomeDoces.AutoSize = true;
            lblNomeDoces.Location = new Point(275, 40);
            lblNomeDoces.Name = "lblNomeDoces";
            lblNomeDoces.Size = new Size(70, 15);
            lblNomeDoces.TabIndex = 0;
            lblNomeDoces.Text = "Nome Doce";
            lblNomeDoces.Click += label1_Click;
            // 
            // textNomeDoce
            // 
            textNomeDoce.Location = new Point(374, 37);
            textNomeDoce.Name = "textNomeDoce";
            textNomeDoce.Size = new Size(100, 23);
            textNomeDoce.TabIndex = 1;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(275, 103);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(82, 15);
            lblPrecoUnitario.TabIndex = 2;
            lblPrecoUnitario.Text = "Preço Unitário";
            lblPrecoUnitario.Click += label2_Click;
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(275, 237);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(76, 15);
            lblIdadeCliente.TabIndex = 3;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(275, 173);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(302, 411);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 5;
            lblParcela.Text = "Parcela";
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(302, 365);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(60, 15);
            lblValorFinal.TabIndex = 6;
            lblValorFinal.Text = "Valor total";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(302, 292);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(302, 327);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 8;
            lblDesconto.Text = "Desconto";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(302, 456);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // textPrecoUnitario
            // 
            textPrecoUnitario.Location = new Point(374, 103);
            textPrecoUnitario.Name = "textPrecoUnitario";
            textPrecoUnitario.Size = new Size(100, 23);
            textPrecoUnitario.TabIndex = 10;
            // 
            // textQuantidade
            // 
            textQuantidade.Location = new Point(374, 173);
            textQuantidade.Name = "textQuantidade";
            textQuantidade.Size = new Size(100, 23);
            textQuantidade.TabIndex = 11;
            // 
            // textIdadeCliente
            // 
            textIdadeCliente.Location = new Point(374, 237);
            textIdadeCliente.Name = "textIdadeCliente";
            textIdadeCliente.Size = new Size(100, 23);
            textIdadeCliente.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(339, 510);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 567);
            Controls.Add(btnCalcular);
            Controls.Add(textIdadeCliente);
            Controls.Add(textQuantidade);
            Controls.Add(textPrecoUnitario);
            Controls.Add(lblStatus);
            Controls.Add(lblDesconto);
            Controls.Add(lblNome);
            Controls.Add(lblValorFinal);
            Controls.Add(lblParcela);
            Controls.Add(lblQuantidade);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(textNomeDoce);
            Controls.Add(lblNomeDoces);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoces;
        private TextBox textNomeDoce;
        private Label lblPrecoUnitario;
        private Label lblIdadeCliente;
        private Label lblQuantidade;
        private Label lblParcela;
        private Label lblValorFinal;
        private Label lblNome;
        private Label lblDesconto;
        private Label lblStatus;
        private TextBox textPrecoUnitario;
        private TextBox textQuantidade;
        private TextBox textIdadeCliente;
        private Button btnCalcular;
    }
}
