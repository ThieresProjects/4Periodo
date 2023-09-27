using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Prova.Domain.Entities;

namespace Prova.Infra.Repositories
{
    public class PapaiNoelRepository
    {
        private string _caminho = @"./Data/PapaiNoel.json";
        public IEnumerable<PapaiNoel> GetCartinhas()
        {
            string json = System.IO.File.ReadAllText(_caminho);
            var result = JsonConvert.DeserializeObject<IEnumerable<PapaiNoel>>(json);
            return result;
        }
        public ValidationResult CreateCartinha(PapaiNoel cartinha)
        {
            try
            {
                string json = System.IO.File.ReadAllText(_caminho);
                var result = JsonConvert.DeserializeObject<IEnumerable<PapaiNoel>>(json).ToList();
                result.Add(cartinha);
                var Obj = JsonConvert.SerializeObject(result);
                System.IO.File.WriteAllText(_caminho, Obj);
                return new ValidationResult("Deu tudo certo");
            }
            catch(Exception ex)
            {
                return new ValidationResult(ex.Message);
            }
        }
    }
}
