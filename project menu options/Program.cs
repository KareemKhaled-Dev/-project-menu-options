namespace project_menu_options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List <int>();
            char a;
            int number1, number2;
            int y = 0 ,sum=0,count=0,max=0,min=0;
            double mean=0;
            
            do
            {
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
                a = Convert.ToChar(Console.ReadLine());
                if(a == 'A' || a == 'a')
                {
                    Console.Write("Enter the number: ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    for(int i=0; i < l.Count; i++)
                    {
                        if(l[i] == number1)
                        {
                            Console.WriteLine($"The number is found at index:{i}");
                            y = 1;
                            break;

                        }
                    }
                    if (y == 0)
                    {
                        l.Add(number1);
                        Console.WriteLine($"the number {number1} Added");
                    }
                    y = 0;
                    Console.WriteLine("             ");
                }
                else if (a == 'P' || a == 'p')
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write($"[ {l[i]} ");
                        }
                        if (i>0 ) 
                        {
                           
                            Console.Write(l[i] + " ");
                        }
                        if (i == l.Count - 1)
                        {
                            Console.WriteLine("]");
                        }
                            y = 2;
                            

                        }
                    if (y == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    y = 0;
                    Console.WriteLine("             ");

                }
                if (a == 'M' || a == 'm')
                {
                    
                    for (int i = 0; i < l.Count; i++)
                    {

                        sum += l[i];
                        mean = (double)sum / (i + 1);
                        y = 3;
                    }
                    if (y == 3)
                    {
                        Console.WriteLine($"The mean of the number: {mean}");
                        
                    }
                    else if (y == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    y = 0;
                    sum = 0;
                    Console.WriteLine("             ");

                }
                if(a == 'S' || a == 's')
                {
                    
                    
                    for(int i=0; i < l.Count; i++)
                    {
                        if (i==0)
                        {
                            min = l[0];

                        }
                        if (l[i] < min)
                        {
                            min=l[i];
                        }
                        y = 4;
                        
                    }
                    if(y == 4)
                    {
                        Console.WriteLine($"The smallest number is: {min}");
                    } 
                    else if(y == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    y = 0;
                    min = 0;
                    Console.WriteLine("             ");

                }
                if (a == 'L' || a == 'l')
                {
                    for(int i = 0; i < l.Count; i++)
                    {
                        if (l[i] > max)
                        {
                            max=l[i];
                            y = 5;
                        }
                    }
                    if (y == 5)
                    {
                        Console.WriteLine($"The largest number is: {max}");
                    }
                    else if (y == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    y = 0;
                    max = 0;
                    Console.WriteLine("             ");
                }
                if(a == 'C' || a == 'c') 
                {
                    for(int i= 0; i < l.Count; i++)
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
                        y = 6;
                    }
                    if (y == 6)
                    {
                        for (int i = 0; i < l.Count; i++)
                        {
                            if (i == 0)
                            {
                                Console.Write($"[ {l[i]} ");
                            }
                            if (i > 0)
                            {
                                Console.Write(l[i] + " ");
                            }
                            if (i == l.Count - 1)
                            {
                                Console.WriteLine("]");
                            }
                        }
                    }
                    else if (y == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    y = 0;
                    Console.WriteLine("             ");
                }
                if (a == 'D' || a == 'd')
                {
                    for(int i=0; i < l.Count; i++)
                    {
                        l.Remove(l[i]);
                        y = 7;
                    }
                    if (y == 7)
                    {
                        Console.WriteLine("The list after clear [ ]");
                    }
                    else if (y == 0)
                    {
                        Console.WriteLine("The list already clear");
                    }
                    y = 0;
                    Console.WriteLine("             ");
                }

                if (a == 'E'||a=='e')
                {
                    Console.Write("Enter the number you want to search: ");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < l.Count; i++)
                    {
                        if (l[i] == number2)
                        {
                            Console.WriteLine($"the number is found at index: {i}");
                            y = 8;
                            break;
                        }
                    }
                    if (y == 0)
                    {
                        Console.WriteLine("The number is not found at list");
                    }
                    y = 0;
                    Console.WriteLine("             ");
                }
                if (a == 'Q' || a == 'q')
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invaild input!");

                    Console.WriteLine("             ");

                }


                } while (a != 'Q'&& a !='q');
        }
    }
}
