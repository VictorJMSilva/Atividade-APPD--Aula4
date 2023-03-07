using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_APPD__Aula4
{
    public class Funcionario
    {
        public string CPF { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public float ValorHora { get; set; } 
        public float Horas { get; set; }
        public float Salario { get; private set; }

        public void CalcularSalario()
        {
            // Salario =  (VAlorhora * Horas) * 30;
            Salario = ValorHora * Horas;
        }
    }
}
