using System.IO;
using Microsoft.AspNetCore.Http;

namespace Icatu.ListaLeitura.Modelos
{
    public static class LivrosExtensions
    {
        public static byte[] ConvertToBytes(this IFormFile image)
        {
            if (image == null)
            {
                return null;
            }
            using (var inputStream = image.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                inputStream.CopyTo(stream);
                return stream.ToArray();
            }
        }

        public static Funcionario ToFuncionario(this FuncUpload model)
        {
            return new Funcionario
            {
                Id = model.Id,
                Nome = model.Nome,
                Email = model.Email,
                Departamento = model.Departamento,
                Funcao = model.Funcao,
                ImagemCapa = model.Capa.ConvertToBytes(),
                Lista = model.Lista
            };
        }

        public static FuncApi ToApi(this Funcionario funcionario)
        {
            return new FuncApi
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Email = funcionario.Email,
                Departamento = funcionario.Departamento,
                Funcao = funcionario.Funcao,
                Capa = $"/api/fotos/{funcionario.Id}",
                Lista = funcionario.Lista.ParaString()
                
            };
        }

        public static FuncionarioApi To_Api(this Funcionario funcionario)
        {
            return new FuncionarioApi
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Email = funcionario.Email,
                Departamento = funcionario.Departamento,
                Funcao = funcionario.Funcao,
                ImagemCapa = $"/api/funcionarios/{funcionario.Id}/capa",
                Lista = funcionario.Lista.ParaString()

            };
        }


        public static FuncUpload ToModel(this Funcionario funcionario)
        {
            return new FuncUpload
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Email = funcionario.Email,
                Departamento = funcionario.Departamento,
                Funcao = funcionario.Funcao,
                Lista = funcionario.Lista
            };
        }
    }
}
