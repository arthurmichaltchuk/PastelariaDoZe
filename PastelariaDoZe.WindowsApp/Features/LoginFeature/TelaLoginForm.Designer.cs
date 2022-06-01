
namespace PastelariaDoZe.WindowsApp.Features.LoginFeature
{
    partial class TelaLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModo = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.StatusStrip();
            this.labelFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(573, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.Transparent;
            this.btnModo.FlatAppearance.BorderSize = 0;
            this.btnModo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModo.ForeColor = System.Drawing.Color.Transparent;
            this.btnModo.Image = ((System.Drawing.Image)(resources.GetObject("btnModo.Image")));
            this.btnModo.Location = new System.Drawing.Point(533, 12);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(30, 30);
            this.btnModo.TabIndex = 19;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Footer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFooter});
            this.Footer.Location = new System.Drawing.Point(0, 312);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(614, 24);
            this.Footer.TabIndex = 17;
            this.Footer.Text = "statusStrip1";
            // 
            // labelFooter
            // 
            this.labelFooter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(91, 18);
            this.labelFooter.Text = "Bem vindo!";
            // 
            // btnLogar
            // 
            this.btnLogar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogar.Location = new System.Drawing.Point(262, 262);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(88, 36);
            this.btnLogar.TabIndex = 16;
            this.btnLogar.Text = "ENTRAR";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(105, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(179, 195);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(255, 27);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pastelaria do Zé";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(179, 150);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(255, 27);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuário:";
            // 
            // TelaLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLoginForm";
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.StatusStrip Footer;
        private System.Windows.Forms.ToolStripStatusLabel labelFooter;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
    }
}