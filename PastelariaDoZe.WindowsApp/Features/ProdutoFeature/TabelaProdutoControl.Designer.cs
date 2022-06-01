
namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    partial class TabelaProdutoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Location = new System.Drawing.Point(0, 0);
            this.gridProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidth = 51;
            this.gridProdutos.RowTemplate.Height = 24;
            this.gridProdutos.Size = new System.Drawing.Size(830, 623);
            this.gridProdutos.TabIndex = 0;
            // 
            // TabelaProdutoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridProdutos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabelaProdutoControl";
            this.Size = new System.Drawing.Size(830, 623);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridProdutos;
    }
}
