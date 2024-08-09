// Console.WriteLine("Hello wesley");
// Console.WriteLine("Enter your name:");
// string name = Console.ReadLine();
// Console.WriteLine("Hello, " + name);



// Console.WriteLine("Enter your age:");
// int age = int.Parse(Console.ReadLine()); 
// Console.WriteLine("your age is "+ age );


// string d = 9.78;
// int i = (int)d; 


// int age =20;
// if (age>20)
// {
//     Console.WriteLine("you are eligible to give vote ");

// }
// else
// {
//     Console.WriteLine($"you cant give the vote");

// }
// Console.WriteLine($"hii whats your name");
// string name  =Console.ReadLine();
// Console.WriteLine($"hii {name}");



// int numberOne  , numberTwo ,ans;
// Console.WriteLine("Enter the numbers");

// string one = Console.ReadLine();
// numberOne = int.Parse(one);
//  string two =Console.ReadLine();
//  numberTwo = int.Parse(two);
//  ans=numberOne+numberTwo;
// Console.WriteLine("Sum is :" +ans);




// int numberOne = 0;
// int numberTwo = 0;
// Console.WriteLine($"Enter number to muliply");
// string enteredNumberOne = Console.ReadLine();
// numberOne = int.Parse(enteredNumberOne); 
// string enteredNumberTwo = Console.ReadLine();
// numberTwo = int.Parse(enteredNumberTwo);
// Console.WriteLine($"The Answer is "+ (numberOne*numberTwo));










// int numberOne ;
// int numberTwo ;
// Console.WriteLine($"Enter number to muliply");
//  numberOne = Convert.ToInt32(Console.ReadLine());
// // numberOne = int.Parse(enteredNumberOne); 
//  numberTwo = Convert.ToInt32(Console.ReadLine());
// // numberTwo = int.Parse(enteredNumberTwo);
// Console.WriteLine($"The Answer is "+ (numberOne*numberTwo));


// int[] array = {10,22,33,44,55,66};
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]}  " );

// }

// try
// {
//     string guessWord = "giraffee";
//     string guess = "";
//     int times = 4;

//     do
//     {
//         Console.Write($"Enter guess: ");

//         guess = Console.ReadLine();

//         times--;
//         if (guess != guessWord)
//         {
//             if (times == 0)
//             {
//                 Console.WriteLine($"You loast the answer was " + guessWord);
//                 break;


//             }
//             Console.WriteLine("You have " + times + " guess left");
//             Console.WriteLine($"Sorry try again");



//         }


//     } while (guessWord != guess);

//     if (guessWord == guess)
//     {
//         Console.WriteLine($"You won!");


//     }
// }
// catch (Exception e)
// {

//     Console.WriteLine($"{e.Message}");

// }


// //classes and objects 
// class Book
// {
//   public string title;
//   public string author;
//   public int pages;

// }


// class Program
// {
//   static void Main(string[] args)
//   {
//     Book fictionBook1 = new Book(); //object creation 
//     fictionBook1.title = "Harry porter";
//     fictionBook1.author = "Jk rowling";
//     fictionBook1.pages = 342;


//     Book selfDiscoveryBook = new Book(); //object creation
//     selfDiscoveryBook.title = "Rudest book ever";
//     selfDiscoveryBook.author = "Shwetab gangwar";
//     selfDiscoveryBook.pages = 142;


//     Console.WriteLine($"The name of two Books are " + selfDiscoveryBook.title + "" + fictionBook1.title);
//     Console.WriteLine($"Both of the books contains almost " + (fictionBook1.pages + selfDiscoveryBook.pages) + " Pages");
//     Console.WriteLine($"The author of Books are " + selfDiscoveryBook.author + " and " + fictionBook1.author);
//     Console.ReadLine();

//   }

// }



//constructors 


// using System.Configuration.Assemblies;

// class Book
// {
//   public string title;
//   public string author;
//   public int pages;


//   //adding consutuctor 
//   //every time you add a  new object the consturtor will automatically called 
//   public Book(string personName )
//   {
//     Console.WriteLine($" creating book for "+ personName);

//   }

// }


// class Program
// {
//   static void Main(string[] args)
//   {
//     Book fictionBook1 = new Book("Wesley"); //object creation 
//     fictionBook1.title = "Harry porter";
//     fictionBook1.author = "Jk rowling";
//     fictionBook1.pages = 342;


//     Book selfDiscoveryBook = new Book("Cris evan"); //object creation
//     selfDiscoveryBook.title = "Rudest book ever";
//     selfDiscoveryBook.author = "Shwetab gangwar";
//     selfDiscoveryBook.pages = 142;


//     Console.WriteLine($"The name of two Books are " + selfDiscoveryBook.title + "" + fictionBook1.title);
//     Console.WriteLine($"Both of the books contains almost " + (fictionBook1.pages + selfDiscoveryBook.pages) + " Pages");
//     Console.WriteLine($"The author of Books are " + selfDiscoveryBook.author + " and " + fictionBook1.author);
//     Console.ReadLine();

//   }

// }



//object method

// using System.Collections.Concurrent;

// class Student
// {
//   public string name;
//   public int gpa;
//   public string subject;


//   public Student (string aName , int aGpa , string aSubject)
//   {
//     name = aName;
//     gpa =aGpa;
//     subject = aSubject;

//   }


//   public bool gpaDecider()
//   {
//     if (gpa >= 3.5)
//     {
//       return true;
//     }
//     return false;

//   }
// }

// class Program
// {
//   static void Main (string[] args)
//   {
//     Student student1 = new Student("wesley",4, "MBBS");
//     Student student2 = new Student("parvendra " ,2, "btech");
//     Console.WriteLine(student1.gpaDecider());
//     Console.WriteLine(student2.gpaDecider());
//     Console.ReadLine();

//   }

// }


//getters and setter in the c sharp 
// class Movie
// {
//     public string movieName;
//     public string movieRating;
//     public string movieDirector;


//     public Movie(string amovieName, string amovieRating, string amovieDirector)
//     {
//         movieName = amovieName;
//         movieRating = amovieRating;
//         movieDirector = amovieDirector;

//     }

//     public string movieDecider()
//     {
//         if (movieRating > 3.5)
//         {
//             return "The movie is worth watching ";
//         }
//         else
//         {
//             return "The movie is not at all worthy";
//         }

//     }

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Movie movie1 = new Movie("Avengers", 4.2, "Russo brothers");
//         Movie movie2 = new Movie("Pirates of carebbiena ", 2.9, "redChilli corporation");

//         Console.WriteLine(movie2.movieDecider());


//     }

// }


//getter setter
using System;

class Movie
{
    public string movieName;
    private string movieRating;
    public string movieDirector;

    public Movie(string amovieName, string amovieRating, string amovieDirector)
    {
        movieName = amovieName;
        MovieRating = amovieRating;
        movieDirector = amovieDirector;
    }

    public string MovieRating
    {
        get { return movieRating; }
        set
        {
            if (value == "A" || value == "B" || value == "C" || value == "D" || value == "E")
            {
                movieRating = value;
            }

        }
    }


}

class Program
{
    static void Main(string[] args)
    {

        Movie movie1 = new Movie("Avengers", "A", "Russo brothers");
        Movie movie2 = new Movie("Pirates of the Caribbean", "B", "RedChili Corporation");

        Console.WriteLine(movie1.movieName);
        Console.WriteLine(movie2.movieName);


    }
}
