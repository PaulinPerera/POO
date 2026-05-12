using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    class Apresentacao:Form
    {
        // criar um objeto do automovel
        Automovel carr01 = new Automovel();
        Automovel carro02 = new Automovel();
        Automovel carro03 = new Automovel();
        Automovel carro04 = new Automovel();

        // Objeto
        PictureBox img = new PictureBox();
        Label txtMarca = new Label();
        Label txtTipo = new Label();
        Label txtAno = new Label();
        Label txtVelocidade = new Label();
        Label txtModelo = new Label();
        Label txtFrear = new Label();

        Button bumblebee  = new Button() ;
        Button opala = new Button();
        Button relampago = new Button();
        Button uno = new Button();

        // toda classe tem um construtor
        public Apresentacao()
        {
            this.Text = "Modelos de carros MUITO AURA 67676767";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ================= BOTÕES =================

            bumblebee.Text = "Carro 1 :)";
            bumblebee.Size = new Size(120, 40);
            bumblebee.Location = new Point(30, 30);
            bumblebee.Click += clicar;

            opala.Text = "Carro 2 :(";
            opala.Size = new Size(120, 40);
            opala.Location = new Point(30, 80);
            opala.Click += clicar;

            relampago.Text = "Carro 3 :()";
            relampago.Size = new Size(120, 40);
            relampago.Location = new Point(30, 130);
            relampago.Click += clicar;

            uno.Text = "Carro 4 :O";
            uno.Size = new Size(120, 40);
            uno.Location = new Point(30, 180);
            uno.Click += clicar;

            // ================= LABELS =================

            txtMarca.AutoSize = true;
            txtMarca.Font = new Font("Arial", 10, FontStyle.Bold);
            txtMarca.Location = new Point(200, 50);

            txtModelo.AutoSize = true;
            txtModelo.Font = new Font("Arial", 10, FontStyle.Bold);
            txtModelo.Location = new Point(200, 90);

            txtAno.AutoSize = true;
            txtAno.Font = new Font("Arial", 10, FontStyle.Bold);
            txtAno.Location = new Point(200, 130);

            txtVelocidade.AutoSize = true;
            txtVelocidade.Font = new Font("Arial", 10, FontStyle.Bold);
            txtVelocidade.Location = new Point(200, 170);

            txtFrear.AutoSize = true;
            txtFrear.Font = new Font("Arial", 10, FontStyle.Bold);
            txtFrear.Location = new Point(200, 210);

            // ================= IMAGEM =================

            img.Location = new Point(450, 50);
            img.Size = new Size(280, 200);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.BorderStyle = BorderStyle.FixedSingle;

            // ================= CONTROLES =================

            this.Controls.AddRange(new Control[]
            {
        bumblebee,
        opala,
        relampago,
        uno,

        txtMarca,
        txtModelo,
        txtAno,
        txtVelocidade,
        txtFrear,

        img
            });
        }

        // metodo de Evento
        private void clicar( object sender , EventArgs e ) {

            if (sender == bumblebee)
            {
                carr01.Marca = "Transformes";
                carr01.Ano = "5067 A.C.";
                carr01.Modelo = "B-127";
                carr01.Velocidade = "1000000 km/h";

                txtMarca.Text = " Marca : " + carr01.Marca;
                txtModelo.Text = "Tipo :" + carr01.Modelo;
                txtAno.Text = " Ano : " + carr01.Ano;
                txtVelocidade.AutoSize = true;
                txtVelocidade.Text = carr01.Acelerar("120");
                txtFrear.Text = " Frear : " + carr01.Frear();

                img.Image = Image.FromFile(@"C:\Users\LabInfo\Desktop\Nova pasta\IMG\bumblebee.jpg");
            }

            else if (sender == uno)
            {
                carr01.Marca = "Incrivel";
                carr01.Ano = "2";
                carr01.Modelo = "4 portas";
                carr01.Velocidade = "1.079.252.849 km/h";

                txtMarca.Text = " Marca : " + carr01.Marca;
                txtModelo.Text = "Tipo :" + carr01.Modelo;
                txtAno.Text = " Ano : " + carr01.Ano;
                txtVelocidade.AutoSize = true;
                txtVelocidade.Text = carr01.Acelerar("120");
                txtFrear.Text = " Frear : " + carr01.Frear();

                img.Image = Image.FromFile(@"C:\Users\LabInfo\Desktop\Nova pasta\IMG\uno.jpg");
            }

            else if (sender == opala)
            {
                carr01.Marca = "Sobrenatural";
                carr01.Ano = "2005";
                carr01.Modelo = "Winchester";
                carr01.Velocidade = "315 km/h";

                txtMarca.Text = " Marca : " + carr01.Marca;
                txtModelo.Text = "Tipo :" + carr01.Modelo;
                txtAno.Text = " Ano : " + carr01.Ano;
                txtVelocidade.AutoSize = true;
                txtVelocidade.Text = carr01.Acelerar("120");
                txtFrear.Text = " Frear : " + carr01.Frear();

                img.Image = Image.FromFile(@"C:\Users\LabInfo\Desktop\Nova pasta\IMG\opala.jpg");
            }

            else if (sender == relampago)
            {
                carr01.Marca = "Velocidade";
                carr01.Ano = "Desconhecido";
                carr01.Modelo = "Katchau";
                carr01.Velocidade = "Incompreencivel";

                txtMarca.Text = " Marca : " + carr01.Marca;
                txtModelo.Text = "Tipo :" + carr01.Modelo;
                txtAno.Text = " Ano : " + carr01.Ano;
                txtVelocidade.AutoSize = true;
                txtVelocidade.Text = carr01.Velocidade;
                txtFrear.Text = " Frear : " + carr01.Frear();

                img.Image = Image.FromFile(@"C:\Users\LabInfo\Desktop\Nova pasta\IMG\relampago.jpg");
            }
        }

    }
}
