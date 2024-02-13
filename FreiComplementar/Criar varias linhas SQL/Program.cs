using System.Reflection;

string nm_marca = "";
// nomes de marca:  Adidas, Nike, New Balance, Olympicus, PUMA, Mizuno, Under Armour, Fila, Vans, Oakley
string[] marca = {"Adidas", "Nike", "New Balance"};

string nm_modelo;
string nm_linha;
int nr_tamanho;

string[] modelosNike = {"AIR", "PEGASUS", "ZOOM", "Invincible"};
string[] modelosAdidas = {"FORUM", "SAMBA", "SLIP-ON", "COURT", "RIVALRY"};
string[] modelosNewBalance = {"FRESH FOAM", "FUELCELL", "550", "2002"};

string[] linhasNikeAir = {"Jordan", "Force", "Max", "More"};

//placeholders só pra testar
string [] linhasAdidasForum = {"Hal", "Huey", "Emma", "Strangelove", "Sunny"};
string[] linhasNewBalanceFreshFoam = {"Liquid", "Solid", "Naked", "Solidus", "Venom", "Big Boss"};

//sorteiozinho

Random indexAleatorio = new Random();
int IndexMarca = indexAleatorio.Next(0, (marca.Length));

nm_marca = "Nike";//marca[IndexMarca];


int indexModelosNike = indexAleatorio.Next(0, modelosNike.Length);

nm_modelo = modelosNike[indexModelosNike];

Console.WriteLine($"values({nm_marca}, {nm_modelo})");
