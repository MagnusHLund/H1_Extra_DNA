namespace H1_Extra_DNA
{
    internal class Program
    {
        static void Main()
        {
            Controller();
        }

        #region Controllers

        static void Controller()
        {
            // Infinite loop
            while (true)
            {
                // Creates 2 empty char arrays, for the shortest and longest of the 2 input arrays
                char[] shortestArray;
                char[] longestArray;

                // Gets 2x user inputs
                Message("Write anything");
                char[] input1 = Console.ReadLine().ToCharArray();

                Message("Write anything again");
                char[] input2 = Console.ReadLine().ToCharArray();

                // Determines which are the shortest and longest arrays
                if(input1.Length < input2.Length)
                {
                    shortestArray = input1;
                    longestArray = input2;
                } else
                {
                    shortestArray = input2;
                    longestArray = input1;
                }

                // Creates a new int and sets the value to be the length of the longest array
                int hammingDistance = longestArray.Length;

                // Runs a for loop the same amount of times as the shortest arrays length
                for(int i  = 0; i < shortestArray.Length; i++)
                {
                    // If the same [i] position are the same character then decrease the hammingDistance by 1
                    if (input1[i] == input2[i])
                    {
                        hammingDistance--;
                    }
                }

                // Outputs the hammingDistance result and repeats the program, when the user presses enter
                Message($"Hamming distance is {hammingDistance}\nPress enter to continue");
                Console.ReadLine();
            }
        }

        #endregion

        #region Views

        static void Message(string msg)
        {
            // Writes anything that is written when the Message method gets called
            Console.WriteLine(msg);
        }

        #endregion
    }
}