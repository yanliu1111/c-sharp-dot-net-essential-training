using System.Text.RegularExpressions;

static string ReverseDateFormats(string sourceDate) {
    const int TIMEOUT = 1000;
    try {
        return Regex.Replace(sourceDate,
               @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
              "${year}-${mon}-${day}", RegexOptions.None,
              TimeSpan.FromMilliseconds(TIMEOUT));
    }
    catch (RegexMatchTimeoutException) {
        return sourceDate;
    }
    
}
//do loop that prompts the user for an input date and run until user types the word "exit"
do {
    Console.WriteLine("Date to Convert? (Use mm/dd/yyyy, or 'exit' to quit)");
    string inputDate = Console.ReadLine();
    if (inputDate.ToLower() == "exit") {
        break;
    }
    DateTime result;
    if (DateTime.TryParse(inputDate, out result)) {
        string reverseDate = ReverseDateFormats(inputDate);
        Console.WriteLine("Reversed Date: {0}", reverseDate); // {0} is a placeholder for the first argument after the string
    }
    else {
        Console.WriteLine("Invalid Date");
    }
} while (true);
