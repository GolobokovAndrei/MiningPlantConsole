using MiningPlantConsole.Model;
using System;

namespace MiningPlantConsole
{
    internal class Helper
    {
        private static MiningPlantEntities1 _context;

        public static MiningPlantEntities1 GetContext()
        {
            if (_context == null)
            {
                _context = new MiningPlantEntities1();
            }
            return _context;
        }

        public void CreateUser(Users user)
        {
            var context = GetContext();

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
