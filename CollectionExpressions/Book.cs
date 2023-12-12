namespace CollectionExpressions;

public class Book(string Title, string ISBN, string AuthorName, decimal Price)
{
    public override string ToString()
    {
        return $"Title: {Title}\nISBN: {ISBN}\nAuthor: {AuthorName}\nPrice: {Price}";
    }
}
