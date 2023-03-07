namespace Atividade_APPD__Aula4
{
    partial class Funcionário
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbSalario = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtValorHora = new System.Windows.Forms.TextBox();
            this.TxtValorTrabalhado = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas trabalhadas:";
            // 
            // LbSalario
            // 
            this.LbSalario.AutoSize = true;
            this.LbSalario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSalario.Location = new System.Drawing.Point(16, 256);
            this.LbSalario.Name = "LbSalario";
            this.LbSalario.Size = new System.Drawing.Size(82, 24);
            this.LbSalario.TabIndex = 4;
            this.LbSalario.Text = "Salário:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(65, 65);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(264, 26);
            this.TxtNome.TabIndex = 6;
            // 
            // TxtValorHora
            // 
            this.TxtValorHora.Location = new System.Drawing.Point(100, 110);
            this.TxtValorHora.Name = "TxtValorHora";
            this.TxtValorHora.Size = new System.Drawing.Size(102, 26);
            this.TxtValorHora.TabIndex = 7;
            // 
            // TxtValorTrabalhado
            // 
            this.TxtValorTrabalhado.Location = new System.Drawing.Point(155, 158);
            this.TxtValorTrabalhado.Name = "TxtValorTrabalhado";
            this.TxtValorTrabalhado.Size = new System.Drawing.Size(104, 26);
            this.TxtValorTrabalhado.TabIndex = 8;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(100, 254);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.ReadOnly = true;
            this.TxtSalario.Size = new System.Drawing.Size(100, 26);
            this.TxtSalario.TabIndex = 9;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(237, 247);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(92, 39);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(59, 21);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(141, 26);
            this.TxtCPF.TabIndex = 11;
            // 
            // Funcionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 300);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.TxtValorTrabalhado);
            this.Controls.Add(this.TxtValorHora);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LbSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Funcionário";
            this.Text = "Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LbSalario;
        private TextBox TxtNome;
        private TextBox TxtValorHora;
        private TextBox TxtValorTrabalhado;
        private TextBox TxtSalario;
        private Button BtnCalcular;
        private MaskedTextBox TxtCPF;
    }
}