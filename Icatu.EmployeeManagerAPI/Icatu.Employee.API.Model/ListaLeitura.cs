using System.Collections.Generic;
using System.Linq;

namespace Icatu.ListaLeitura.Modelos
{
    public static class TipoListaLeituraExtensions
    {
        private static Dictionary<string, TipoListaLeitura> mapa =
            new Dictionary<string, TipoListaLeitura>
            {
                { "TI", TipoListaLeitura.TI },
                { "Depto. de Marketing", TipoListaLeitura.Marketing },
                { "Depto. de Vendas", TipoListaLeitura.Vendas }
            };

        public static string ParaString(this TipoListaLeitura tipo)
        {
            return mapa.First(s => s.Value == tipo).Key;
        }

        public static TipoListaLeitura ParaTipo(this string texto)
        {
            return mapa.First(t => t.Key == texto).Value;
        }
    }

    public enum TipoListaLeitura
    {
        TI,
        Marketing,
        Vendas
    }

    public class ListaLeitura
    {
        public string Tipo { get; set; }
        public IEnumerable<FuncionarioApi> Funcionario { get; set; }
    }
}
