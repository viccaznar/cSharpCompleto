using System;

namespace Course.Entities
{
     class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public  double TotalValue { get; private set; }

        //Relação de 1 para * precisa de uma lista instanciada na classe pai do tipo da classe filho.
        public List<Installment> Installments { get; set; }


        public Contract() 
        { 
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment) 
        { 
             Installments.Add(installment);
        }
    }
}
