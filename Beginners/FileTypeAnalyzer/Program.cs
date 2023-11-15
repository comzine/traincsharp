string input;
System.Console.Write("Enter a filetype extension or x for close: ");
input = System.Console.ReadLine();
while (input != "x")
{
    switch (input)
    {
        case "jpg":
        case "gif":
        case "png":
            System.Console.WriteLine("Image");
            break;
        case "doc":
        case "txt":
        case "rtf":
            System.Console.WriteLine("Text");
            break;
        case "xls":
        case "csv":
            System.Console.WriteLine("Spreadsheet");
            break;
        case "x":
            System.Console.WriteLine("Close");
            break;
        default:
            System.Console.WriteLine("Unknown");
            break;
    }
    if (input != "x")
    {
        System.Console.ReadKey();
    }
}