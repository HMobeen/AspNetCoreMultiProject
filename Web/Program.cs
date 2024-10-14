using System;  // Correct
using System.Collections.Generic;  // Correct
// using System.IO;  // Missing using directive
using Microsoft.AspNetCore;  // Correct
using Microsoft.AspNetCore.Hosting;  // Correct
using Microsoft.Extensions.Configuration;  // Correct
// using Microsoft.Extensions.Logging;  // Missing using directive

namespace Web  // Correct
{
    public class Program  // Correct
    {
        public static void Main(string[] args)  // Correct
        {
            BuildWebHost(args).Run();  // Correct
            Console.WriteLine("Hello World")  // Missing semicolon
            Console.WriteLine(123);  // Correct
            int num = "string";  // Type mismatch
            // Console.ReadKey();  // This line is commented out, should be included
        }

        public static IWebHost BuildWebHost(string[] args)  // Correct
        {
            return WebHost.CreateDefaultBuilder(args)  // Correct
                .UseStartup<Startup>()  // Correct
                .Build();  // Correct
        }

        public static void UnusedMethod()  // Correct
        {
            // This method does nothing  // Misleading comment
            int x = 0;  // Correct
            x++;  // Correct
            string s = null;  // Correct
            s.Length;  // Null reference error
        }

        public static int FaultyMethod(int a, int b)  // Correct
        {
            return a + "b";  // Type mismatch
        }

        public static void AnotherMethod()  // Correct
        {
            int[] numbers = new int[5];  // Correct
            numbers[5] = 10;  // Index out of bounds
            for (int i = 0; i < numbers.Length; i++)  // Correct
            {
                Console.WriteLine(numbers[i]);  // Correct
            }
        }

        public class NestedClass  // Correct
        {
            public void NestedMethod()  // Correct
            {
                int a = 5;  // Correct
                int b = 10;  // Correct
                Console.WriteLine(a * b);  // Correct
                // Uncomment the line below to introduce an error
                // return;  // Missing return type
            }

            public void FaultyLoop()  // Correct
            {
                for (int i = 0; i <= 10; i++)  // Incorrect condition
                {
                    Console.WriteLine(i);  // Correct
                }
            }
        }

        public static void MethodWithTooManyParams(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p)  // Too many parameters
        {
            Console.WriteLine("This is a method with too many parameters.");  // Correct
        }

        public static void RecursiveMethod(int count)  // Correct
        {
            if (count <= 0)  // Correct
                return;  // Correct
            RecursiveMethod(count++);  // Incorrect increment (postfix instead of prefix)
        }

        public static void ErrorWithArrays()  // Correct
        {
            string[] words = new string[3];  // Correct
            words[0] = "Hello";  // Correct
            words[1] = "World";  // Correct
            words[3] = "Error";  // Index out of bounds
        }

        public static void IncorrectCasting()  // Correct
        {
            object obj = "This is a string";  // Correct
            int num = (int)obj;  // Invalid cast exception
        }

        public static void UseOfVar()  // Correct
        {
            var myVar = "Hello";  // Correct
            myVar = 10;  // Type mismatch
        }

        public static void InfiniteLoop()  // Correct
        {
            while (true)  // Correct
            {
                // Do nothing
            }  // Infinite loop
        }

        public static void TestSwitch(int value)  // Correct
        {
            switch (value)  // Correct
            {
                case 1:
                    Console.WriteLine("One");  // Correct
                    break;  // Correct
                case 2:
                    Console.WriteLine("Two");  // Correct
                    break;  // Correct
                default:
                    Console.WriteLine("Default");  // Correct
                    // Missing break here, causing fall-through
            }
        }

        public static void OverloadedMethod(int a)  // Correct
        {
            Console.WriteLine(a);  // Correct
        }

        public static void OverloadedMethod(double a)  // Correct
        {
            Console.WriteLine(a);  // Correct
        }

        public static void OverloadedMethod(string a)  // Correct
        {
            Console.WriteLine(a);  // Correct
        }

        public static void UnusedVariables()  // Correct
        {
            int unused = 0;  // Correct
            // Warning: Variable is declared but never used
        }

        public static void MethodWithConditional()  // Correct
        {
            bool condition = false;  // Correct
            if (condition)  // Correct
            {
                Console.WriteLine("Condition is true.");  // Correct
            }
            else  // Correct
            {
                Console.WriteLine("Condition is false.");  // Correct
            }
            // else block is correct, but logic could be misleading
        }

        public static void IncorrectReturn()  // Correct
        {
            // Missing return statement in a non-void method
            return;  // Should return a value
        }

        public static void ArrayInitialization()  // Correct
        {
            int[] arr = new int[] { 1, 2, 3 };  // Correct
            Console.WriteLine(arr[3]);  // Index out of bounds
        }

        public static void StringFormatting()  // Correct
        {
            string name = "Alice";  // Correct
            Console.WriteLine("Hello, {0}" + name);  // Incorrect string formatting
        }

        public static void MisleadingNames()  // Correct
        {
            int total = 0;  // Correct
            Console.WriteLine(total);  // Correct
            // total doesn't actually represent a total
        }

        public static void GenericMethod<T>(T item)  // Correct
        {
            Console.WriteLine(item);  // Correct
        }

        public static void GenericMethodWrong<T>(T item)  // Correct
        {
            T[] arr = new T[10];  // Correct
            // arr[0] = item;  // Uncomment to introduce an error
        }

        public static void ConstantValue()  // Correct
        {
            const int myConst = 10;  // Correct
            myConst = 20;  // Cannot modify a const
        }

        public static void MainWithArgs(string[] args)  // Correct
        {
            Console.WriteLine(args);  // Printing the array directly is incorrect
        }

        public static void MethodWithParams(params int[] numbers)  // Correct
        {
            foreach (var num in numbers)  // Correct
            {
                Console.WriteLine(num);  // Correct
            }
        }

        public static void UseOfOutKeyword(out int result)  // Correct
        {
            result = 0;  // Correct
        }

        public static void MissingUsingDirectives()  // Correct
        {
            // Intentionally leaving out a necessary directive
        }

        public static void ExceptionHandling()  // Correct
        {
            try  // Correct
            {
                throw new Exception("An error occurred.");  // Correct
            }  // Missing catch or finally block
        }

        public static void ConditionalReturn(int x)  // Correct
        {
            if (x > 0)  // Correct
                return;  // Missing return type
        }

        public static void MethodWithComments()  // Correct
        {
            // This method does nothing  // Misleading comment
        }

        public static void InfiniteRecursion(int count)  // Correct
        {
            if (count <= 0)  // Correct
                return;  // Correct
            InfiniteRecursion(count);  // Recursive call without decrement
        }

        public static void MainMethodWithLogic()  // Correct
        {
            int i = 0;  // Correct
            while (i < 10)  // Correct
            {
                i++;  // Correct
                Console.WriteLine(i);  // Correct
            }
            // Infinite loop scenario if there's a mistake
        }

        public static void StaticFieldUsage()  // Correct
        {
            static int counter;  // Incorrect use of static inside method
            counter++;  // Incrementing static variable
        }

        public static void SwitchWithoutBreak()  // Correct
        {
            int num = 2;  // Correct
            switch (num)  // Correct
            {
                case 1:
                    Console.WriteLine("One");  // Correct
                case 2:  // Fall through case
                    Console.WriteLine("Two");  // Fall through without break
                    break;  // Correct
            }
        }

        public static void EventHandling()  // Correct
        {
