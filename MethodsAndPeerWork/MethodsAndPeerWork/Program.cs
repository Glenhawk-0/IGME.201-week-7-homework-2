namespace MethodsAndPeerWork
{
    /*
     * Lennon Hare
     * Lydia Jin
     * IGME.201
     * due: Oct/13/2024
     * be sure to look at instructons on mycourses 
     */

    // Lennon is partner A
    // Lydia is partner B
    internal class Program
    {
        // below is the auto comment thing, not too sure how to fill this in 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        //Lennon's Add function  (i gotta use auto comment? whats that?)
        static int Add(int num1, int num2) 
        {//start Add

            //Console.WriteLine("num1: " + num1 + "\tnum2: " + num2 ); //this is for testing and debuging purposes 
            int sum = num1 + num2;
            return (sum);
        }//end Add

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            //varibles,
            //Lennon has set them both to zero intially for the purpose of testing without the need to wait for lydia's code
            int lennonFavoriteNumber = 0; 
            int lydiaFavoriteNumber  = 0;




            //initialize
            lennonFavoriteNumber = 83;
            lydiaFavoriteNumber = 26;


            //Lydia's Subtract function 
            static int Subtract(int num1, int num2)
            {//start subtract

                int difference = num1 - num2;
                return (difference);
            }//end subtract 


            //start of our actual program
            Console.WriteLine("Lennon's favorite number is " + lennonFavoriteNumber + "!");
            Console.WriteLine("Lydia's favorite number is " + lydiaFavoriteNumber + "!");

            //adding favorite numbers 
            int additiveSum = Add(lennonFavoriteNumber,lydiaFavoriteNumber);
            Console.WriteLine("lennon's favorite number plus lydia's favorite number equals " + additiveSum);
            //subtracting favorite numbers 
            int subtractiveDifference = Subtract(lennonFavoriteNumber - 1,lydiaFavoriteNumber);
            Console.WriteLine("lennon's favorite number subtract by lydia's favorit number equals " + subtractiveDifference);

        }//end of static void Main
    }//end of internal class
}//end of namespace 
