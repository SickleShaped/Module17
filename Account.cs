using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public interface ICalculatbleAccount
    {
        void Calculate();

        //Подскажите, пожалуйста, как тут избежать повторения кода (поля Type, Balance и Interest?), сделать ли абстрактный класс, содержащий эти поля, унаследованный от интрефеса с методом, или как?
    }

    public class DefaultAccount:ICalculatbleAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void Calculate()
        {
                Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }

    public class BusinessAccount:ICalculatbleAccount
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void Calculate()
        {
            Interest = Balance * 0.5;
        }

    }
}
