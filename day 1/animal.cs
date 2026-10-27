 public abstract class Animal
    {
        public string Name { get; set; }=null!;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }