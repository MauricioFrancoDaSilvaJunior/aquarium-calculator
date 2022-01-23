using aquarium_calculator.Interface;
using aquarium_calculator.Model;
using AutoMapper;

namespace aquarium_calculator.Service
{
    public class CalculoLitragemService : ICalculoLitragemService
    {
        public long calc(CalculoLitragemRequestModel calculoLitragemRequestModel)
        {  
            return (calculoLitragemRequestModel.Altura*calculoLitragemRequestModel.Comprimento*calculoLitragemRequestModel.Largura)/1000;
        }
    }
}