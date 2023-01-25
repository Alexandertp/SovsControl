using System;

public class Program {
    public static async Task Main() {
        ActuallyNotAWebAPI actuallyNotAWebAPI = new ActuallyNotAWebAPI();
       NumberFlip numberflip = new NumberFlip(actuallyNotAWebAPI);
       await numberflip.Nummersmider();
    }

}
