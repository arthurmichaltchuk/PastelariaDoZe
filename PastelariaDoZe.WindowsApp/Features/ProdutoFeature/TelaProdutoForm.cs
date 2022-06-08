﻿using PastelariaDoZe.Dominio.ProdutoModule;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace PastelariaDoZe.WindowsApp.Features.ProdutoFeature
{
    public partial class TelaProdutoForm : Form
    {
        private Produto produto;
        public TelaProdutoForm()
        {
            InitializeComponent();
            SetColor();
            produto = new();
        }

        private void SetColor()
        {

        }

        public Produto Produto
        {
            get { return produto; }

            set
            {
                produto = value;
                text_IdProduto.Text = produto.Id.ToString();
                text_NomeProduto.Text = produto.Nome;
                text_ValorUnitario.Text = produto.ValorUnitario.ToString();
                text_Qntd.Text = produto.Quantidade.ToString();
                date_ValidadeProduto.Value = Convert.ToDateTime(produto.DataValidade);
                text_Total.Text = produto.Quantidade.ToString();
                if (produto.Foto != null)
                {
                    pictureBoxImagem.Image = (Image)(new Bitmap(ConverteByteArrayParaImagem(produto.Foto), new Size(214, 126)));
                    pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        private void TelaprodutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void bt_GravarProduto_Click(object sender, EventArgs e)
        {
            ConfigurarProduto();

            string resultadoValidacao = produto.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void ConfigurarProduto()
        {
            produto.Nome = text_NomeProduto.Text;
            produto.ValorUnitario = text_ValorUnitario.Text == "" ? 0 : Convert.ToDouble(text_ValorUnitario.Text);
            produto.Quantidade = text_Qntd.Text == "" ? 0 : Convert.ToInt32(text_Qntd.Text);
            produto.DataValidade = date_ValidadeProduto.Value;
            produto.Foto = ConverteImagemParaByteArray(pictureBoxImagem.Image, pictureBoxImagem);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        public void txtCampo_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }

        public void txtCampo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.LightCyan;
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Title = "Imagem do produto";
            openFileDialogImagem.Filter = "Images (*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.)| *.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.icon; *.JFIF";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);

                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(214, 126)));

                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public static byte[] ConverteImagemParaByteArray(Image img, PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            if (pictureBox.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }

        public static Image ConverteByteArrayParaImagem(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new ImageConverter();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch
            {
                return null;
            }
        }
    }
}
