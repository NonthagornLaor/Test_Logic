// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using manipulate.functions;
using manipulate.models;



try
{
    string? textvalue = string.Empty;
    extensions _extensions = new extensions();
    Input _input = new Input();
    string result = string.Empty;

    Console.WriteLine("Type a string, and then press Enter");
    textvalue = Convert.ToString(Console.ReadLine());
    //_input.inputValue = _extensions.verifyInput(textvalue);
    Console.WriteLine("input : " + textvalue);
    if (string.IsNullOrEmpty(textvalue))
    {
        Console.WriteLine("output : 0 ");
    }
    else
    {
        Console.Write("output : ");
        _extensions.Permutations(textvalue, "");
        Console.Write(result);
    }
}
catch (Exception ex)
{
    Console.WriteLine("error program :" + ex.Message);
}
