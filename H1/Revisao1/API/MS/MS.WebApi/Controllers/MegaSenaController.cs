using Microsoft.AspNetCore.Mvc;
using MS.WebApi.ViewModel;
using Newtonsoft.Json;

namespace MS.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {
        private string _pathData = @"./Data/MegaSena.json";

        [HttpPost]
        [Route("RegistrarJogo")]
        public IActionResult RegistrarJogo(MegaSenaViewModel registro)
        {
            List<int> Verify = new List<int>();
            Verify.Add(registro.PrimeiroNro);
            Verify.Add(registro.SegundoNro);
            Verify.Add(registro.TerceiroNro);
            Verify.Add(registro.QuartoNro);
            Verify.Add(registro.QuintoNro);
            Verify.Add(registro.SextoNro);
            if (Verify.Distinct().Count() < 6)
            {
                return Ok("Digite numeros diferentes");
            }
            if (!CPFValidation(registro.CPF))
            {
                return Ok("CPF não é valido");
            }
            try
            {
                var file = System.IO.File.ReadAllText(_pathData);
                var obj = JsonConvert.DeserializeObject<IEnumerable<MegaSenaViewModel>>(file).ToList();
                registro.initJogo();
                obj.Add(registro);
                var objJson = JsonConvert.SerializeObject(obj);
                System.IO.File.WriteAllText(_pathData, objJson);
                return Ok("Jogo Registrado com Sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("ObterTodosOsJogos")]
        public IEnumerable<MegaSenaViewModel> ObterTodosOsJogos()
        {
            var file = System.IO.File.ReadAllText(_pathData);
            return JsonConvert.DeserializeObject<IList<MegaSenaViewModel>>(file);
        }

        private bool CPFValidation(string cpf)
        {
            string valor = cpf.Replace('.', new char()).Replace('-', new char());

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;
            return true;
        }

    }
}
