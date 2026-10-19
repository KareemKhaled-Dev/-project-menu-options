namespace Project_menu_options2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            char a;
            int number,number2;


            do
            {
                Console.WriteLine("=======================");
                Console.WriteLine("menue options:");
                Console.WriteLine("P - Print number");
                Console.WriteLine("A - Add number");
                Console.WriteLine("M - Display mean of the number");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Sort list");
                Console.WriteLine("D - clear list");
                Console.WriteLine("E -Search for  number");
                Console.WriteLine("Q -Quit ");
                Console.Write("Enter Your choice: ");
                a = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (a)
                {
                    case 'P':
                        PrintNumber(l);
                        break;
                    case 'A':
                        Console.Write("enter the number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        if(AddNumber(number, l) == true)
                        {
                            Console.WriteLine($"the number {number} added");
                        } 
                        break;
                    case 'M':
                        if (MeanNumbers(l) == false)
                        {
                            Console.WriteLine("Unaple to Calculate the mean no-data ");
                            
                        }
                        break;
                    case 'S':
                       if (SmallestNumber(l) == false)
                        {
                            Console.WriteLine("Unaple to Calculate the smallest number no -data");
                        }
                        break;
                    case 'L':
                        if(LargestNumber(l) == false)
                        {
                            Console.WriteLine("Unaple to Calculate the largest number no -data");
                        }

                        break;
                    case 'C':
                        if (SortNumber(l) == true)
                        {
                           PrintNumber(l);
                        }
                        
                        break;
                    case 'D':
                        ClearNumber(l);

                        break;
                    case 'E':

                        Console.Write("enter the number which you want  to srearch: ");
                        number2 =Convert.ToInt32(Console.ReadLine());
                       if (SearchNumber(number2, l) == false)
                        {
                            Console.WriteLine($"the number {number2} is not found");
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("GoodBye");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }

            } while (a != 'Q');

        }
        
        static void  PrintNumber(List<int> l)

        {
            bool result = false;

            for(int i = 0; i < l.Count; i++) 
            {
                
                if (i == 0)
                {
                    Console.Write($"[ {l[i]} ");
                }
                if (i > 0)
                {
                    Console.Write(l[i]+" ");
                }
                 if (i == l.Count - 1)
                {
                    Console.WriteLine($"]");
                }
                result = true;

            }
            if (result == false)
            {
                Console.WriteLine("The list is empty []");
            }

            Console.WriteLine("====================");
        }
        static bool AddNumber(int number,List<int>l)
        {
           bool result = true;
            
            for(int i = 0; i < l.Count; i++)
            {
              
                if (number == l[i])
                {
                    Console.WriteLine($"The number is found at index {i}");
                   
                    result = false;
                    break;
                    
                }
            }
            if (result == true)
            {
                l.Add(number);
                //Console.WriteLine($"the number {number} added");
                result= true;   
            }
            Console.WriteLine("================");
            return result;
        }
        static bool MeanNumbers(List<int> l)
        { 
            int sum = 0;
            bool result = false;
          
            for(int i=0; i < l.Count; i++)
            {
                sum += l[i];
                result = true;
            }
            if (result == true)
            {
                double Avg = (double)sum / l.Count;
                Console.WriteLine($"The mean of the numbers: {Avg}");
            }
            Console.WriteLine("==================");
                return result;
        
        }
        static bool SmallestNumber(List<int> l)
        {
            bool result = false;
            int min=0;
            for (int i = 0; i < l.Count; i++)
            {
                if (i == 0)
                {
                    min = l[0];
                }
                if (l[i] < min)
                {
                    min=l[i];
                }
                result= true;
            }
            if(result == true)
            {
                Console.WriteLine($"The smallest number is:{min}");
            } 

            Console.WriteLine("====================");

            return result;
        }
        static bool LargestNumber(List<int> l)
        {
            int max = 0;
            bool result = false;
         
                for(int i=0; i < l.Count; i++)
                {
                    if (l[i] > max)
                    {
                        max=l[i];
                        result = true;
                    }
                }
            
            if(result == true)
            {
                Console.WriteLine($"The max of number: {max}");
            }
            Console.WriteLine("===============");
            return result;

        }
        static bool SortNumber(List<int> l)
        {
            bool result = false;
            for(int i = 0; i < l.Count; i++)
            {
                for(int j = i + 1; j < l.Count; j++)
                {
                    if(l[j] < l[i])
                    {
                        int temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                   
                }
                result = true;
            }
          if( result == false)
            {
                Console.WriteLine("the list is empty - []");
            }
               
            return result;
        }
        static bool ClearNumber(List<int> l)
        {
            bool result = false;
            for(int i = 0; i < l.Count; i++)
            {
                l.Remove(l[i]);
                result = true;
            }
            if( result == false)
            {
                Console.WriteLine("The list is already clear");
            } else if ( result == true)
            {
                Console.WriteLine("the list after clear []");
            }

            return result;
        }
        static bool SearchNumber(int number, List<int> l)
        {
            bool result = false;
            for (int i = 0; i < l.Count; i++)
            {

                if (number == l[i])
                {
                    Console.WriteLine($"The number is found at index {i}");

                    result = true;
                    break;

                }
            }
            return result;

        }
    }
}
