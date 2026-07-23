using System;
class Book
{
    public int BookId, Pages; public decimal Price;
    public void Get() { Console.Write("Book ID: "); BookId = int.Parse(Console.ReadLine()!); Console.Write("Pages: "); Pages = int.Parse(Console.ReadLine()!); Console.Write("Price: "); Price = decimal.Parse(Console.ReadLine()!); }
    public void Set(int id, int pages, decimal price) { BookId = id; Pages = pages; Price = price; }
    public decimal GetPrice() => Price;
    public void Show() => Console.WriteLine($"ID: {BookId}, Pages: {Pages}, Price: {Price:C}");
}
class Program { static void Main() { Book book = new Book(); book.Set(101, 250, 399); book.Show(); } }
