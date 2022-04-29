namespace Crud;

public partial class Form2 : Form
{
    private TableLayoutPanel tlCampos;
    private Label lblNombre;
    private Label lblEstilo;
    private Label lblbAlcohol;
    private TextBox txtNombre;
    private TextBox txtEstilo;
    private TextBox txtAlcohol;
    private Button btnGuardar;
    private Button btnCancelar;
    public Cerveza cerveza;
    public Form2()
    {
        tlCampos = new TableLayoutPanel();
        lblNombre = new Label();
        lblEstilo = new Label();
        lblbAlcohol = new Label();
        txtNombre = new TextBox();
        txtEstilo = new TextBox();
        txtAlcohol = new TextBox();
        btnGuardar = new Button();
        btnCancelar = new Button();
        cerveza = new Cerveza();
        InitializeComponent();
        InicializarComponentes();
    }
    public Form2(Cerveza _cerveza):this()
    {
        this.cerveza=_cerveza;
        txtNombre.Text=cerveza.Nombre;
        txtEstilo.Text=cerveza.Estilo;
        txtAlcohol.Text=cerveza.Alcohol.ToString();
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 300);
        lblNombre.AutoSize = true;
        lblEstilo.AutoSize = true;
        lblbAlcohol.AutoSize = true;
        txtNombre.Size = new Size(150, 23);
        txtEstilo.Size = new Size(150, 23);
        txtAlcohol.Size = new Size(100, 23);
        btnGuardar.AutoSize = true;
        btnCancelar.AutoSize = true;
        tlCampos.AutoSize = true;
        lblNombre.Text = "Nombre";
        lblEstilo.Text = "Estilo";
        lblbAlcohol.Text = "Alcohol";
        btnCancelar.Text = "Cancelar";
        btnGuardar.Text = "Guardar";
        tlCampos.ColumnCount=1;
        tlCampos.RowCount=6;
        tlCampos.Controls.Add(lblNombre);
        tlCampos.Controls.Add(txtNombre);
        tlCampos.Controls.Add(lblEstilo);
        tlCampos.Controls.Add(txtEstilo);
        tlCampos.Controls.Add(lblbAlcohol);
        tlCampos.Controls.Add(txtAlcohol);
        tlCampos.Location = new Point(15,15);
        btnCancelar.Location = new Point(15,200);
        btnGuardar.Location = new Point(200,200);
        btnCancelar.Click += new EventHandler(btnCancelar_Click);
        btnGuardar.Click += new EventHandler(btnGuardar_Click);
        this.Controls.Add(tlCampos);
        this.Controls.Add(btnCancelar);
        this.Controls.Add(btnGuardar);
    }
    private void btnGuardar_Click(Object? sender, EventArgs e)
    {
        cerveza.Nombre=txtNombre.Text;
        cerveza.Estilo=txtEstilo.Text;
        cerveza.Alcohol=Double.Parse(txtAlcohol.Text);
        this.DialogResult=DialogResult.OK;
        this.Close();
    }
    private void btnCancelar_Click(Object? sender, EventArgs e)
    {
        this.DialogResult=DialogResult.Cancel;
        this.Close();
    }
}
