using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication10.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var sehirler = new List<Sehir>()
            {
                new Sehir(){SehirAd="İSTANBUL"},
                new Sehir(){SehirAd="ANKARA"},
                new Sehir(){SehirAd="İZMİR"}
            };
            foreach (var item in sehirler)
            {
                context.Sehirs.Add(item);
            }
            context.SaveChanges();
            var durum = new List<Durum>()
            {
                new Durum(){DurumAd="KIRALIK"},
                           new Durum(){DurumAd="SATILIK"}
            };
            foreach (var item in durum)
            {
                context.Durums.Add(item);
            }
            context.SaveChanges();
            var marka = new List<Marka>()
            {
                new Marka() { MarkaAd="BMW"},
                new Marka() { MarkaAd="MERCEDES"},
                new Marka() { MarkaAd="AUDİ"}
            };
            foreach (var item in marka)
            {
                context.Markas.Add(item);
            }
            context.SaveChanges();
            var model = new List<Model>()
            {
                new Model() {ModelAd="520",MarkaId=1},
                new Model() {ModelAd="A180",MarkaId=2},
                new Model() {ModelAd="Q7",MarkaId=3},
                new Model() {ModelAd="X5",MarkaId=1}

             };
            foreach (var item in model)
            {
                context.Models.Add(item);
            }
            context.SaveChanges();
            var ilan = new List<İlan>()
            {
                new İlan(){MarkaId=1,Aciklama="Araba Temiz",IlanNo="A125",Fiyat=2500,Tarhi="24/02/2024",Kilometre=10000,ModelYili="2015",YakitTuru="Benzin",VitesTuru="Düz",DurumId=1,ModelId=1,Username="Enes Tepe",SehirId=1,Telefon="05426357844"},
                new İlan(){MarkaId=3,Aciklama="Araba Temiz Kazasız",IlanNo="A150",Fiyat=2500,Tarhi="22/02/2024",Kilometre=5000,ModelYili="2020",YakitTuru="LPG",VitesTuru="Düz",DurumId=2,ModelId=4,Username="AliCan",SehirId=2,Telefon="05426357844"}
            };
            foreach (var item in ilan)
            {
                context.İlans.Add(item);
            }
            context.SaveChanges();
            var resim = new List<Resim>()
            {
                new Resim(){ResimAd="a1.jpg",IlanId=1},
                                new Resim(){ResimAd="a2.jpg",IlanId=1},
                                                new Resim(){ResimAd="a3.jpg",IlanId=2}
            };
            foreach (var item in resim)
            {
                context.Resims.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}