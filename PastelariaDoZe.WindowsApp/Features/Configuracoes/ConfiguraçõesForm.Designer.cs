namespace PastelariaDoZe.WindowsApp.Features.Configuracoes
{
    partial class ConfiguraçõesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguraçõesForm));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.header_Combustivel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MultaAtraso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_JurosDiarios = new System.Windows.Forms.TextBox();
            this.comboBoxLinguagem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkboxReiniciar = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.header_Combustivel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(572, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 27);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Gravar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(666, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // header_Combustivel
            // 
            this.header_Combustivel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header_Combustivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_Combustivel.Controls.Add(this.label8);
            this.header_Combustivel.Location = new System.Drawing.Point(-3, -1);
            this.header_Combustivel.Name = "header_Combustivel";
            this.header_Combustivel.Size = new System.Drawing.Size(772, 29);
            this.header_Combustivel.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Configurações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(516, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Linguagem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Multa por atraso (R$)";
            // 
            // txt_MultaAtraso
            // 
            this.txt_MultaAtraso.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MultaAtraso.Location = new System.Drawing.Point(48, 166);
            this.txt_MultaAtraso.Name = "txt_MultaAtraso";
            this.txt_MultaAtraso.Size = new System.Drawing.Size(252, 31);
            this.txt_MultaAtraso.TabIndex = 22;
            this.txt_MultaAtraso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxJustNumbers_KeyPress);
            this.txt_MultaAtraso.Leave += new System.EventHandler(this.txtBoxZerado_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Percentual Diário de juros (%)";
            // 
            // txt_JurosDiarios
            // 
            this.txt_JurosDiarios.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_JurosDiarios.Location = new System.Drawing.Point(48, 59);
            this.txt_JurosDiarios.Name = "txt_JurosDiarios";
            this.txt_JurosDiarios.Size = new System.Drawing.Size(252, 31);
            this.txt_JurosDiarios.TabIndex = 24;
            this.txt_JurosDiarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxJustNumbers_KeyPress);
            this.txt_JurosDiarios.Leave += new System.EventHandler(this.txtBoxZerado_Leave);
            // 
            // comboBoxLinguagem
            // 
            this.comboBoxLinguagem.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLinguagem.FormattingEnabled = true;
            this.comboBoxLinguagem.Items.AddRange(new object[] {
            "en-EN",
            "es-ES",
            "pt-BR"});
            this.comboBoxLinguagem.Location = new System.Drawing.Point(492, 116);
            this.comboBoxLinguagem.Name = "comboBoxLinguagem";
            this.comboBoxLinguagem.Size = new System.Drawing.Size(151, 29);
            this.comboBoxLinguagem.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txt_JurosDiarios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MultaAtraso);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 222);
            this.panel1.TabIndex = 26;
            // 
            // checkboxReiniciar
            // 
            this.checkboxReiniciar.AutoSize = true;
            this.checkboxReiniciar.Location = new System.Drawing.Point(492, 170);
            this.checkboxReiniciar.Name = "checkboxReiniciar";
            this.checkboxReiniciar.Size = new System.Drawing.Size(157, 21);
            this.checkboxReiniciar.TabIndex = 27;
            this.checkboxReiniciar.Text = "Reiniciar aplicação";
            this.checkboxReiniciar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(741, 31);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PastelariaDb;Integrated Securi" +
    "ty=True";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "ConnectionString";
            // 
            // ConfiguraçõesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkboxReiniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxLinguagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.header_Combustivel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguraçõesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preço Combustível";
            this.header_Combustivel.ResumeLayout(false);
            this.header_Combustivel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel header_Combustivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MultaAtraso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_JurosDiarios;
        private System.Windows.Forms.ComboBox comboBoxLinguagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkboxReiniciar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}