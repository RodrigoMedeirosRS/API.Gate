using System;
using System.Linq;

using DAO;
using DAL.Interface;

namespace DAL
{
    public class VirtudeDAL : IVirtudeDAL
    {
        private gateContext DataContext { get; set; }
        public VirtudeDAL(gateContext dataContext)
        {
            DataContext = dataContext;
        }
        public string ObterURL(string valor)
        {
            try
            {
                var a = (from gateurl in DataContext.Gateurls
                where
                    gateurl.Valor == valor
                select
                    gateurl.Url).FirstOrDefault();
                return a;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}