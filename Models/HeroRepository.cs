using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class HeroRepository: IHeroRepository
    {
        private readonly AppDbContext _appDbContext;

        public HeroRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /*
         Dessa två metoder ser oskyldig ut men som du vet sker entityframework-magi här

          GetAllPies kommer göra en SELECT till databasen

          GetPieById kommer göra en SELECT ... WHERE ...
        */
        public IEnumerable<Hero> GetAllPies()
        {
            return _appDbContext.Heroes;
        }

        public Hero GetPieById(int pieId)
        {
            return _appDbContext.Heroes.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
