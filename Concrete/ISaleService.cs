using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    interface ISaleService
    {
        void SaleOperation(Campaign campaign,GameProduct gameProduct);
       
    }
}
