using System;


namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = Console.ReadLine();

            string[] inputArray = userInput.Split(' ');

            int arrayLength = inputArray.Length;

           if(arrayLength == 3)
            {
                int firstNumber = Convert.ToInt32(inputArray[1]);
                int secondNumber = Convert.ToInt32(inputArray[2]);

                switch (inputArray[0])
                {
                    case "ADD":
                        int answerAdd = Add(firstNumber, secondNumber);
                        Console.WriteLine(answerAdd);
                        break;
                    case "SUB":
                        int answerSub = Sub(firstNumber, secondNumber);
                        Console.WriteLine(answerSub);
                        break;
                    case "DIV":
                        int answerDiv = Div(firstNumber, secondNumber);
                        Console.WriteLine(answerDiv);
                        break;
                    case "MULTI":
                        int answerMulti = Multi(firstNumber, secondNumber);
                        Console.WriteLine(answerMulti);
                        break;
                }
            } else {
                Console.WriteLine("User input is not valid. It should be a command (ADD, SUB, DIV or MULTI) followed by exactly one space followed by a number, then a space, then a final number");
            }



        }

        public static int Add(int one, int two)
        {
            int answer = one + two;
            return answer;
        }

        public static int Sub(int one, int two)
        {
            int answer = one - two;
            return answer;
        }

        public static int Div(int one, int two)
        {
            int answer = one / two;
            return answer;
        }
        public static int Multi(int one, int two)
        {
            int answer = one * two;
            return answer;
        }

    }
}
