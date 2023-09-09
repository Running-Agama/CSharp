﻿/*switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
*/


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Diagnostics;
using System.Xml;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
    type = "Sweat Shirt";
    break;

    case "02":
    type = "T Shirt";
    break;

    case "03":
    type = "Sweat Pants";
    break;

    default:
    type = "Other";
    break;
}

switch(product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;

    default:
    color = "White";
    break;
}

switch(product[2])
{
    case "S":
    size = "Small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;

    default:
    size = "One Size Fits All";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");