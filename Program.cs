PreStart();

static void PreStart()
{
    Console.WriteLine("Preparar");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar");
    Thread.Sleep(1000);
    Console.WriteLine("Fogo");
    Thread.Sleep(1000);
    Stopwach();
}

static void Stopwach()
{
    var time = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Para parar a contagem precione Ctrl+C.");
        Console.WriteLine(time);
        time++;
        Thread.Sleep(1000);
    }

}