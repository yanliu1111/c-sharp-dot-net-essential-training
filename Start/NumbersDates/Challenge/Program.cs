// See https://aka.ms/new-console-template for more information
string thedate = "";  
DateTime today = DateTime.Today;

do {
    Console.WriteLine("Which date? (or 'exit')");
    thedate = Console.ReadLine();

    if (thedate == "exit") {
        break;
    }

    DateTime parsedDate;
    TimeSpan ts; //means time span (difference between two dates)
    if (DateTime.TryParse(thedate, out parsedDate)){
        if (parsedDate < today) {
            ts = today - parsedDate;
            Console.WriteLine($"That was {ts.TotalDays} days ago.");
        }
        else if (parsedDate > today) {
            ts = parsedDate - today;
            Console.WriteLine($"That is {ts.TotalDays} days from now.");
        }
        else {
            Console.WriteLine("That is today!");
        }
    }
    else {
        Console.WriteLine("I don't understand that date.");
    }
}while (thedate != "exit");
