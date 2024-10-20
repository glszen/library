using library;

//For default constructor.
Library firstBook = new Library(); //Assignments were made with "New". New is used to create a new object.
firstBook.Name = "Adı Aylin";
firstBook.writername = "Ayşe";
firstBook.writersurname = "KULİN";
firstBook.pagenumber = "398";
firstBook.publishhouse = "Remzi Kitabevi";

Console.WriteLine(firstBook.name + " book named written by " + firstBook.writername + " " + firstBook.writersurname + ", page number is: " + firstBook.pagenumber + ", publish house is: " + firstBook.publishhouse + " and publish date is: " +  DateTime.Now);

Console.WriteLine("-------------------------");

//For alternative constructor.
Library secondBook = new Library("Adı Aylin","Ayşe","KULİN","398","Remzi Kitabevi");
Console.WriteLine(secondBook.name + " book named written by " + secondBook.writername + " " + secondBook.writersurname + ", page number is: " + secondBook.pagenumber + ", publish house is: " + secondBook.publishhouse + " and publish date is: " + DateTime.Now);