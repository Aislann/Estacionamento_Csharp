using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aislan_Estacionametos
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento( decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void adcionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo: ");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())) //varredura pela lista, verificar se já existe 
            {
                Console.WriteLine("Já existe um veiculo com essa placa");
            } else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso");
            }
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo: ");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Dgite a quantidade de horas que o veículo ficou no estacionamento");
                int horas = Convert.ToInt32(Console.ReadLine());    
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veiculo de placa: {placa} foi removido e deve pagar: {precoTotal}");
            } else
            {
                Console.WriteLine("O veiculo não está em nosso pátio");
            }
        }

        public void listarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são: ");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos no pátio");
            }
        }
    }
}
