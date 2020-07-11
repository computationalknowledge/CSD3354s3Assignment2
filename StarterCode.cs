using System;

namespace MySimuation
{
    // UPLOAD YOUR FINISHED WORK PRODUCT TO https://t2m.io/Assignment2  
    // This is assignment 2: It is due before start of class on July 18
    // You can access the UML Diagram doing the Enterprise Modelling for this solution at  https://www.screencast.com/t/Kl60Ynm4EZF
    // You will write a C# application to simuate a process such as Making Breakfast
    // Here are all the objects we need to simulate
    // We have developed the Model together now you must write the controller.
    // Next week we will serve this up as a Web application: and that will provide the View.
    // You will have now made a Model View Controller Application!
    // NOTE: If we wanted to do this in FORMAL software engineering way, we would use a Software Development Methodology such as Unified Process!
    // What you are to hand in:
    // Write your Code to finish making this application work.
    // Put your code into a text file named as StudentName-StudentID.cs
    // include include comments at the top:
    // Assignment 2 - Building the Model-View-Controller Application
    // Name
    // Student ID
    // Date submitted
    // CSD2354  Section 3
    
    class Controller
    {
        // ToDo: Implement this algorithm:
        // How I will grade your Program:
        // I will will write a main method. I will create an Object from Class "Controller". 
        // I will call the MakeBreakfast() method
        // Your application should output a series of messages using Console.Writeln reporting on the progress of how
        // each item of food is being prepared and served.
        // Implement this Algorithm for making breakfast:
        // 1. Make the coffee: GUARD CONDITION: start making the Toast when coffee is ready
        // 2. Toast the bread
        // 3. Start we have started toasting the bread, serve the yogurt and fruit by putting it into bowls
        // 4. modify the contents array of the fridge to remove the yogurt and fruit that we are serving
        // 5. for whole wheat or white toast
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Fridge
    {
        string[] contents = { "Bread", "Yogurt", "Cherries", "Butter", "Oranges", "Peach Juice" };
    }

    class Toaster
    {
        public int darkness = 0;
        public bool ToastBread()
        {
            return true;
        }
    }

    class CoffeeMaker
    {
        public bool makeCoffee()
        {
            return true;
        }
    }

    class Coffee
    {
        public String kindOfCoffee ;
        public int TimeToMake;
    }

    class Fruit
    {
        public String kindOfFruit;
    }

    class Yogurt
    {
        public String flavor;
    }

    class Bread
    {
        public String kindOfBread = null;
    }
}
