using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WCFService_2Way_082;
using System.Text;
using System.Threading.Tasks;

namespace ServerChatApp_082_DeniseNW
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(ServiceCallback));
                hostObjek.Open();

                Console.WriteLine("Server on, ready to use ok");
                Console.ReadLine();

                hostObjek.Close();
            }
            catch (Exception e)
            {
                hostObjek = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
