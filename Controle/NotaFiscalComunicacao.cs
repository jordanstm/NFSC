using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFSC.Models;

namespace NFSC.Controle
{
   public class NotaFiscalComunicacao
    {
        public NotaFiscalComunicacao()
        {

        }
       
        public List<RegistroMestre> RegistroMestre{ get; set; }
        public List<Item> Itens { get; set; }
        public List<DadosCadastraisDestinatario> Destinatario { get; set; }
    }
}
