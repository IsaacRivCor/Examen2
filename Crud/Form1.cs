namespace Crud;

public partial class Form1 : Form
{
    private CervezaContext bd;
    private DataGridView gdCervezas;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;
    public Form1()
    {
        bd = new CervezaContext();
        gdCervezas = new DataGridView();
        btnAgregar = new Button();
        btnEditar = new Button();
        btnEliminar = new Button();
        InitializeComponent();
        InicializarComponentes();
    }
    private void InicializarComponentes()
    {
        gdCervezas.DataSource = bd.Cervezas.ToList();
        this.Size = new Size(650, 350);
        gdCervezas.Size = new Size(500, 280);
        gdCervezas.Location = new Point(15, 15);
        btnAgregar.AutoSize = true;
        btnEditar.AutoSize = true;
        btnEliminar.AutoSize = true;
        btnAgregar.Text = "Agregar";
        btnEditar.Text = "Editar";
        btnEliminar.Text = "Eliminar";
        btnAgregar.Location = new Point(530,15);
        btnEditar.Location = new Point(530,150);
        btnEliminar.Location = new Point(530,270);
        btnAgregar.Click += new EventHandler(btnAgregar_Click);
        btnEditar.Click += new EventHandler(btnEditar_Click);
        btnEliminar.Click += new EventHandler(btnEliminar_Click);
        this.Controls.Add(gdCervezas);
        this.Controls.Add(btnAgregar);
        this.Controls.Add(btnEditar);
        this.Controls.Add(btnEliminar);
    }
    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        Form2 nuevoFormulario = new Form2();
        if(nuevoFormulario.ShowDialog()==DialogResult.OK)
        {
            bd.Add(nuevoFormulario.cerveza);
            bd.SaveChanges();
            gdCervezas.DataSource = bd.Cervezas.ToList();
        }
    }
    private void btnEditar_Click(object? sender, EventArgs e)
    {
        Cerveza seleccionada = (Cerveza)gdCervezas.CurrentRow.DataBoundItem;
        Form2 editarFormulario = new Form2(seleccionada);
        if(editarFormulario.ShowDialog()==DialogResult.OK)
        {
            bd.Update(editarFormulario.cerveza);
            bd.SaveChanges();
            gdCervezas.DataSource = bd.Cervezas.ToList();
        }
    }
    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        Cerveza seleccionada = (Cerveza)gdCervezas.CurrentRow.DataBoundItem;
        bd.Remove(seleccionada);
        bd.SaveChanges();
        gdCervezas.DataSource = bd.Cervezas.ToList();
        
    }
}
