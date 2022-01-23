using aquarium_calculator.Interface;
using aquarium_calculator.Model;
using Microsoft.AspNetCore.Mvc;

namespace aquarium_calculator.Controllers
{

     [Route("[controller]") ] 
    public class AquariumCalculatorController :ControllerBase
    {
        private readonly ICalculoLitragemService _calculoLitragemService;

        public AquariumCalculatorController( ICalculoLitragemService calculoLitragemService)
        {
            _calculoLitragemService = calculoLitragemService;
        }
        [HttpPost]
         public async Task<ActionResult<dynamic>> calculo(CalculoLitragemRequestModel calculoLitragemRequestModel){

             return _calculoLitragemService.calc(calculoLitragemRequestModel);
         }

    }
}