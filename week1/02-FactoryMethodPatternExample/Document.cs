public class WordDocument : Idocument
{
    public void Open()
    {
        Console.WriteLine("Opening word");
    }
}

public class PdfDocument : Idocument
{
    public void Open()
    {
        Console.WriteLine("Opening pdf");
    }
}

public class ExcelDocument : Idocument
{
    public void Open()
    {
        Console.WriteLine("Opening excel");
    }
}