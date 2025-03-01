namespace Course.Entities
{
    class OutSourcedEmployee : Employee
    {
        public Double AdditionalCharge { get; set; }

        public OutSourcedEmployee() 
        { 
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additional)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additional;            
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
