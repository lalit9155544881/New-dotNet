using System;

namespace lab1
{
   
    Q1TransactionCal
    public static class
    {
        public static void Transaction()
        {
            Console.Write("Enter Number of transactions:");
            int[] arr = { 200, -150, 340, 500, -100 };
            int total = 0;
            foreach (int amount in arr)
            {
                total += amount;
            }
            Console.WriteLine($"Total Amount: {total}");
        }
    }
    Q2AverageCal
    public static class 
    {
        public static void CalculateAverage()
        {
            Console.WriteLine("Calculating Average...");
            float[] arr = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float total = 0;
            foreach (float amount in arr)
            {
                total += amount;
            }
            float average = total / 5;
            Console.WriteLine($"Average Amount: {average}");
        }
    }
    Q3MostExpensiveItem

    public static class 
    {
        public static void Item()
        {
            Console.Write("Enter Number of Item:");
            int[] arr = { 1500, 2300, 999, 3200, 1750 };
            int item = arr[0];
            foreach (int ele in arr)
            {
                if (ele > item)
                {
                    item = ele;
                }
            }
            Console.WriteLine($"Most Expesive item: {item}");
        }
    }
    Q4MaleFemaleCount

   public static class MemberCount
    {
        public static void Count()
        {
            int[] arr = { 1500, 2300, 999, 3200, 1750 };

            int maleCount = 0;     
            int femaleCount = 0;   // odd numbers

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }

            Console.WriteLine($"Male count: {maleCount}, Female count: {femaleCount}");
        }
    }


    Q5ReverseSearchHistory
    public static class 
    {
        public static void Reverse()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            Console.WriteLine("Reversed Search History:");
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                Console.Write(searchHistory[i] + " ");
            }
            Console.WriteLine();
        }
    }

    Q6AdjustMeasurements

    public static class
    {
        public static void Adjust()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            Console.WriteLine("Adjusted Measurements:");
            for (int i = 0; i < measurements.Length; i++)
            {
                measurements[i] *= factor;
                Console.Write(measurements[i] + " ");
            }
            Console.WriteLine();
        }
    }
    Q7SearchBookCode

    public static class 
    {
        public static void Search()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            int index = -1;
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"Book code {searchCode} found at index: {index}");
            }
            else
            {
                Console.WriteLine("Book code not found.");
            }
        }
    }
    Q8SecondSmallestGrade
    public static class 
    {
        public static void FindSecondSmallest()
        {
            int[] grades = { 56, 78, 89, 45, 67 };
            Array.Sort(grades);
            int smallest = grades[0];
            int secondSmallest = -1;

            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > smallest)
                {
                    secondSmallest = grades[i];
                    break;
                }
            }

            if (secondSmallest != -1)
            {
                Console.WriteLine($"Second smallest grade: {secondSmallest}");
            }
            else
            {
                Console.WriteLine("All elements are the same. No second smallest found.");
            }
        }
    }

    Q9RemoveDuplicates
    public static class 
    {
        public static void Remove()
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            List<int> uniqueList = new List<int>();

            foreach (int id in ids)
            {
                if (!uniqueList.Contains(id))
                {
                    uniqueList.Add(id);
                }
            }

            Console.WriteLine("Unique IDs after removing duplicates:");
            foreach (int id in uniqueList)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
    Q10CommonElements
    public static class 
    {
        public static void FindCommon()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };
            List<int> common = new List<int>();

            foreach (int val1 in dataset1)
            {
                foreach (int val2 in dataset2)
                {
                    if (val1 == val2 && !common.Contains(val1))
                    {
                        common.Add(val1);
                    }
                }
            }

            Console.WriteLine("Common elements between dataset1 and dataset2:");
            foreach (int val in common)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }

}