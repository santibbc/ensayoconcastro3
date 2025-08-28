// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("modificacion en main");


Console.WriteLine("modificacion en rama 10:59 pm");

var producto = new Producto();
Producto producto1 = new Producto();
Producto producto2 = new Producto();

producto.Id = 1;
producto.Nombre = "arroz roa";
producto.Precio = 4500m;
producto.Categoria = new Categoria() { Id = 1, Nombre = "tipo: arroz" };
producto.Proveedores = new List<Proveedor>();
producto.Proveedores.Add(new Proveedor() { Id = 1, Nombre = "proveedor: proveedor 1" });
producto.Proveedores.Add(new Proveedor() { Id = 2, Nombre = "proveedor: proveedor 2" });

Console.WriteLine(producto.Nombre);
Console.WriteLine(producto.Categoria.Nombre);

foreach (var elemento in producto.Proveedores)
{
    Console.WriteLine(elemento.Nombre);
}

public class Categoria
{
    public int Id = 0;
    public string? Nombre = "";

    public List<Producto> Productos = new List<Producto>();
}

public class Proveedor
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Producto
{
    public int Id = 0;
    public string? Nombre = "";
    public decimal Precio = 0.0m;
    public Categoria Categoria = new Categoria();
    public List<Proveedor> Proveedores = new List<Proveedor>();
}
