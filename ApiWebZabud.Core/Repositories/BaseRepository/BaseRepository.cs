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



        //#region IDisposable Support
        //private bool disposedValue = false; // To detect redundant calls

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            // TODO: dispose managed state (managed objects).
        //        }

        //        // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        //        // TODO: set large fields to null.

        //        disposedValue = true;
        //    }
        //}

        //// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        //// ~BaseRepository() {
        ////   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        ////   Dispose(false);
        //// }

        //// This code added to correctly implement the disposable pattern.
        //public void Dispose()
        //{
        //    // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //    Dispose(true);
        //    // TODO: uncomment the following line if the finalizer is overridden above.
        //    // GC.SuppressFinalize(this);
        //}
        //#endregion


        //public sealed class Singleton
        //{
        //    private readonly static Singleton _instance = new Singleton();

        //    private Singleton()
        //    {
        //    }

        //    public static Singleton Instance
        //    {
        //        get
        //        {
        //            return _instance;
        //        }
        //    }
        //}

    }
}
