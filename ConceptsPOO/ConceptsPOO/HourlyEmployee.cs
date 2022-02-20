namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return
                $"{base.ToString()}\n" +
                $"Horas............: {$"{Hours:N2}",18}\n" +
                $"Valor por hora...: {$"{HourValue:C2}",18}\n" +
                $"Salario..........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
