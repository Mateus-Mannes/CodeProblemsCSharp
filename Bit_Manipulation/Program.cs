// See https://aka.ms/new-console-template for more information
using Bit_Manipulation;

var binaryString = Binary_To_String.PrintBinary2(0.1);
Console.WriteLine(binaryString);

for (var i = 0; i < 1000; i++)
{
    var num = i / 1000.0;
    var binary = Binary_To_String.PrintBinary(num);
    var binary2 = Binary_To_String.PrintBinary2(num);

    if (!binary.Equals("ERROR") || !binary2.Equals("ERROR"))
    {
        Console.WriteLine(num + " : " + binary + " " + binary2);
    }
}
