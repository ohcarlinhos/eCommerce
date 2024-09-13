
using eCommerce.Console.Tracking;

var db = new eCommerceContext();

var usuario01 = db.Usuarios.Find(1); // EF está acompanhando.
usuario01!.Nome = "José";

db.SaveChanges();