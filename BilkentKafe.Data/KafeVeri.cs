using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilkentKafe.Data
{
    public class KafeVeri
    {
        public KafeVeri()
        {
            Urunler = new List<Urun>();
            AKtifSiparisler = new List<Siparis>();
            GecmişSiparisler = new List<Siparis>();
        }
        public List<Urun> Urunler { get; set; }

        public List<Siparis> AKtifSiparisler { get; set; }
        public List<Siparis> GecmişSiparisler { get; set; }

        public bool MAsaDoluMu(int masaNo)
        {
            return AKtifSiparisler.Any(x => x.MasaNo == masaNo);

        }
        public Siparis SiparisBul(int masaNo)
        {
            return AKtifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);// bulursan ilkini döndür.

        }
        public void MasayiKapat(int masaNo, SiparisDurum durum)
        {
            Siparis siparis = new Siparis(masaNo);
            siparis.Durum = durum;
            siparis.KapanisZamani = DateTime.Now;
            AKtifSiparisler.Remove(siparis);
            GecmişSiparisler.Add(siparis);

            if (durum==SiparisDurum.Odendi)
            {
                siparis.OdenenTutar = siparis.ToplamTutar();
            }
        }

    }
}
