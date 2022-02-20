﻿namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return 
                $"Id...........: {Id}\n" +
                $"FirstName....: {FirstName}\n" +
                $"LastName.....: {LastName}\n" +
                $"BirthDate....: {BirthDate}\n" +
                $"HiringDate...: {HiringDate}\n" +
                $"Is Active....: {IsActive}";
        }

    }
}
