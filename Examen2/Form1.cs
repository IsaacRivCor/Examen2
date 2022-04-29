namespace Examen2;

public partial class Form1 : Form
{
    public ComboBox? cmbMonedas;
    private Label? lblMonedas;
    private Label? lblMonto;
    private Label? lblConversiones;
    private TextBox? txtMonto;
    private Button? btnCalcular;
    private Button? btnLimpiar;
    private TextBox? txtMXM;
    private TextBox? txtUSD;
    private TextBox? txtCAD;
    private TextBox? txtEUR;
    private TextBox? txtJPY;
    private Label? lblMXM;
    private Label? lblUSD;
    private Label? lblCAD;
    private Label? lblEUR;
    private Label? lblJPY;
    private int opcion = 0;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(450, 550);

        lblMonedas = new Label();
        lblMonedas.Text = "Monedas";
        lblMonedas.AutoSize = true;
        lblMonedas.Location = new Point(10, 10);

        cmbMonedas = new ComboBox();
        cmbMonedas.Size = new Size(250, 30);
        cmbMonedas.Items.Add("Selecciona la Moneda");
        cmbMonedas.Items.Add("USD- Dólar estadounidense");
        cmbMonedas.Items.Add("MXN - Peso mexicano");
        cmbMonedas.Items.Add("CAD - Dólar canadiense");
        cmbMonedas.Items.Add("EUR - Euro");
        cmbMonedas.Items.Add("JPY - Yen japonés");
        cmbMonedas.SelectedIndex = 0;
        cmbMonedas.Location = new Point(10, 40);
        cmbMonedas.SelectedValueChanged += new EventHandler(cmb_ValueChanged);

        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(265, 10);

        txtMonto = new TextBox();
        txtMonto.Size = new Size(150, 50);
        txtMonto.KeyPress += new KeyPressEventHandler(tbMonto_KeyPress);
        txtMonto.Location = new Point(265, 40);

        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(265, 70);
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

        btnLimpiar = new Button();
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.AutoSize = true;
        btnLimpiar.Location = new Point(10, 70);
        btnLimpiar.Click += new EventHandler(btnLimpiar_Click);

        lblConversiones = new Label();
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(10, 100);

                this.Controls.Add(lblMonedas);
        this.Controls.Add(cmbMonedas);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(btnLimpiar);
        this.Controls.Add(lblConversiones);
    }
    private void cmb_ValueChanged(object sender, EventArgs e)
    {
        if (cmbMonedas.SelectedIndex == 1)
        {
            opcion = 1;
        }
        else if (cmbMonedas.SelectedIndex == 2)
        {
            opcion = 2;
        }
        else if (cmbMonedas.SelectedIndex == 3)
        {
            opcion = 3;
        }
        else if (cmbMonedas.SelectedIndex == 4)
        {
            opcion = 4;
        }
        else if (cmbMonedas.SelectedIndex == 5)
        {
            opcion = 5;
        }
    }
    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        if (opcion != 0 && txtMonto.Text.Length != 0)
        {
            Form2 nuevoFormulario = new Form2(opcion);
            
            if (nuevoFormulario.ShowDialog() == DialogResult.OK)
            {
                switch (opcion)
                {
                    case 1:
                        lblMXM = new Label();
                        lblMXM.Text = "MXM - peso";
                        txtMXM = new TextBox();
                        lblCAD = new Label();
                        lblCAD.Text = "CAD - Dólar";
                        txtCAD = new TextBox();
                        lblEUR = new Label();
                        lblEUR.Text = "EUR - Euro";
                        txtEUR = new TextBox();
                        lblJPY = new Label();
                        lblJPY.Text = "Yen japones";
                        txtJPY = new TextBox();
                        List<Label> labels = new List<Label>();
                        List<TextBox> textBoxes = new List<TextBox>();
                        if (nuevoFormulario.chbMXM.Checked == true)
                        {
                            txtMXM.Text="$ "+(double.Parse(txtMonto.Text)*21.23).ToString();
                            labels.Add(lblMXM);
                            textBoxes.Add(txtMXM);
                        }
                        if (nuevoFormulario.chbCAD.Checked == true)
                        {
                            txtCAD.Text="$ "+(double.Parse(txtMonto.Text)*1.28).ToString();
                            labels.Add(lblCAD);
                            textBoxes.Add(txtCAD);
                        }
                        if (nuevoFormulario.chbEUR.Checked == true)
                        {
                            txtEUR.Text="€ "+(double.Parse(txtMonto.Text)*.89).ToString();
                            labels.Add(lblEUR);
                            textBoxes.Add(txtEUR);
                        }
                        if (nuevoFormulario.chbJPY.Checked == true)
                        {
                            txtJPY.Text="¥ "+(double.Parse(txtMonto.Text)*113.05).ToString();
                            labels.Add(lblJPY);
                            textBoxes.Add(txtJPY);
                        }
                        int xlbl = 10;
                        int ylbl = 120;
                        foreach (Label lbl in labels)
                        {
                            lbl.Location = new Point(xlbl, ylbl);
                            this.Controls.Add(lbl);
                            ylbl += 25;
                        }
                        int xtbx = 120;
                        int ytbx = 120;
                        foreach (TextBox tbx in textBoxes)
                        {
                            tbx.Size = new Size(150, 50);
                            tbx.Location = new Point(xtbx, ytbx);
                            this.Controls.Add(tbx);
                            ytbx += 25;
                        }
                        break;
                    case 2:
                        lblUSD = new Label();
                        lblUSD.Text = "USD - Dólar";
                        txtUSD = new TextBox();
                        lblCAD = new Label();
                        lblCAD.Text = "CAD - Dólar";
                        txtCAD = new TextBox();
                        lblEUR = new Label();
                        lblEUR.Text = "EUR - Euro";
                        txtEUR = new TextBox();
                        lblJPY = new Label();
                        lblJPY.Text = "Yen japones";
                        txtJPY = new TextBox();
                        labels = new List<Label>();
                        textBoxes = new List<TextBox>();
                        if (nuevoFormulario.chbUSD.Checked == true)
                        {
                            txtUSD.Text="$ "+(double.Parse(txtMonto.Text)*0.5).ToString();
                            labels.Add(lblUSD);
                            textBoxes.Add(txtUSD);
                        }
                        if (nuevoFormulario.chbCAD.Checked == true)
                        {
                            txtCAD.Text="$ "+(double.Parse(txtMonto.Text)*0.6).ToString();
                            labels.Add(lblCAD);
                            textBoxes.Add(txtCAD);
                        }
                        if (nuevoFormulario.chbEUR.Checked == true)
                        {
                            txtEUR.Text="€ "+(double.Parse(txtMonto.Text)*0.4).ToString();
                            labels.Add(lblEUR);
                            textBoxes.Add(txtEUR);
                        }
                        if (nuevoFormulario.chbJPY.Checked == true)
                        {
                            txtJPY.Text="¥ "+(double.Parse(txtMonto.Text)*5.32).ToString();
                            labels.Add(lblJPY);
                            textBoxes.Add(txtJPY);
                        }
                        xlbl = 10;
                        ylbl = 120;
                        foreach (Label lbl in labels)
                        {
                            lbl.Location = new Point(xlbl, ylbl);
                            this.Controls.Add(lbl);
                            ylbl += 25;
                        }
                        xtbx = 120;
                        ytbx = 120;
                        foreach (TextBox tbx in textBoxes)
                        {
                            tbx.Size = new Size(150, 50);
                            tbx.Location = new Point(xtbx, ytbx);
                            this.Controls.Add(tbx);
                            ytbx += 25;
                        }
                        break;
                    case 3:
                        lblUSD = new Label();
                        lblUSD.Text = "USD - Dólar";
                        txtUSD = new TextBox();
                        lblMXM = new Label();
                        lblMXM.Text = "MXM - Peso";
                        txtMXM = new TextBox();
                        lblEUR = new Label();
                        lblEUR.Text = "EUR - Euro";
                        txtEUR = new TextBox();
                        lblJPY = new Label();
                        lblJPY.Text = "Yen japones";
                        txtJPY = new TextBox();
                        labels = new List<Label>();
                        textBoxes = new List<TextBox>();
                        if (nuevoFormulario.chbUSD.Checked == true)
                        {
                            txtUSD.Text="$ "+(double.Parse(txtMonto.Text)*0.78).ToString();
                            labels.Add(lblUSD);
                            textBoxes.Add(txtUSD);
                        }
                        if (nuevoFormulario.chbMXM.Checked == true)
                        {
                            txtMXM.Text="$ "+(double.Parse(txtMonto.Text)*16.55).ToString();
                            labels.Add(lblMXM);
                            textBoxes.Add(txtMXM);
                        }
                        if (nuevoFormulario.chbEUR.Checked == true)
                        {
                            txtEUR.Text="€ "+(double.Parse(txtMonto.Text)*0.69).ToString();
                            labels.Add(lblEUR);
                            textBoxes.Add(txtEUR);
                        }
                        if (nuevoFormulario.chbJPY.Checked == true)
                        {
                            txtJPY.Text="¥ "+(double.Parse(txtMonto.Text)*88.12).ToString();
                            labels.Add(lblJPY);
                            textBoxes.Add(txtJPY);
                        }
                        xlbl = 10;
                        ylbl = 120;
                        foreach (Label lbl in labels)
                        {
                            lbl.Location = new Point(xlbl, ylbl);
                            this.Controls.Add(lbl);
                            ylbl += 25;
                        }
                        xtbx = 120;
                        ytbx = 120;
                        foreach (TextBox tbx in textBoxes)
                        {
                            tbx.Size = new Size(150, 50);
                            tbx.Location = new Point(xtbx, ytbx);
                            this.Controls.Add(tbx);
                            ytbx += 25;
                        }
                        break;
                    case 4:
                        lblUSD = new Label();
                        lblUSD.Text = "USD - Dólar";
                        txtUSD = new TextBox();
                        lblMXM = new Label();
                        lblMXM.Text = "MXM- peso";
                        txtMXM = new TextBox();
                        lblCAD = new Label();
                        lblCAD.Text = "CAD - Dólar";
                        txtCAD = new TextBox();
                        lblJPY = new Label();
                        lblJPY.Text = "Yen japones";
                        txtJPY = new TextBox();
                        labels = new List<Label>();
                        textBoxes = new List<TextBox>();
                        if (nuevoFormulario.chbUSD.Checked == true)
                        {
                            txtUSD.Text="$ "+(double.Parse(txtMonto.Text)*1.13).ToString();
                            labels.Add(lblUSD);
                            textBoxes.Add(txtUSD);
                        }
                        if (nuevoFormulario.chbMXM.Checked == true)
                        {
                            txtMXM.Text="$ "+(double.Parse(txtMonto.Text)*23.96).ToString();
                            labels.Add(lblMXM);
                            textBoxes.Add(txtMXM);
                        }
                        if (nuevoFormulario.chbCAD.Checked == true)
                        {
                            txtCAD.Text="$ "+(double.Parse(txtMonto.Text)*1.45).ToString();
                            labels.Add(lblCAD);
                            textBoxes.Add(txtCAD);
                        }
                        if (nuevoFormulario.chbJPY.Checked == true)
                        {
                            txtJPY.Text="¥ "+(double.Parse(txtMonto.Text)*127.56).ToString();
                            labels.Add(lblJPY);
                            textBoxes.Add(txtJPY);
                        }
                        xlbl = 10;
                        ylbl = 120;
                        foreach (Label lbl in labels)
                        {
                            lbl.Location = new Point(xlbl, ylbl);
                            this.Controls.Add(lbl);
                            ylbl += 25;
                        }
                        xtbx = 120;
                        ytbx = 120;
                        foreach (TextBox tbx in textBoxes)
                        {
                            tbx.Size = new Size(150, 50);
                            tbx.Location = new Point(xtbx, ytbx);
                            this.Controls.Add(tbx);
                            ytbx += 25;
                        }
                        break;
                    case 5:
                        lblUSD = new Label();
                        lblUSD.Text = "USD - Dólar";
                        txtUSD = new TextBox();
                        lblMXM = new Label();
                        lblMXM.Text = "MXM- peso";
                        txtMXM = new TextBox();
                        lblCAD = new Label();
                        lblCAD.Text = "CAD - Dólar";
                        txtCAD = new TextBox();
                        lblEUR = new Label();
                        lblEUR.Text = "Yen japones";
                        txtEUR = new TextBox();
                        labels = new List<Label>();
                        textBoxes = new List<TextBox>();
                        if (nuevoFormulario.chbUSD.Checked == true)
                        {
                            txtUSD.Text="$ "+(double.Parse(txtMonto.Text)*0.0088).ToString();
                            labels.Add(lblUSD);
                            textBoxes.Add(txtUSD);
                        }
                        if (nuevoFormulario.chbMXM.Checked == true)
                        {
                            txtMXM.Text="$ "+(double.Parse(txtMonto.Text)*0.1878).ToString();
                            labels.Add(lblMXM);
                            textBoxes.Add(txtMXM);
                        }
                        if (nuevoFormulario.chbCAD.Checked == true)
                        {
                            txtCAD.Text="$ "+(double.Parse(txtMonto.Text)*0.0113).ToString();
                            labels.Add(lblCAD);
                            textBoxes.Add(txtCAD);
                        }
                        if (nuevoFormulario.chbEUR.Checked == true)
                        {
                            txtEUR.Text="¥ "+(double.Parse(txtMonto.Text)*0.0078).ToString();
                            labels.Add(lblEUR);
                            textBoxes.Add(txtEUR);
                        }
                        xlbl = 10;
                        ylbl = 120;
                        foreach (Label lbl in labels)
                        {
                            lbl.Location = new Point(xlbl, ylbl);
                            this.Controls.Add(lbl);
                            ylbl += 25;
                        }
                        xtbx = 120;
                        ytbx = 120;
                        foreach (TextBox tbx in textBoxes)
                        {
                            tbx.Size = new Size(150, 50);
                            tbx.Location = new Point(xtbx, ytbx);
                            this.Controls.Add(tbx);
                            ytbx += 25;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
    private void tbMonto_KeyPress(Object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
        {
            e.Handled = true;
            return;
        }
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        cmbMonedas.SelectedIndex = 0;
        txtMonto.Text="";
    }
}
