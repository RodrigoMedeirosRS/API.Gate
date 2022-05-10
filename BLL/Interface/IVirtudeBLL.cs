using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IVirtudeBLL
    {
        Task<bool> ExecutarByPass(string valor);
    }
}