using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    interface IKontoller
    {
        bool TcVarMı();
        bool TcSifreKontrol();
        bool TcKullanımı();
        bool SifreUyusuyorMu();
        bool MailUygunMu();

    }
}
