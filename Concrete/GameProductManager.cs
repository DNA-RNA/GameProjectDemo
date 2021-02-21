using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameProductManager : IGameProductService
    {
        public void Add(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.GameType + "türündeki" + gameProduct.GameName + "isimli oyun eklendi");
        }

        public void Delete(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.GameType + "türündeki" + gameProduct.GameName + "isimli oyun silindi!");
        }

        public void Update(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.GameType + "türündeki" + gameProduct.GameName + "isimli oyun güncellendi");
        }
    }
}
