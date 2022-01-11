using System;

namespace PadraoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator fabricaCarro = new CarroCreator();
            Creator fabricaMoto = new MotoCreator();

            Carro meuCarro = (Carro)fabricaCarro.criarVeiculo();
            Moto minhaMoto = (Moto)fabricaMoto.criarVeiculo();

            meuCarro.getTipo();
            minhaMoto.getTipo();

        }
    }
}
