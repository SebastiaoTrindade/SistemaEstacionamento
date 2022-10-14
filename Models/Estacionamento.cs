using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;

        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;            
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placaAdd = Console.ReadLine();
            veiculos.Add(placaAdd);            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaRemover = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaRemover.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas de permanência do veículo:");

                int horas = 0;
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placaRemover);
                Console.WriteLine($"O veículo {placaRemover} foi removido e o valor a pagar foi de : R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, este veículo não está estacionado aqui! Confira se digitou a placa corretamente.");
            }
            
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach (string i  in veiculos)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}
