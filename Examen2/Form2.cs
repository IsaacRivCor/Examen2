namespace Examen2;

public partial class Form2 : Form
{
    public CheckBox chbMXM;
    public CheckBox chbUSD;
    public CheckBox chbCAD;
    public CheckBox chbEUR;
    public CheckBox chbJPY;
    private Button btnAceptar;
    private Button btnCancelar;
    
    private int opcion;
    public Form2(int _opcion)
    {
        opcion = _opcion;
        chbMXM = new CheckBox();
        chbUSD = new CheckBox();
        chbCAD = new CheckBox();
        chbEUR = new CheckBox();
        chbJPY = new CheckBox();
        btnAceptar = new Button();
        btnCancelar = new Button();
        InitializeComponent();
        InicializarComponentes();
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300,300);

        chbMXM.Text = "MXN - Peso mexicano";  
        chbUSD.Text = "USD- Dólar estadounidense";  
        chbCAD.Text = "CAD - Dólar canadiense";  
        chbEUR.Text = "EUR - Euro";  
        chbJPY.Text = "JPY - Yen japonés";
        btnCancelar.Text = "Cancelar";
        btnAceptar.Text = "Aceptar"; 
        
        List<CheckBox> opciones = new List<CheckBox>();
        if (opcion!=1)
        {
            opciones.Add(chbUSD);
        }
        if (opcion!=2)
        {
            opciones.Add(chbMXM);
        }
        if (opcion!=3)
        {
            opciones.Add(chbCAD);
        }
        if (opcion!=4)
        {
            opciones.Add(chbEUR);
        }
        if (opcion!=5)
        {
            opciones.Add(chbJPY);
        }
        int x = 10;
        int y = 10;
        foreach (CheckBox chb in opciones)
        {
            chb.Location = new Point(x, y);
            //chb.Size = new Size(10,100);
            this.Controls.Add(chb);
            y += 20;
        }

        btnAceptar.AutoSize = true;
        btnCancelar.AutoSize = true;
        btnCancelar.Location = new Point(15,200);
        btnAceptar.Location = new Point(200,200);
        btnCancelar.Click += new EventHandler(btnCancelar_Click);
        btnAceptar.Click += new EventHandler(btnGuardar_Click);
        
        this.Controls.Add(btnAceptar);
        this.Controls.Add(btnCancelar);
    
    }

    private void btnGuardar_Click(Object? sender, EventArgs e)
    {
        this.DialogResult=DialogResult.OK;
        this.Close();
    }
    private void btnCancelar_Click(Object? sender, EventArgs e)
    {
        this.DialogResult=DialogResult.Cancel;
        this.Close();
    }
}
