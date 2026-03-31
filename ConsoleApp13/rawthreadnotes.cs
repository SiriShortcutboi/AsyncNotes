//create a raw thread, we dont do that often.
//use task, and lock, rather than the low level method use lock to lock your different threads down 100% making them take turns for no overflow
    //threads are very job specific, probably learn it for gaming. 
    //Async you will use most everywhere, its good for you to load websites all at once not just 1 picture at a time.

    //if a client says the program is slow, then you go and change it, threads are so fast so you could honestly make the program kinda slow but computers are so fast,
    // the only bottleneck is going to and from the database.
    //you just have to organize the database and retrieval methods i guess, you dont even have to make it nice, it could be rough organizing but that would still make it faster
public class Program2
{
    static async Task Main()
    {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine($"Task: {i}");
            }
        }); //this looks funky because of the lambda, its all lining up though

    }
}