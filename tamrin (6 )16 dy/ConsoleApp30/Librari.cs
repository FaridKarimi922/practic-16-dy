using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_6_16_dy
{
    public static class Librari
    {
        private static List<Category> _categoris = new List<Category>();
        private static List<Book> _book = new List<Book>();
        private static List<User> users = new();

        public static void addCategori(string name, int capacity)
        {
            Category category = new Category(name, capacity);
            _categoris.Add(category);
        }
        public static List<Category> GetCategories()
        {
            return _categoris;
        }
        public static void AddBook(string name, int type, int count, int price)
        {

            if (type == 1)
            {
                SaleBook saleBook = new SaleBook(name);
                saleBook.AddPrice(price);
                saleBook.AddCount(count);

                _book.Add(saleBook);

            }
            if (type == 2)
            {

                RentBook rentBook = new RentBook(name);
                rentBook.AddPrice(price);
                rentBook.AddCount(count);
                _book.Add(rentBook);
            }

        }
        public static void AddBookToCategory(string bookName, string categoryName, int number)
        {
            var book = _book.Find(_ => _.Name == bookName);
            if (book == null)
            {
                throw new Exception("book nist");
            }

            var category = _categoris.Find(_ => _.Name == categoryName);
            if (category == null)
            {
                throw new Exception("categori nist");
            }
            var iteam = category.Iteam.FirstOrDefault(_ => _.Number == number);
            if (iteam == null)
            {
                throw new Exception("number not found");
            }
            if (iteam.book is not null)
            {
                throw new Exception("error");
            }
            iteam.book = book;
        }
        public static void AddUser(string name)
        {
            User user =new User(name);
            users.Add(user);

        }
        public static void DeleteBook(string bookName, string categoryName)
        {
            var book = _book.Find(_ => _.Name == bookName)!;
            var category = _categoris.Find(_ => _.Name == categoryName)!;
            
            _categoris.Remove(category);
            _book.Remove(book);
        }
    }
}
