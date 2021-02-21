using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {

        MernisServiceAdapter _mernisServiceAdapter;
        public PlayerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }
        
        public void Add(Player player)
        {
            if(_mernisServiceAdapter.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " isimli oyuncu eklendi");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
           
          
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu silindi!");
        }


        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " isimli oyuncu güncellendi");
        }
    }
}
