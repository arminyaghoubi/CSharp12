namespace RefReadonlyParameters;

internal class Book(string Title, string ISBN, string AuthorName, decimal Price)
{
    public void UpdatePrice(ref readonly decimal newPrice)
    {
        Price = newPrice;
        //newPrice += 10; //You could not change value because newPrice is readonly.
        Console.WriteLine($"newPrice Changed to {newPrice}.");
    }

    public decimal GetPriceValue() => Price;

    public override string ToString()
    {
        return $"Title: {Title}\nISBN: {ISBN}\nAuthor: {AuthorName}\nPrice: {Price}";
    }
}
