Computer pc = new Computer.Builder()
    .SetCPU("Intel Core i7")
    .SetRAM(16)
    .SetStorage(512)
    .Build();
Console.WriteLine(pc.CPU);
Console.WriteLine(pc.RAM);
Console.WriteLine(pc.Storage);