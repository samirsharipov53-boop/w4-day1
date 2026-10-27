    public class Book : AbstractBook, Borrowable
    {
        // Реализация метода Borrow из интерфейса Borrowable
        public void Borrow()
        {
            Console.WriteLine($"Книга '{Title}' была успешно взята в аренду.");
        }

        // Реализация метода ReturnBook из интерфейса Borrowable
        public void ReturnBook()
        {
            Console.WriteLine($"Книга '{Title}' была возвращена в библиотеку.");
        }
    }
