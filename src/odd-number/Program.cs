// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using odd_number.functions;

try
{
    string? textvalue = string.Empty;
    extensions _extensions = new extensions();


    Console.WriteLine("Type a string, and then press Enter");
    textvalue = Convert.ToString(Console.ReadLine());
    Console.WriteLine("input : " + textvalue);
    if (string.IsNullOrEmpty(textvalue))
    {
        Console.WriteLine("output : 0 ");
    }
    else
    {
        var result = _extensions.verify(textvalue);
        Console.WriteLine("output :" + result);
    }    
}
catch (Exception ex)
{
    Console.WriteLine("error program :" + ex.Message);
}
