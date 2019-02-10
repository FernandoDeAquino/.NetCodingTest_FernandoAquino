using Icatu.ListaLeitura.Modelos;
using System.Collections.Generic;

namespace Icatu.ListaLeitura.WebApp.Models
{
    public class HomeViewModel
    {
        public IEnumerable<FuncApi> TI { get; set; }
        public IEnumerable<FuncApi> Marketing { get; set; }
        public IEnumerable<FuncApi> Vendas { get; set; }
    }
}
