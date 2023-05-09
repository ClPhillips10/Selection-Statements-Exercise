namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fav number generator
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);

            int favNumber = 9;

            //Whats on screen and collect user var
            Console.Write("Guess my favorite number ");
            var userInput = int.Parse(Console.ReadLine());

           




            //If value is too low

            if (userInput < favNumber)
            {

                Console.WriteLine("You're value is too low ");
            }

            //if value is too high
            else if (userInput > favNumber)
            {
                Console.WriteLine("Value Was too High");

            }

            // user wins
            else
            {
                Console.WriteLine("Congrats thats correct!");

            }


        }
    }
}

   
   

            
       
