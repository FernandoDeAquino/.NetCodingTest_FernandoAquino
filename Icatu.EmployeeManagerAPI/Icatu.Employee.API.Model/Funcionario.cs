using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Icatu.ListaLeitura.Modelos
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public byte[] ImagemCapa { get; set; }
        public TipoListaLeitura Lista { get; set; }
    }

    public class FuncionarioApi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public string ImagemCapa { get; set; }
        public string Lista { get; set; }
    }

    [XmlType("Funcionario")]
    public class FuncApi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public string Capa { get; set; }
        public string Lista { get; set; }
    }

    public class FuncUpload
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Funcao { get; set; }
        public IFormFile Capa { get; set; }
        public TipoListaLeitura Lista { get; set; }

    }
}
