using System.Reflection;

string      nomeMarca = "";
// nomes de marca:  Adidas, Nike, New Balance, Olympicus, PUMA, Mizuno, Under Armour, Fila, Vans, Oakley


string      nomeModelo = "";
//string      nomeLinha;
//int         numeroTamanho;
int         indexModelos;
int         indexMarca;


string[]    marca =                     {"Adidas", "Nike", "New Balance"};
string[]    modelosNike =               {"AIR", "PEGASUS", "ZOOM", "Invincible"};
string[]    modelosAdidas =             {"FORUM", "SAMBA", "SLIP-ON", "COURT", "RIVALRY"};
string[]    modelosNewBalance =         {"FRESH FOAM", "FUELCELL", "550", "2002"};

string[]    linhasNikeAir =             {"Jordan", "Force", "Max", "More"};


//placeholders só pra testar
string[]    linhasAdidasForum =         {"Hal", "Huey", "Emma", "Strangelove", "Sunny"};
string[]    linhasNewBalanceFreshFoam = {"Liquid", "Solid", "Naked", "Solidus", "Venom", "Big Boss"};

//sorteiozinho

Random      random1 = new Random();

            indexMarca = random1.Next(0, (marca.Length));

            nomeMarca = marca[indexMarca];

switch (nomeMarca)
{
    case "Nike":
        indexModelos = random1.Next(0, modelosNike.Length);
        nomeModelo = modelosNike[indexModelos];
    break;

    case "Adidas":
        indexModelos = random1.Next(0, modelosAdidas.Length);
        nomeModelo = modelosAdidas[indexModelos];
    break;

    case "New Balance":
        indexModelos = random1.Next(0, modelosNewBalance.Length);
        nomeModelo = modelosNewBalance[indexModelos];
    break;
}
//TODO: Adicionar todas as marcas e modelos
//TODO: Descobrir como filtrar as linhas dos modelos de tenis


Console.WriteLine($"values(\"{nomeMarca}\", \"{nomeModelo}\")");