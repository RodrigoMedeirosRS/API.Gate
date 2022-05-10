using System.Threading.Tasks;

using DAL.Interface;
using BLL.Interface;

namespace BLL
{
    public class VirtudeBLL : IVirtudeBLL
    {
        public IVirtudeDAL VirtudeDAL { get; set; }
        public VirtudeBLL(IVirtudeDAL virtudeDAL)
        {
            VirtudeDAL = virtudeDAL;
        }
        public async Task<bool> ExecutarByPass(string valor)
        {
            var url = VirtudeDAL.ObterURL(valor);
            return true;
        }
    }
}