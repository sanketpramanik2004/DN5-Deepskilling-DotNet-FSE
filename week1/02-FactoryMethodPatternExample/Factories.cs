public class WordFactory : DocumentFactory
{
    public override Idocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfFactory : DocumentFactory
{
    public override Idocument CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelFactory : DocumentFactory
{
    public override Idocument CreateDocument()
    {
        return new ExcelDocument();
    }
}