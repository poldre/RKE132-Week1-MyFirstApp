 // This is a comment to my code


// Rakendus küsib kasutajal sisestada tema nime
// Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string userName;

userName = Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName} !");