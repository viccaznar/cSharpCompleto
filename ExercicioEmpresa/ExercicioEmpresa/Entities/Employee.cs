namespace Course.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours{ get; set; }
        public Double ValuePerHour { get; set; }
        List<Employee> list = new List<Employee>();

        public Employee() 
        { 
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual Double Payment()
        {
            return Hours * ValuePerHour;
        }

    }
}
