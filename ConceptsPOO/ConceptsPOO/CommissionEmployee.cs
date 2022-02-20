﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; } //Ventas

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return 
                $"{base.ToString()}\n" +
                $"Commission Percentaje: {$"{CommissionPercentaje:P2}", 18}\n" +
                $"Sales................: {$"{Sales:C2}", 18}\n" +
                $"Salario..............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
