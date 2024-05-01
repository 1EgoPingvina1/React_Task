namespace ConsoleApp2.Models
{
    public abstract class Vehicle
    {
        public int MaxSpeed { get; }
        public string Type { get; }

        protected Vehicle(int maxSpeed, string type)
        {
            MaxSpeed = maxSpeed;
            Type = type;
        }
    }
}