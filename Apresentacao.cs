using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POO
{
    class Apresentacao:Form
    {
        Automovel carr01 = new Automovel();

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
        Button blaze = new Button();

        Panel painelInfo = new Panel();
        public Apresentacao()
        {
            this.Text = "Concessionária auto-lendas";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;



            painelInfo.BackColor = Color.White;
            painelInfo.Size = new Size(300, 220);
            painelInfo.Location = new Point(40, 100);
            painelInfo.Visible = false;

            bumblebee.Text = "Carro 1";
            bumblebee.Size = new Size(120, 40);
            bumblebee.Location = new Point(40, 30);
            bumblebee.Click += clicar;
            bumblebee.BackColor = Color.White;

            opala.Text = "Carro 2";
            opala.Size = new Size(120, 40);
            opala.Location = new Point(180, 30);
            opala.Click += clicar;
            opala.BackColor = Color.White;

            relampago.Text = "Carro 3";
            relampago.Size = new Size(120, 40);
            relampago.Location = new Point(320, 30);
            relampago.Click += clicar;
            relampago.BackColor = Color.White;

            uno.Text = "Carro 4";
            uno.Size = new Size(120, 40);
            uno.Location = new Point(460, 30);
            uno.Click += clicar;
            uno.BackColor = Color.White;

            blaze.Text = "Carro 5";
            blaze.Size = new Size(120, 40);
            blaze.Location = new Point(600, 30);
            blaze.Click += clicar;
            blaze.BackColor = Color.White;

            txtMarca.AutoSize = true;
            txtMarca.Font = new Font("Arial", 10);
            txtMarca.Location = new Point(60, 120);
            txtMarca.BackColor = Color.White;

            txtModelo.AutoSize = true;
            txtModelo.Font = new Font("Arial", 10);
            txtModelo.Location = new Point(60, 160);
            txtModelo.BackColor = Color.White;

            txtAno.AutoSize = true;
            txtAno.Font = new Font("Arial", 10);
            txtAno.Location = new Point(60, 200);
            txtAno.BackColor = Color.White;

            txtVelocidade.AutoSize = true;
            txtVelocidade.Font = new Font("Arial", 10);
            txtVelocidade.Location = new Point(60, 240);
            txtVelocidade.BackColor = Color.White;

            txtFrear.AutoSize = true;
            txtFrear.Font = new Font("Arial", 10);
            txtFrear.Location = new Point(60, 280);
            txtFrear.BackColor = Color.White;

            img.Location = new Point(420, 120);
            img.Size = new Size(280, 200);
            img.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.AddRange(new Control[]
            {bumblebee, opala, relampago, uno, blaze, txtMarca, txtModelo, txtAno, txtVelocidade, txtFrear, img, painelInfo});
        }
        private void clicar( object sender , EventArgs e ) {

            painelInfo.Visible = true;

            if (sender == bumblebee)
            {
                carr01.Marca = "Transformes";
                carr01.Ano = "5067 A.C.";
                carr01.Modelo = "B-127";
                carr01.Velocidade = "1000000 km/h";

                txtMarca.Text = "Marca: " + carr01.Marca;
                txtModelo.Text = "Tipo: " + carr01.Modelo;
                txtAno.Text = "Ano: " + carr01.Ano;
                txtVelocidade.Text = carr01.Acelerar(carr01.Velocidade);
                txtFrear.Text = "Frear: " + carr01.Frear();

                img.Image = Properties.Resources.bumblebee;
            }

            else if (sender == uno)
            {
                carr01.Marca = "Incrivel";
                carr01.Ano = "2";
                carr01.Modelo = "4 portas";
                carr01.Velocidade = "1.079.252.849 km/h";

                txtMarca.Text = "Marca: " + carr01.Marca;
                txtModelo.Text ="Tipo: " + carr01.Modelo;
                txtAno.Text = "Ano: " + carr01.Ano;
                txtVelocidade.Text = carr01.Acelerar(carr01.Velocidade);
                txtFrear.Text = "Frear: " + carr01.Frear();

                img.Image = Properties.Resources.uno;
            }

            else if (sender == opala)
            {
                carr01.Marca = "Sobrenatural";
                carr01.Ano = "2005";
                carr01.Modelo = "Winchester";
                carr01.Velocidade = "315 km/h";

                txtMarca.Text = "Marca: " + carr01.Marca;
                txtModelo.Text = "Tipo: " + carr01.Modelo;
                txtAno.Text = "Ano: " + carr01.Ano;
                txtVelocidade.Text = carr01.Acelerar(carr01.Velocidade);
                txtFrear.Text = "Frear: " + carr01.Frear();

                img.Image = Properties.Resources.opala;
            }

            else if (sender == relampago)
            {
                carr01.Marca = "Velocidade";
                carr01.Ano = "Desconhecido";
                carr01.Modelo = "Katchau";
                carr01.Velocidade = "99² km/h";

                txtMarca.Text = "Marca: " + carr01.Marca;
                txtModelo.Text = "Tipo: " + carr01.Modelo;
                txtAno.Text = "Ano: " + carr01.Ano;
                txtVelocidade.Text = carr01.Acelerar(carr01.Velocidade);
                txtFrear.Text = "Frear: " + carr01.Frear();

                img.Image = Properties.Resources.relampago;
            }

            else if (sender == blaze)
            {
                carr01.Marca = "Velocidade";
                carr01.Ano = "Desconhecido";
                carr01.Modelo = "Katchau";
                carr01.Velocidade = "Velocidade Flamejante";

                txtMarca.Text = "Marca: " + carr01.Marca;
                txtModelo.Text = "Tipo: " + carr01.Modelo;
                txtAno.Text = "Ano: " + carr01.Ano;
                txtVelocidade.Text = carr01.Acelerar(carr01.Velocidade);
                txtFrear.Text = "Frear: " + carr01.Frear();

                img.Image = Properties.Resources.blaze;
            }
        }

    }
}
