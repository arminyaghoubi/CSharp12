using RefReadonlyParameters;

Book book = new("The Little Prince", "9798621081355", "Antoine de Saint-Exupéry", 6.89M);


decimal newPrice = 10;

book.UpdatePrice(ref newPrice);

Console.WriteLine($"newPrice {newPrice}");

Console.WriteLine($"Book Price is {book.GetPriceValue()}");