
namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    partial class TelaProdutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProdutoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_IdProduto = new System.Windows.Forms.TextBox();
            this.text_NomeProduto = new System.Windows.Forms.TextBox();
            this.bt_GravarFuncionario = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.date_ValidadeProduto = new System.Windows.Forms.DateTimePicker();
            this.text_Total = new System.Windows.Forms.TextBox();
            this.header_Funcionario = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.text_ValorUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Qntd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.header_Funcionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(280, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Validade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(330, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(81, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Id:";
            // 
            // text_IdProduto
            // 
            this.text_IdProduto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.text_IdProduto.Enabled = false;
            this.text_IdProduto.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.text_IdProduto.Location = new System.Drawing.Point(107, 53);
            this.text_IdProduto.Name = "text_IdProduto";
            this.text_IdProduto.Size = new System.Drawing.Size(116, 28);
            this.text_IdProduto.TabIndex = 8;
            // 
            // text_NomeProduto
            // 
            this.text_NomeProduto.Location = new System.Drawing.Point(107, 92);
            this.text_NomeProduto.Name = "text_NomeProduto";
            this.text_NomeProduto.Size = new System.Drawing.Size(387, 28);
            this.text_NomeProduto.TabIndex = 0;
            this.text_NomeProduto.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.text_NomeProduto.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // bt_GravarFuncionario
            // 
            this.bt_GravarFuncionario.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_GravarFuncionario.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_GravarFuncionario.Location = new System.Drawing.Point(312, 273);
            this.bt_GravarFuncionario.Name = "bt_GravarFuncionario";
            this.bt_GravarFuncionario.Size = new System.Drawing.Size(87, 27);
            this.bt_GravarFuncionario.TabIndex = 6;
            this.bt_GravarFuncionario.Text = "Gravar";
            this.bt_GravarFuncionario.UseVisualStyleBackColor = true;
            this.bt_GravarFuncionario.Click += new System.EventHandler(this.bt_GravarProduto_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancelar.Location = new System.Drawing.Point(407, 273);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(87, 27);
            this.bt_Cancelar.TabIndex = 7;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // date_ValidadeProduto
            // 
            this.date_ValidadeProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ValidadeProduto.Location = new System.Drawing.Point(380, 134);
            this.date_ValidadeProduto.Name = "date_ValidadeProduto";
            this.date_ValidadeProduto.Size = new System.Drawing.Size(114, 28);
            this.date_ValidadeProduto.TabIndex = 2;
            this.date_ValidadeProduto.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.date_ValidadeProduto.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // text_Total
            // 
            this.text_Total.Location = new System.Drawing.Point(378, 174);
            this.text_Total.Name = "text_Total";
            this.text_Total.Size = new System.Drawing.Size(116, 28);
            this.text_Total.TabIndex = 5;
            this.text_Total.Text = "0";
            this.text_Total.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.text_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.text_Total.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // header_Funcionario
            // 
            this.header_Funcionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header_Funcionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Funcionario.Controls.Add(this.label8);
            this.header_Funcionario.Location = new System.Drawing.Point(-3, -1);
            this.header_Funcionario.Name = "header_Funcionario";
            this.header_Funcionario.Size = new System.Drawing.Size(546, 29);
            this.header_Funcionario.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cadastro de Produtos";
            // 
            // text_ValorUnitario
            // 
            this.text_ValorUnitario.Location = new System.Drawing.Point(107, 136);
            this.text_ValorUnitario.Name = "text_ValorUnitario";
            this.text_ValorUnitario.Size = new System.Drawing.Size(116, 28);
            this.text_ValorUnitario.TabIndex = 12;
            this.text_ValorUnitario.Text = "0";
            this.text_ValorUnitario.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.text_ValorUnitario.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor unitário:";
            // 
            // text_Qntd
            // 
            this.text_Qntd.Location = new System.Drawing.Point(107, 174);
            this.text_Qntd.Name = "text_Qntd";
            this.text_Qntd.Size = new System.Drawing.Size(116, 28);
            this.text_Qntd.TabIndex = 14;
            this.text_Qntd.Text = "0";
            this.text_Qntd.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.text_Qntd.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantidade:";
            // 
            // TelaProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 327);
            this.Controls.Add(this.text_Qntd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_ValorUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header_Funcionario);
            this.Controls.Add(this.text_Total);
            this.Controls.Add(this.date_ValidadeProduto);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_GravarFuncionario);
            this.Controls.Add(this.text_NomeProduto);
            this.Controls.Add(this.text_IdProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaProdutoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.header_Funcionario.ResumeLayout(false);
            this.header_Funcionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_IdProduto;
        private System.Windows.Forms.TextBox text_NomeProduto;
        private System.Windows.Forms.Button bt_GravarFuncionario;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.DateTimePicker date_ValidadeProduto;
        private System.Windows.Forms.TextBox text_Total;
        private System.Windows.Forms.Panel header_Funcionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_ValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Qntd;
        private System.Windows.Forms.Label label4;
    }
}