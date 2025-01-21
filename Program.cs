//part 1
Console.WriteLine("Hello, World!");
//part 2
string aFriend = "Bill";
Console.WriteLine(aFriend);aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");
//part 3
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
//part 4
string greeting = " Hello World! ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
//part 5
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
//part 6
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
//part 7
//just says the source for it can be found on github
