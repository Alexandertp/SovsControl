public interface WebAPI {
    Task<int> getNumber();
    Task sendNumber(int i);
}

public class ActuallyNotAWebAPI : WebAPI {
    public async Task<int> getNumber() {
        var generatedNumber = await Task.Run(() => new Random().Next());
        Console.WriteLine("Jeg er blevet tvunget til at lave det her tal " + generatedNumber);
        return generatedNumber;

    }
    public async Task sendNumber(int i) {
        Console.WriteLine("Jeg fik en " + i);

    }
}


public class NumberFlip {
    private WebAPI webapi;
    public NumberFlip(WebAPI webapi) {
        this.webapi = webapi;
    }

    public async Task Nummersmider() {
        var numbersTasks = new[] {
            webapi.getNumber(),
            webapi.getNumber(),
            webapi.getNumber(),
            webapi.getNumber(),
        };

        var numbers = await Task.WhenAll(numbersTasks);

        // var numbers = new[] {
        //     await webapi.getNumber(),
        //     await webapi.getNumber(),
        //     await webapi.getNumber(),
        //     await webapi.getNumber(),
        // };

        await Parallel.ForEachAsync(numbers, async (number, _) =>
            await webapi.sendNumber(MakeHashNumber(number)));

    }
    private int MakeHashNumber(int value) {
        int k = 0;
        for (int i = 0; i < value; i++) {
            k++;
            k %= 10;
        }
        return k;
    }
}
