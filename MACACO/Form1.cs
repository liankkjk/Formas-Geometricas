using System;
using System.Windows.Forms;

namespace MACACO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    switch (cmbForma.Text)
                    {
                        case "Quadrado":
                                ExibirCampos(false, true, false, false);
                        break;
                            case "Circulo":
                                ExibirCampos(false, false, true, false);
                        break;
                            case "Retângulo":
                                ExibirCampos(true, false, false, false);
                        break;
                            case "Triângulo":
                                ExibirCampos(true, true, false, true);
                        break;
                        default:
                                break;
                    }
        }

        private void ExibirCampos(bool ExibirBaseAltura, bool ExibirLado, bool ExibirRaio, bool ExibirInfoTri)
        {
            lblAltura.Visible = ExibirBaseAltura;
            txtAltura.Visible = ExibirBaseAltura;

            lblBase.Visible = ExibirBaseAltura;
            txtBase.Visible = ExibirBaseAltura;

            lblLado.Visible = ExibirLado;
            txtLado.Visible = ExibirLado;

            lblRaio.Visible = ExibirRaio;
            txtRaio.Visible = ExibirRaio;

            cmbTriangulo.Visible = ExibirInfoTri;
            lblTriangulo.Visible = ExibirInfoTri;
            lblHipotenusa.Visible = ExibirInfoTri;
            txtHipotenusa.Visible = ExibirInfoTri;
        }

        private bool ValidarCamposTxt()
        {
            var objeto = cmbForma.SelectedItem;

            if (objeto is "Quadrado")
            {
                if (string.IsNullOrWhiteSpace(txtLado.Text))
                {
                    MessageBox.Show("Preencha o campo Lado(s)");
                    return false;
                }
            }
            else if (objeto is "Retângulo")
            {
                if (string.IsNullOrWhiteSpace(txtAltura.Text) || string.IsNullOrWhiteSpace(txtBase.Text))
                {
                    MessageBox.Show("Preencha os campos Altura e Base corretamente!");
                    return false;
                }
            }
            else if (objeto is "Circulo")
            {
                if (string.IsNullOrWhiteSpace(txtRaio.Text))
                {
                    MessageBox.Show("Preencha o campo Raio corretamente!");
                    return false;
                }
            }
            else if (objeto is "Triângulo")
            {
                if (string.IsNullOrWhiteSpace(txtAltura.Text) || string.IsNullOrWhiteSpace(txtBase.Text) || string.IsNullOrWhiteSpace(txtLado.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Forma geométrica desconhecida!");
                return false;
            }

            return true;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposTxt() == true)
            {

                switch (cmbForma.Text)
                {
                    case "Quadrado":
                        FormaGeometrica objeto;
                        objeto = new Quadrado()
                        {
                            Lado = Convert.ToDouble(txtLado.Text)
                        };
                        cmbObjetos.Items.Add(objeto);
                        txtLado.Clear();
                        
                        break;
                    case "Circulo":
                        objeto = new Circulo()
                        {
                            Raio = Convert.ToDouble(txtRaio.Text)
                        };
                        cmbObjetos.Items.Add(objeto);
                        txtRaio.Clear();
                        break;
                    case "Retângulo":
                        objeto = new Retangulo()
                        {
                            BaseRet = Convert.ToDouble(txtBase.Text),
                            Altura = Convert.ToDouble(txtAltura.Text)
                        };
                        cmbObjetos.Items.Add(objeto);
                        txtBase.Clear();
                        txtAltura.Clear();
                        break;
                    case "Triângulo":
                            switch(cmbTriangulo.Text)
                            {
                                case "Equilátero":
                                    objeto = new TrianguloEquilatero()
                                    {
                                        BaseTri = Convert.ToDouble(txtBase.Text),
                                        Altura = Convert.ToDouble(txtAltura.Text),
                                        Lado = Convert.ToDouble(txtLado.Text)
                                    };
                                    cmbObjetos.Items.Add(objeto);
                                    txtAltura.Clear();
                                    txtLado.Clear();
                                    txtBase.Clear();
                                    break;
                                case "Isósceles":
                                    objeto = new TrianguloIsosceles()
                                    {
                                        BaseTri = Convert.ToDouble(txtBase.Text),
                                        Altura = Convert.ToDouble(txtAltura.Text),
                                        Lado = Convert.ToDouble(txtLado.Text)
                                    };
                                    cmbObjetos.Items.Add(objeto);
                                    txtAltura.Clear();
                                    txtLado.Clear();
                                    txtBase.Clear();
                                    break;
                                case "Reto":
                                    objeto = new TrianguloReto()
                                    {
                                        BaseTri = Convert.ToDouble(txtBase.Text),
                                        Altura = Convert.ToDouble(txtAltura.Text),
                                        Lado = Convert.ToDouble(txtLado.Text)
                                    };
                                    cmbObjetos.Items.Add(objeto);
                                    txtAltura.Clear();
                                    txtBase.Clear();
                                    txtLado.Clear();
                                    break;
                            }
                        break;
                    default:
                        break;
                }

            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica objeto = cmbObjetos.SelectedItem as FormaGeometrica;


            if (objeto != null)
            {
                txtArea.Text = objeto.CalcularArea().ToString();
                txtPerimetro.Text = objeto.CalcularPerimetro().ToString();

                if (objeto is Triangulo triangulo)
                {
                    txtHipotenusa.Text = triangulo.CalcularHipotenusa().ToString();
                }
                else
                {
                    txtHipotenusa.Text = "";
                }
            }

        }

        

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTriangulo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
