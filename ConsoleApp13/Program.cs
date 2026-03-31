public class program
{
    //nice VS code will change your void main to async Task main
    // if you use wait inside the main method
    static async Task Main()
    {
        // Async - threads
        //Thread - how work is scheduled. How efficient is the worker.
        //Async/await  The amount ouf workers
    //    ? & or / ?
        //runs code independently - concurrent work

        Thread t = new Thread(PrintNumbers);
        t.Start();
        
        Thread tt = new Thread(PrintNumbers);
        tt.Start();
        //i care more that you know what a race condition is than you trying to solve it, the code to solve it is so weird
        //basically both of these threads look at the thing, and they dont wait their turn to look and changea 5 to a 6.

        Console.WriteLine("Main thead running...");

    }
    
    private static void PrintNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            
        }
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