using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciarBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario f) 
        {
            _totalBonificacao += f.GetBonificacao();
        }

        public double GetTotalBonificacao() 
        {
            return _totalBonificacao;
        }
    }
} 