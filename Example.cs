class Example {
    public static void EatMyCPU(int id) {
        Console.WriteLine("Thread Nr. " + Thread.CurrentThread.ManagedThreadId + " er startet");
        for (long i = 0; i < 500000000; i++) {

        }
        Console.WriteLine("Thread Nr. " + Thread.CurrentThread.ManagedThreadId + " er sluttet");
    }

    public static async Task Eksempel() {
        int i = 0;
        Console.WriteLine("Her er den nemme måde, kørt parallelt");
        while (i < 4) {
            EatMyCPU(i);
            i++;
        }
        Console.WriteLine("Her er fire awaits der kører asyncront, callet lige efter hinanden");
        await EatMyCPUAsync();
        await EatMyCPUAsync();
        await EatMyCPUAsync();
        await EatMyCPUAsync();
        Console.WriteLine("Her tager vi først og lægger dem i variabler, som vi smider i et array, som så alle bliver sat i gang samtidig");
        var bingbong = EatMyCPUAsync();
        var bongbing = EatMyCPUAsync();
        var SimonPls = EatMyCPUAsync();
        var HelpMe = EatMyCPUAsync();
        var diller = new Task[] { bingbong, bongbing, SimonPls, HelpMe };
        await Task.WhenAll(diller);

        Console.WriteLine("Simon fik mig til at kode sort magi til det her, tjek dokumentation reference #452352 stk. B for mere info");
        var av1 = () => EatMyCPU(1);
        var av2 = () => EatMyCPU(1);
        var av3 = () => EatMyCPU(1);
        var av4 = () => EatMyCPU(1);
        var daller = new[] { av1, av2, av3, av4 };
        Parallel.Invoke(daller);



        Console.WriteLine("Done for real!");

    }
    public static async Task EatMyCPUAsync() {
        int asyncI = 0;
        await Task.Run(() => EatMyCPU(asyncI));
    }
}
