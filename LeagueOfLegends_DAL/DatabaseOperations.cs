using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LeagueOfLegends_DAL
{
    public static class DatabaseOperations
    {
        public static List<Friendship> OphalenFriendList()
        {
            using (Data_r0704742Entities entities = new Data_r0704742Entities())
            {
                var query = entities.Friendship
                    .Include(x => x.Speler)
                    .Include(x => x.Speler1);
                return query.ToList();
            }
        }

        public static List<Skin> OphalenSkins()
        {
            using (Data_r0704742Entities entities = new Data_r0704742Entities())
            {
                var query = entities.Skins;
                return query.ToList();
            }
        }

       
    }
}
