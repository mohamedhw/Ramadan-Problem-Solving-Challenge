namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]);
    }
        public static int FindMaxConsecutiveOnes(int[] arr)
        {
            int counter = 0;
            int maxCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1 && counter == 0)
                {
                    counter++;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == 1) counter++;
                        else
                        {
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                            }
                            counter = 0;
                            break;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                
            }
            
            return maxCounter;
        }

    }
    
    
}


