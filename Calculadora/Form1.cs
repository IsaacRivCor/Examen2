namespace Calculadora;

public partial class Form1 : Form
{
    private Button btnBorrarUltimo;
    private Button btnBorrarActual;
    private Button btnBorrarTodo;
    private Button btnSigno;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnSuma;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnResta;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMultiplicacion;
    private Button btn0;
    private Button btnPunto;
    private Button btnIgual;
    private Button btnDivision;
    private Button btnPi;
    private Button btnLog;
    private Button bntSqrt;
    private Button btnCuadrado;
    private Button btnSinh;
    private Button btnSin;
    private Button btnDec;
    private Button btnXy;
    private Button btnCosh;
    private Button btnCos;
    private Button btnBin;
    private Button btn1X;
    private Button btnTanh;
    private Button btnTan;
    private Button btnHex;
    private Button btnLnx;
    private Button btnExp;
    private Button btnMod;
    private Button btnOct;
    private MenuStrip menu;
    private ToolStripMenuItem catTipo;
    private ToolStripMenuItem miEstandar;
    private ToolStripMenuItem miCientifica;

    private TextBox txtDisplay;
    private Label lblOperacion;
    private String operacion;
    private Double resultado;
    public Form1()
    {
        operacion = "";
        resultado = 0;
        txtDisplay = new TextBox();
        lblOperacion = new Label();
        btnBorrarUltimo = new Button();
        btnBorrarActual = new Button();
        btnBorrarTodo = new Button();
        btnSigno = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnSuma = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnResta = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnMultiplicacion = new Button();
        btn0 = new Button();
        btnPunto = new Button();
        btnIgual = new Button();
        btnDivision = new Button();
        btnPi = new Button();
        btnLog = new Button();
        bntSqrt = new Button();
        btnCuadrado = new Button();
        btnSinh = new Button();
        btnSin = new Button();
        btnDec = new Button();
        btnXy = new Button();
        btnCosh = new Button();
        btnCos = new Button();
        btnBin = new Button();
        btn1X = new Button();
        btnTanh = new Button();
        btnTan = new Button();
        btnHex = new Button();
        btnLnx = new Button();
        btnExp = new Button();
        btnMod = new Button();
        btnOct = new Button();
        menu = new MenuStrip();
        catTipo = new ToolStripMenuItem();
        miEstandar = new ToolStripMenuItem();
        miCientifica = new ToolStripMenuItem();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(600, 500);
        this.Text = "Calculadora";
        //Tamaño de botones
        btnBorrarUltimo.Size = new Size(60, 60);
        btnBorrarActual.Size = new Size(60, 60);
        btnBorrarTodo.Size = new Size(60, 60);
        btnSigno.Size = new Size(60, 60);
        btn7.Size = new Size(60, 60);
        btn8.Size = new Size(60, 60);
        btn9.Size = new Size(60, 60);
        btnSuma.Size = new Size(60, 60);
        btn4.Size = new Size(60, 60);
        btn5.Size = new Size(60, 60);
        btn6.Size = new Size(60, 60);
        btnResta.Size = new Size(60, 60);
        btn1.Size = new Size(60, 60);
        btn2.Size = new Size(60, 60);
        btn3.Size = new Size(60, 60);
        btnMultiplicacion.Size = new Size(60, 60);
        btn0.Size = new Size(60, 60);
        btnPunto.Size = new Size(60, 60);
        btnIgual.Size = new Size(60, 60);
        btnDivision.Size = new Size(60, 60);
        btnPi.Size = new Size(60, 60);
        btnLog.Size = new Size(60, 60);
        bntSqrt.Size = new Size(60, 60);
        btnCuadrado.Size = new Size(60, 60);
        btnSinh.Size = new Size(60, 60);
        btnSin.Size = new Size(60, 60);
        btnDec.Size = new Size(60, 60);
        btnXy.Size = new Size(60, 60);
        btnCosh.Size = new Size(60, 60);
        btnCos.Size = new Size(60, 60);
        btnBin.Size = new Size(60, 60);
        btn1X.Size = new Size(60, 60);
        btnTanh.Size = new Size(60, 60);
        btnTan.Size = new Size(60, 60);
        btnHex.Size = new Size(60, 60);
        btnLnx.Size = new Size(60, 60);
        btnExp.Size = new Size(60, 60);
        btnMod.Size = new Size(60, 60);
        btnOct.Size = new Size(60, 60);

        txtDisplay.Size = new Size(558, 50);
        txtDisplay.Multiline = true;
        lblOperacion.AutoSize = true;
        txtDisplay.TextAlign = HorizontalAlignment.Right;

        //Texto
        btnBorrarUltimo.Text = "⌫";
        btnBorrarActual.Text = "CE";
        btnBorrarTodo.Text = "C";
        btnSigno.Text = "±";
        btn7.Text = "7";
        btn8.Text = "8";
        btn9.Text = "9";
        btnSuma.Text = "+";
        btn4.Text = "4";
        btn5.Text = "5";
        btn6.Text = "6";
        btnResta.Text = "-";
        btn1.Text = "1";
        btn2.Text = "2";
        btn3.Text = "3";
        btnMultiplicacion.Text = "*";
        btn0.Text = "0";
        btnPunto.Text = ".";
        btnIgual.Text = "=";
        btnDivision.Text = "/";
        btnPi.Text = "π";
        btnLog.Text = "Log";
        bntSqrt.Text = "Sqrt";
        btnCuadrado.Text = "x^2";
        btnSinh.Text = "Sinh";
        btnSin.Text = "Sin";
        btnDec.Text = "Dec";
        btnXy.Text = "x^y";
        btnCosh.Text = "Cosh";
        btnCos.Text = "cos";
        btnBin.Text = "Bin";
        btn1X.Text = "1/x";
        btnTanh.Text = "Tanh";
        btnTan.Text = "Tan";
        btnHex.Text = "Hex";
        btnLnx.Text = "Ln x";
        btnExp.Text = "Exp";
        btnMod.Text = "Mod";
        btnOct.Text = "Octal";
        catTipo.Text = "Tipo";
        miEstandar.Text = "Estandar";
        miCientifica.Text = "Científica";


        //Posicion
        txtDisplay.Location = new Point(10, 50);
        lblOperacion.Location = new Point(10, 30);

        List<Button> lista = new List<Button>();
        lista.Add(btnBorrarUltimo);
        lista.Add(btnBorrarActual);
        lista.Add(btnBorrarTodo);
        lista.Add(btnSigno);
        lista.Add(btn7);
        lista.Add(btn8);
        lista.Add(btn9);
        lista.Add(btnSuma);
        lista.Add(btn4);
        lista.Add(btn5);
        lista.Add(btn6);
        lista.Add(btnResta);
        lista.Add(btn1);
        lista.Add(btn2);
        lista.Add(btn3);
        lista.Add(btnMultiplicacion);
        lista.Add(btn0);
        lista.Add(btnPunto);
        lista.Add(btnIgual);
        lista.Add(btnDivision);
        int x = 10;
        int y = 105;
        int count = 0;
        foreach (Button btn in lista)
        {
            if (count == 4)
            {
                x = 10;
                y += 67;
                count = 0;
            }
            btn.Location = new Point(x, y);
            btn.Click += new EventHandler(btn_click);
            this.Controls.Add(btn);
            x += 67;
            count++;
        }

        List<Button> cientifica = new List<Button>();
        cientifica.Add(btnPi);
        cientifica.Add(btnLog);
        cientifica.Add(bntSqrt);
        cientifica.Add(btnCuadrado);
        cientifica.Add(btnSinh);
        cientifica.Add(btnSin);
        cientifica.Add(btnDec);
        cientifica.Add(btnXy);
        cientifica.Add(btnCosh);
        cientifica.Add(btnCos);
        cientifica.Add(btnBin);
        cientifica.Add(btn1X);
        cientifica.Add(btnTanh);
        cientifica.Add(btnTan);
        cientifica.Add(btnHex);
        cientifica.Add(btnLnx);
        cientifica.Add(btnExp);
        cientifica.Add(btnMod);
        cientifica.Add(btnOct);
        x = 307;
        y = 105;
        count = 0;
        foreach (Button btn in cientifica)
        {
            if (count == 4)
            {
                x = 307;
                y += 67;
                count = 0;
            }
            btn.Location = new Point(x, y);
            this.Controls.Add(btn);
            x += 67;
            count++;
        }
        //Eventos
        miEstandar.Click+= new EventHandler(menuEstandar_Click);
        miCientifica.Click+= new EventHandler(menuCientifica_Click);
        btnPi.Click+= new EventHandler(btnPi_Click);
        btnLog.Click+= new EventHandler(btnLog_Click);
        btnSin.Click+= new EventHandler(btnSin_Click);
        btnBin.Click+= new EventHandler(btnBin_Click);
        btnCos.Click+= new EventHandler(btnCos_Click);
        btnTan.Click+= new EventHandler(btnTan_Click);
        btnSinh.Click+= new EventHandler(btnSinh_Click);
        btnCosh.Click+= new EventHandler(btnCosh_Click);
        btnTanh.Click+= new EventHandler(btnTanh_Click);
        btnOct.Click+= new EventHandler(btnOct_Click);
        btnHex.Click+= new EventHandler(btnHex_Click);
        btnCuadrado.Click+= new EventHandler(btnCuadrado_Click);
        btnMod.Click+= new EventHandler(btnMod_Click);
        btnXy.Click+= new EventHandler(btnXy_Click);
        btnExp.Click+= new EventHandler(btnExp_Click);
        btn1X.Click+= new EventHandler(btn1X_Click);
        btnLnx.Click+= new EventHandler(btnLnX_Click);
    
        //Agregar controles al formulario
        this.Controls.Add(txtDisplay);
        this.Controls.Add(lblOperacion);
        catTipo.DropDownItems.Add(miEstandar);
        catTipo.DropDownItems.Add(miCientifica);
        menu.Items.Add(catTipo);
        this.Controls.Add(menu);
        lblOperacion.BringToFront();
    }
    private void btnExp_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Exp({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Exp(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btn1X_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"1/({txtDisplay.Text}) =";
        txtDisplay.Text = (1 / Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnMod_Click(object? sender, EventArgs e)
    {
        operacion = "%";
        resultado = Double.Parse(txtDisplay.Text);
        lblOperacion.Text = txtDisplay.Text + " " + operacion;
        txtDisplay.Text = "0";
    }
    private void btnXy_Click(object? sender, EventArgs e)
    {
        operacion = "^";
        resultado = Double.Parse(txtDisplay.Text);
        lblOperacion.Text = txtDisplay.Text + " " + operacion;
        txtDisplay.Text = "0";
    }
    private void btnCuadrado_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"({txtDisplay.Text})^2 =";
        txtDisplay.Text = Math.Pow(Double.Parse(txtDisplay.Text),2).ToString();
    }
    private void btnHex_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Hexadecimal({txtDisplay.Text}) =";
        txtDisplay.Text = Convert.ToString(Int32.Parse(txtDisplay.Text),16);
    }
    private void btnOct_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Octal({txtDisplay.Text}) =";
        txtDisplay.Text = Convert.ToString(Int32.Parse(txtDisplay.Text),8);
    }
    private void btnBin_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Binario({txtDisplay.Text}) =";
        txtDisplay.Text = Convert.ToString(Int32.Parse(txtDisplay.Text),2);
    }
    private void btnCosh_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Cosh({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Cosh(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnTanh_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Tanh({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Tanh(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnSinh_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Sinh({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Sinh(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnCos_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Cos({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Cos(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnTan_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Tan({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Tan(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnSin_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Sin({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Sin(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnLnX_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Lnx({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Log2(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnLog_Click(object? sender, EventArgs e)
    {
        lblOperacion.Text=$"Log({txtDisplay.Text}) =";
        txtDisplay.Text = Math.Log(Double.Parse(txtDisplay.Text)).ToString();
    }
    private void btnPi_Click(object? sender, EventArgs e)
    {
        txtDisplay.Text="3.141592";
    }
    private void menuEstandar_Click(object? sender, EventArgs e)
    {
        this.Size = new Size(300,500);
        txtDisplay.Size = new Size(260,50);
    }
    private void menuCientifica_Click(object? sender, EventArgs e)
    {
        this.Size = new Size(600,500);
        txtDisplay.Size = new Size(558,50);
    }
    private void btn_click(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "⌫":
                    if (txtDisplay.Text.Length > 0)
                        txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                    if (txtDisplay.Text == "")
                        txtDisplay.Text = "0";
                    break;
                case "CE":
                    txtDisplay.Text = "0";
                    break;
                case "C":
                    txtDisplay.Text = "0";
                    lblOperacion.Text = "";
                    break;
                case "=":
                    boton_igual();
                    break;
                case "±":
                    txtDisplay.Text = (Double.Parse(txtDisplay.Text) * -1).ToString();
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                    boton_numero(btn.Text);
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                    boton_operador(btn.Text);
                    break;
            }
        }

    }

    private void boton_igual()
    {
        lblOperacion.Text += " " + txtDisplay.Text + " =";
        switch (operacion)
        {
            case "+":
                txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "-":
                txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "*":
                txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "/":
                txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "%":
                txtDisplay.Text = (resultado % Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "^":
                txtDisplay.Text = Math.Pow(resultado,Double.Parse(txtDisplay.Text)).ToString();
                break;
        }
    }

    private void boton_operador(string operador)
    {
        operacion = operador;
        resultado = Double.Parse(txtDisplay.Text);
        lblOperacion.Text = txtDisplay.Text + " " + operacion;
        txtDisplay.Text = "0";
    }

    private void boton_numero(string valor)
    {
        if (txtDisplay.Text == "0")
        {
            txtDisplay.Text = "";
        }
        if (valor == ".")
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += valor;
            }
        }
        else
        {
            txtDisplay.Text += valor;
        }
    }
}
