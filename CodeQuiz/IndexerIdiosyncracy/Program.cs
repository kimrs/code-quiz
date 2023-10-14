// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using static System.Console;

try
{
    var empty = new NameValueCollection()["green"];
    WriteLine("green!");

    var alsoEmpty = new Dictionary<string, string>()["blue"];
    WriteLine("blue!");
}
catch (Exception ex)
{
    WriteLine(ex.GetType().Name);
}
/*
    green!
    KeyNotFoundException
*/