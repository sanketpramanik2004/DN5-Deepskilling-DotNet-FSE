DocumentFactory factory;
factory = new WordFactory();
Idocument document = factory.CreateDocument();
document.Open();

factory = new PdfFactory();
document = factory.CreateDocument();
Idocument document1 = factory.CreateDocument();
document.Open();

factory = new ExcelFactory();
document = factory.CreateDocument();
Idocument document2 = factory.CreateDocument();
document.Open();