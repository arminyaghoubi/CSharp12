using CollectionExpressions;

List<Book> bookList1 = [
    new("The Little Prince", "9798621081355", "Antoine de Saint-Exupéry", 6.89M)
];

List<Book> bookList2 = [
    new("Harry Potter and the Prisoner of Azkaban", "1338815288", "MINALIMA", 25M)
];

List<Book> bookList = [.. bookList1, .. bookList2];

foreach (Book book in bookList)
{
    Console.WriteLine(book);
    Console.WriteLine("-----------------------");
}