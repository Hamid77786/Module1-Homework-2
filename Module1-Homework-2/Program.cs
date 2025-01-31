//1.Massivin cəmini tapın.

//Console.WriteLine("Enter massiv n:");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sum = 0;
//for(int i=0; i < n; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < mass.Length; i++)
//{
//    sum += mass[i];

//}
//Console.WriteLine(sum
//-----------------------------------------------
//5.Massivdəki cüt ədədlərin cəmini tapın.

//Console.WriteLine("Enter massiv n:");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int sumDigitTwo = 0;
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//for(int i = 0; i < mass.Length; i++)
//{
//    if (mass[i] % 2 == 0)
//    {
//        sumDigitTwo += mass[i];
//    }
//}
//Console.WriteLine(sumDigitTwo);
//---------------------------------------------------
//3.Massivdə müəyyən bir ədədin olub olmadığını yoxlayın.

//Console.WriteLine("Enter the Count of Mass:");
//int countOfMass = int.Parse(Console.ReadLine());
//int[] mass = new int[countOfMass];
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Enter the number and Check:");
//int number = int.Parse(Console.ReadLine());
//for (int i = 0; i < mass.Length; i++)
//{
//    if (mass[i] == number)
//    {
//        Console.WriteLine(mass[i]);
//    }
//    else
//    {
//        Console.WriteLine("Number is not exist!");
//        break;
//    }
//}
//--------------------------------------------------------------
//2.Massivin elementləri arasında ortalamasını tapın.

//Console.WriteLine("Enter the Count of Massiv:");
//int countOfMass = int.Parse(Console.ReadLine());
//int[] mass = new int[countOfMass];
//int sum = 0;
//int count = 0;
//int average;
//Console.WriteLine("Enter the massiv elements:");
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Find the average number:");
//for (int i = 0; i < mass.Length; i++)
//{
//    sum += mass[i];
//    count++;
//}
//average = sum / count;
//Console.WriteLine(average);
////-------------------------------------------------------------------
////4. Massivdəki ən kiçik və ən böyük ədədləri tapın.

//Console.WriteLine("Enter the count of massiv:");
//int countOfMass = int.Parse(Console.ReadLine());
//int[] mass = new int[countOfMass];
//Console.WriteLine("Enter the elements of massiv:");
//for(int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//int min = mass[0];
//int max = mass[0];
//for (int i = 1; i < mass.Length; i++)
//{
//    if (mass[i] < min)
//    {
//        min = mass[i];
//    }
//    if (mass[i]>max)
//    {
//        max = mass[i];
//    }
//}
//Console.WriteLine("Minimum number"+" "+min);
//Console.WriteLine("Maximum number"+" "+max);
//----------------------------------------------------------
////8.Massivin bütün elementlərinin 2 qatını tapın və yeni massiv yaradın.

//Console.WriteLine("Enter the count of massiv:");
//int countOfMass = int.Parse(Console.ReadLine());
//int[] mass = new int[countOfMass];
//Console.WriteLine("Enter the elements of massiv:");
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Find Square massiv numbers and create new massiv with square:");
//int[] newMass = new int[countOfMass];
//for(int i = 0; i < newMass.Length; i++)
//{
//    newMass[i] =mass[i]* mass[i];
//    Console.WriteLine(newMass[i]);

//}
//-------------------------------------------------------------------------------------
//6.Massivin tərsinə dövr etməklə yeni massiv yaradın.

//Console.WriteLine("Enter count of massiv:");
//int countOfMass = int.Parse(Console.ReadLine());
//int[] mass = new int[countOfMass];
//Console.WriteLine("Enter the elements of massiv:");
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Find and Reverse elements of massiv:");
//for (int i =mass.Length-1;i>-1;i--)
//{

//    Console.WriteLine(mass[i]);
//}



