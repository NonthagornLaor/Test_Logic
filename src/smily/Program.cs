// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using smily.functions;

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
        textvalue = textvalue.Replace("'",string.Empty);
        textvalue = textvalue.Replace(" ", "");
        List<string> textvalueList = textvalue.Split(',').ToList();
        var count = _extensions.count_smily(textvalueList);
        Console.WriteLine("output :" + count.ToString());
    }
    
}
catch (Exception ex)
{
    Console.WriteLine("error program :" + ex.Message);
}