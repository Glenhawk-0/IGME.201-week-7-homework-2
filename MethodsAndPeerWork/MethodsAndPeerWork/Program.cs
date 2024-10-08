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
            //initialize your number lydia (replace this comment with your code)


            //Lydia's Subtract function 


            //start of our actual program
            Console.WriteLine("Lennon's favorite number is " + lennonFavoriteNumber + "!");
            // write your favorite number in the console (replace this comment with your code)


            int additiveSum = Add(lennonFavoriteNumber,lydiaFavoriteNumber);
            Console.WriteLine("lennon's favorite number plus lydia's favorite number equals " + additiveSum);
            // lydia calling their Subtract function (replace this comment with your code)  
            //lydia's message to the console for their subract method (replace this comment with your code)  

        }//end of static void Main
    }//end of internal class
}//end of namespace 
