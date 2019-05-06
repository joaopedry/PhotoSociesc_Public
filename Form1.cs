using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form : System.Windows.Forms.Form
    {
        //Declarar variaveis
        int blurPorc = 1;

        public Form()
        {
            InitializeComponent();
        }

        //Botão Selecionar
        private void Seleciona_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            Bitmap Imagem;
            caixa.Filter = "Imagem JPG(.jpg)|*.jpg|Imagme bmp(.bmp)|*.bmp|Imagem Gif(.Gif)|*gif|Imagem Png(.png)|*png|Imagem TIFF(.tif)|*tif";
            caixa.InitialDirectory = @"C:\Users\'\Desktop\";
            caixa.Title = "Selecionar Imagem";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                Imagem = new Bitmap(Image.FromFile(caixa.FileName));
                pictureBoxOriginal.Image = Imagem;
            }
        }

        //Botão salvar
        private void Salva_Click(object sender, EventArgs e)
        {
            if (pictureBoxResultado.Image != null)
            {
                SaveFileDialog caixa = new SaveFileDialog();
                caixa.Filter = "Imagem Png(.png)|*png";
                caixa.DefaultExt = "png";
                caixa.Title = "Salvar Imagem";
                if (DialogResult.OK == caixa.ShowDialog())
                {
                    string nome = caixa.FileName;
                    Bitmap NovaImagem = new Bitmap(pictureBoxResultado.Image);
                    NovaImagem.Save(nome, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        //Escala Cinza
        private void EscalaCinza_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;

            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;
                    //Calcula todos os pixels para cinza
                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    
                    //Setando o novo valor dos pixels
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        //limpar imagem original
        private void Bt_limpar_original_Click(object sender, EventArgs e)
        {
            if (pictureBoxOriginal.Image != null)
            {
                this.pictureBoxOriginal.Image = null;
            }
        }

        //limpar imagem resultado
        private void Bt_limpar_resultado_Click(object sender, EventArgs e)
        {
            if (pictureBoxResultado.Image != null)
            {
                this.pictureBoxResultado.Image = null;
            }
        }

        //Negativo
        private void Bt_negativo_Click(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(pictureBoxOriginal.Image);
            Bitmap NovaImagem = new Bitmap(Imagem.Width, Imagem.Height);

            for (int i = 0; i < Imagem.Width; i++)
            {
                for (int j = 0; j < Imagem.Height; j++)
                {
                    //pega a cor original
                    Color originalColor = Imagem.GetPixel(i, j);
                    //Calcula para negativo
                    Color CorEmNegativo = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);

                    //setando o novo valor do pixel
                    NovaImagem.SetPixel(i, j, CorEmNegativo);
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        //Blur
        private void Bt_blur_Click(object sender, EventArgs e)
        {
            Bitmap imagem = new Bitmap(pictureBoxOriginal.Image);
            Bitmap NovaImagem = new Bitmap(imagem.Width, imagem.Height);
           
            for (int x = blurPorc; x <= imagem.Width - blurPorc; x++)
            {
                for (int y = blurPorc; y <= imagem.Width - blurPorc; y++)
                {
                    try
                    {
                        //Calculo dos pixels para alterar
                        Color prevX = imagem.GetPixel(x - blurPorc, y);
                        Color nextX = imagem.GetPixel(x + blurPorc, y);
                        Color prevY = imagem.GetPixel(x, y - blurPorc);
                        Color nextY = imagem.GetPixel(x, y + blurPorc);

                        int avgR = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int avgG = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int avgB = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        //Seta os novos valores dos pixels
                        NovaImagem.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                        
                    }
                    catch (Exception) { }
                }
            }
            pictureBoxResultado.Image = NovaImagem;
        }

        //Update no value do nivel do blur
        private void updateBlur(object sender, EventArgs e)
        {
            blurPorc = int.Parse(trackBar1.Value.ToString());
        }

        //Sepia
        private void Bt_sepia_Click(object sender, EventArgs e)
        {
            Bitmap imagem = new Bitmap(pictureBoxOriginal.Image);

            int width = imagem.Width;
            int height = imagem.Height;
            Color p;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pegando valor do pixel
                    p = imagem.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //calcula os valores para altreração
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //setando o novo valor do pixel
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    //setando novo valor do pixel
                    imagem.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBoxResultado.Image = imagem;
        }

        //RBG
        private void Bt_RGB_Click(object sender, EventArgs e)
        {
            Bitmap imagem = new Bitmap(pictureBoxOriginal.Image);

            int width = imagem.Width;
            int height = imagem.Height;

            //Bitmap para cada cor
            Bitmap rbmp = new Bitmap(imagem);
            Bitmap gbmp = new Bitmap(imagem);
            Bitmap bbmp = new Bitmap(imagem);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pegando valor do pixel
                    Color p = imagem.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //setando pixel red
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));

                    //setando pixel green
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));

                    //setando pixel blue
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                }
            }

            //exibindo o resultado escolhido no pb
            if (rb_red.Checked)
            {
                pictureBoxResultado.Image = rbmp;
            }
            else if (rb_green.Checked)
            {
                pictureBoxResultado.Image = gbmp;
            }
            else if (rb_blue.Checked)
            {
                pictureBoxResultado.Image = bbmp;
            }
        }

        //Ausencia de cor
        private void Bt_Ausencia_Click(object sender, EventArgs e)
        {
            Bitmap imagem = new Bitmap(pictureBoxOriginal.Image);

            int width = imagem.Width;
            int height = imagem.Height;
            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pegando valor do pixel
                    p = imagem.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    //passando novo valor para o pixel
                    if (rb_blue_ausencia.Checked)
                    {
                        b = g;
                    }
                    else if (rb_green_ausencia.Checked)
                    {
                        g = b;
                    }
                    else if (rb_red_ausencia.Checked)
                    {
                        r = g;
                    }

                    //setando novo valor do pixel
                    imagem.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBoxResultado.Image = imagem;
        }

        private void PictureBoxOriginal_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Rb_green_ausencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Flp_ausencia_Paint(object sender, PaintEventArgs e)
        {

        }
        //fim
    }
}