using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.02_OCP.Good
{
       public enum EProductType{
        Eletronics =1,
        Health=2,
        Beauty=3,
        Fashion=4
    }
    public abstract class Discount
    {
        public abstract decimal Calculate(decimal price);
        
    }
    public class EletronicsDiscount : Discount
    {
    public override decimal Calculate(decimal price)
    {
        return price * 0.05M;
    }

    }

    public class EletronicsHealty : Discount
    {
    public override decimal Calculate(decimal price)
    {
        return price * 0.06M;
    }

    }

    public class EletronicsBeauty : Discount
    {
    public override decimal Calculate(decimal price)
    {
        return price * 0.07M;
    }

    }

    public class EletronicsFashion : Discount
    {
    public override decimal Calculate(decimal price)
    {
        return price * 0.09M;
    }

    }
}