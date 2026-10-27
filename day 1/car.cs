public class Car : IVenicle
{
    public int Fuel{get;set;}
    public Car(){}
    public Car(int a)
    {
        Fuel=a;
    }
    public void Drive()
    {
        if (Fuel > 0)
        {
            System.Console.WriteLine("Driving");
        }
    }

    public bool Refuel(int a)
    {
       Fuel+=a;
       return true;
    }
}