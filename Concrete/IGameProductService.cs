using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    interface IGameProductService
    {
        void Add(GameProduct gameProduct);
        void Update(GameProduct gameProduct);
        void Delete(GameProduct gameProduct);
    }
}
