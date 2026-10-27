    public abstract class AbstractBook : Readable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // Реализация метода Read из интерфейса Readable
        public virtual void Read()
        {
            Console.WriteLine($"Книга '{Title}' автора {Author} в данный момент читается.");
        }
    }