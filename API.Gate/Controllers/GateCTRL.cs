using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using API.Interface;
using BLL.Interface;


namespace API.CTRL
{
    [Route("APIGate/GateCTRL")]
    [ApiController]
    public class GateCTRL : Controller
    {
        private IRequisicao _Requisicao { get; set; }
        private IVirtudeBLL _VirtudeBLL { get; set; }
        public GateCTRL(IRequisicao requisicao, IVirtudeBLL virtudeBLL)
        {
            _Requisicao = requisicao;
            _VirtudeBLL = virtudeBLL;
        }

        [HttpGet("Virtude")]
        public async Task<bool> Virtude(string nome)
        {
            return _Requisicao.ExecutarRequisicao<string, bool>(nome, _VirtudeBLL.ExecutarByPass).Result;
        }
    }
}