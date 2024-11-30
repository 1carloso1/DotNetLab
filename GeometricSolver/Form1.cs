namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Label? lblBase2;
    TextBox? txtBase2;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;
    String valorEscogido = "";
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
       
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 350);
        //Etiqueta "Figura"
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);
        //Combobox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);
        //Etiqueta "Cálculo"
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);
        //Combobox Cálculos
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Périmetro");
        cmbCalculo.Items.Add("Área");
        cmbCalculo.Location = new Point(150, 40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);
        //Etiqueta "Altura"
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10, 80);
        lblAltura.Visible=false;
        //TextBox Altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100, 20);
        txtAltura.Location = new Point(60, 75);
        txtAltura.Visible=false;
        //Etiqueta "Base"
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10, 120);
        lblBase.Visible=false;
        //TextBox Base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 10);
        txtBase.Location = new Point(60, 115);
        txtBase.Visible=false;
        //Etiqueta "Base2"
        lblBase2 = new Label();
        lblBase2.Text = "Base 2";
        lblBase2.AutoSize = true;
        lblBase2.Location = new Point(7, 160);
        lblBase2.Visible = false;
        //TextBox Base2
        txtBase2 = new TextBox();
        txtBase2.Size = new Size(100, 10);
        txtBase2.Location = new Point(60, 155);
        txtBase2.Visible = false;
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);
        //Etiqueta "Resultado"
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);
        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(140, 275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblBase2);
        this.Controls.Add(txtBase2);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);

    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculo.SelectedIndex.ToString();
        int altura=0;
        int _base = 0;
        int _base2 = 0;

        if (txtBase.Text != "")
        {
            _base = Convert.ToInt32(txtBase.Text);
            if (valorEscogido == "AreaCuadrado")
            {
                txtResultado.Text = (_base * _base).ToString();
            }
            else if (valorEscogido == "PerimetroCuadrado")
            {
                txtResultado.Text = (_base * 4).ToString();
            }
        }
        if (txtAltura.Text != "" && txtBase.Text != "")
        {
            _base = Convert.ToInt32(txtBase.Text);
            altura = Convert.ToInt32(txtAltura.Text);
            if (valorEscogido == "AreaRectangulo")
            {
                txtResultado.Text = (altura*_base).ToString();
            }
            else if (valorEscogido == "PerimetroRectangulo")
            {
                txtResultado.Text = ((altura+_base)*2).ToString();
            }
            else if (valorEscogido == "AreaTriangulo")
            {
                txtResultado.Text = ((altura * _base)/2).ToString();
            }
        }
        if (txtAltura.Text != "" && txtBase.Text != "" && txtBase2.Text != "")
        {
            _base = Convert.ToInt32(txtBase.Text);
            _base2 = Convert.ToInt32(txtBase2.Text);
            altura = Convert.ToInt32(txtAltura.Text);
            if (valorEscogido == "PerimetroTriangulo")
            {
                txtResultado.Text = (altura + _base + _base2).ToString();
            }
        }

    }
    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblAltura.Visible = false;
                txtAltura.Visible = false;
                lblBase2.Visible = false;
                txtBase2.Visible = false;
                valorEscogido = "PerimetroCuadrado";
            }

            else if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblAltura.Visible = false;
                txtAltura.Visible = false;
                lblBase2.Visible = false;
                txtBase2.Visible = false;
                valorEscogido = "AreaCuadrado";
            }

            else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblBase2.Visible = false;
                txtBase2.Visible = false;
                valorEscogido = "AreaRectangulo";
            }

            else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblBase2.Visible = false;
                txtBase2.Visible = false;
                valorEscogido = "PerimetroRectangulo";
            }

            else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblBase2.Visible = false;
                txtBase2.Visible = false;
                valorEscogido = "AreaTriangulo";
            }

            else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lblBase2.Visible = true;
                txtBase2.Visible = true;
                valorEscogido = "PerimetroTriangulo";
            }
        }

    }
    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
        {
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblAltura.Visible = false;
            txtAltura.Visible = false;
            lblBase2.Visible = false;
            txtBase2.Visible = false;
            valorEscogido = "PerimetroCuadrado";
        }

        else if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
        {
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblAltura.Visible = false;
            txtAltura.Visible = false;
            lblBase2.Visible = false;
            txtBase2.Visible = false;
            valorEscogido = "AreaCuadrado";
        }

        else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
        {
            lblAltura.Visible = true;
            txtAltura.Visible = true;
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblBase2.Visible = false;
            txtBase2.Visible = false;
            valorEscogido = "AreaRectangulo";
        }

        else if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
        {
            lblAltura.Visible = true;
            txtAltura.Visible = true;
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblBase2.Visible = false;
            txtBase2.Visible = false;
            valorEscogido = "PerimetroRectangulo";
        }

        else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
        {
            lblAltura.Visible = true;
            txtAltura.Visible = true;
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblBase2.Visible = false;
            txtBase2.Visible = false;
            valorEscogido = "AreaTriangulo";
        }

        else if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
        {
            lblAltura.Visible = true;
            txtAltura.Visible = true;
            lblBase.Visible = true;
            txtBase.Visible = true;
            lblBase2.Visible = true;
            txtBase2.Visible = true;
            valorEscogido = "PerimetroTriangulo";
        }

    }
}
