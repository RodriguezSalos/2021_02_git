//length of string:
String txt = "ASASDASDASDASD"
Console.WriteLine("The  length of the ttxt string is: " + txt.Length);

//string converted to UPPERCASE or lowercase
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

//concatenation
string name = firstName + lastName;
Console.WriteLine(name);

string name = string.Concat(firstName, lastName);
Console.WriteLine(name);

//string interpolation
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

//Get  character
string myString = "Hello";
//fist character [0] second [1] ..etc...
Console.WriteLine(myString[0]);  // Outputs "H"

//Get string since an specifc character  OUTPUT= Rodriguez Gignac
          // Full name
            string name = "Salome Rodriguez Gignac";

            // Location of the letter D
            int charPos = name.IndexOf("R");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

//Especial character into string input
//OUTPUT message: We are the so-called "Vikings" from the north.
 string txt = "We are the so-called \"Vikings\" from the north.";
 //OUTPUT message: It's alright.
 string txt = "It\'s alright.";
 //	OUTPUT message: The character \ is called backslash.
 string txt = "The character \\ is called backslash.";

//		New line \n
      string txt = "Hello\nWorld!";
      Console.WriteLine(txt);	
	  //Hello
	  //World!
	  
// 		\t	Tab
	string txt = "Hello\tWorld!";
	Console.WriteLine(txt); //Hello   World!
	
//		\b	Backspace
      string txt = "Hel\blo World!";
      Console.WriteLine(txt); //Helo World!

//IF == Short Hand If...Else (Ternary Operator)

//IF
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

//Short Hand If...Else (Ternary Operator)
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);



//Loop While
   static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
//Loop Do/while
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
            {
               i+=5;
                //Console.WriteLine("Eso eso eso eso eso eso eso es tooooodooooo amigos!!!");
                Console.WriteLine(i);
            }

// For Loop
for (statement 1; statement 2; statement 3) 
Statement 1 is executed (one time) before the execution of the code block.
Statement 2 defines the condition for executing the code block.
Statement 3 is executed (every time) after the code block has been executed.

for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}


//Loop break/continue
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}
/*OUTPUT
0
1
2
3
*/

for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}
/* OUTPUT:
0
1
2
3
5
6
7
8
9
*/


//There is also a foreach loop, which is used exclusively to loop through elements in an array:
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] myNum = {10, 20, 30, 40};

foreach (string i in cars) 
{
  Console.WriteLine(i);
}
/*OUTPUT:
Volvo
BMW
Ford
Mazda
*/ 

/*EDIT*/cars[0] = "Opel";

//To get the number of elements in the array by using lenght 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4

//For loop, and use the Length property to specify how many times
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}

///////////////////////////////////////////////////////////////////////////
//Order sorts an array alphabetically or in an ascending order:

// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}

// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}

/*OUTPUT
BMW
Ford
Mazda
Volvo
1
5
8
9
*/


//foreach loop:
//The following example outputs all elements in the cars array, using a foreach loop:
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}



