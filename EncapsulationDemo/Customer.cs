using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Customer
    {
        // fields (alanlar)
        string _adSoyad;
        public string AdSoyad
        {
            get
            {
                if (ErkekMi)
                    return "Bay " + _adSoyad;
                // else olmasa daha iyi olur return bulduğu an çıkıyor zaten.metoddan çıkıyor.
                return "Bayan " + _adSoyad;
            }
            set
            {
                _adSoyad = value; //value senin set ettiğin değer demek
            }
        }

        //public void SetAdSoyad(string AdSoyad) //property kullanmak daha mantıklı
        //{
        //    _AdSoyad = AdSoyad;
        //}

        //public string GetAdSoyad()
        //{
        //    return _AdSoyad;
        //}
        public bool ErkekMi { get; set; } //property  //yukarıdaki metod oluşturma ile aynı işlev





        string _kartNo;  //özelleştirmeden dolayı

        public string KartNo
        {
            //1234 5678 9012 3456
            get
            {
                return "**** **** **** " + _kartNo.Substring(15);
            }
            set
            {
                _kartNo = value;
            }
        }
    }
}
