using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Api.Supermercado.Service
{
    public class SupermercadoControlerDTO
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public DateTime dataatualizacao { get; set; }
        public int idusuario { get; set; }
    }
}