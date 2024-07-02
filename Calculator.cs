using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculatbleAccount account)
        {
            account.Calculate();
        }
    }
}
