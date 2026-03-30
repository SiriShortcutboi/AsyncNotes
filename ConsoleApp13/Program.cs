public class program
{
    static async Task Main()//nice VS code will change your void main to async Task main
    // if you use wait inside the main method
    {
        //Async Notes
        //imagine making breakfast

        //start the toast 
        //wait for the toast to finish
        //then starrt cooking eggs
        //wait for eggs to finish
        //start the steak
        //wait for steak to finish

        //using async solves this, you can do multiple
        //things at the same time.
        //it is often times used in websites so its not loading top to bottom

        //async is not the same thing as threads, but they often
        //walk hand in hand.

//iwant to wait for all my thingsb ut  idont care wha order i get them in
        Console.WriteLine("start breakfast!");
        
        Task steak = MakeSteak();
        Task toast = MakeToast();
        Task Eggs = MakeEggs(3);

        //key piece to make async really work right when all done. happens in the right order before program just dies
        await Task.WhenAll(steak, toast, eggs);
        Console.WriteLine("Breakfast is done");
    }

    public async Task MakeToast()
    {   //you want to know when the toast pops up.
        //its a thing to let us know when the toast is done
                            //not related to Android toast message 
        Console.WriteLine("start cooking breakfast!"); 
        await Task.Delay(2000); 
        Console.WriteLine("Toast is done!");


    }
    public async Task MakeEggs(int numberofEggs)
    {   //you want to know when the toast pops up.
        //its a thing to let us know when the toast is done
                            //not related to Android toast message 
        Console.WriteLine("start cooking eggs!"); 
        await Task.Delay(1000 * numberofEggs); 
        Console.WriteLine("Toast is done!");


    }
    public async Task MakeSteak()
    {   //you want to know when the toast pops up.
        //its a thing to let us know when the toast is done
                            //not related to Android toast message 
        Console.WriteLine("start cooking Steak!"); 
        await Task.Delay(2000); 
        Console.WriteLine("Toast is done!");


    }
}