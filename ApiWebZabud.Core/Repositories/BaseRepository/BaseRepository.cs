using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;

namespace ApiWebZabud.Core.Repositories.BaseRepository
{
    public class BaseRepository /*: IBaseRepository,IDisposable*/
    {
        private readonly static BaseRepository _baseRepository = new BaseRepository();
        private readonly static string chain = "Server=PC-BEIMER\\SQLEXPRESS;Database=dbmiZabud;Trusted_Connection=True";

        private BaseRepository()
        {

        }

    

        public static BaseRepository baseRepository()
        {
            return _baseRepository;
          }

        public static string GetConnection()
        {
            return chain;
        }





    }
}
