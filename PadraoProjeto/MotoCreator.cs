using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoProjeto
{
    public class MotoCreator : Creator
    {
        public override Veiculo criarVeiculo()
        {
            return new Moto();
        }
    }
}
