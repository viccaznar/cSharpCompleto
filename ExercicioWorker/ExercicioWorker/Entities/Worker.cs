using Course.Entities.Enum;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Course.Entities
{
    class Worker
    {
        //Propriedades
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }

        //Associação Classe Departament (Composiçao de Objeto = 1)
        public Departament Departament { get; set; }

        //Associação Classe HourContract (Composiçao de Objeto = *)
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Associação Classe HourContract (Composição de Objetos)
        public HourContract HourContract { get; set; }

        //Construtor padrão
        public Worker()
        {
        }

        public Worker(HourContract contract)
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;            
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament, List<HourContract> contracts)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
            Contracts = contracts;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public Double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}

