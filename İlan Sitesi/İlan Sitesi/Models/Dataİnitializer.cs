using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace İlan_Sitesi.Models
{
    public class Dataİnitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var şehirler = new List<Şehir>() {
            new Şehir() {ŞehirAd="İstanbul"},
            new Şehir() {ŞehirAd="Ankara"},
            new Şehir() {ŞehirAd="Kayseri"},
            new Şehir() {ŞehirAd="Malatya"},
            };
            foreach (var item in şehirler)
            {
                context.Şehirs.Add(item);
            }
            context.SaveChanges();
            var durum = new List<Durum>()
            {
                new Durum() {DurumAd="Kiralık"},
                new Durum() {DurumAd="Satılık"},
            };
            foreach (var item in durum)
            {
                context.Durums.Add(item);
            }
            context.SaveChanges();
            var marka = new List<Marka>
            {
                new Marka() {MarkaAd="Seat"},
                new Marka() {MarkaAd="MERCEDES"},
                new Marka() {MarkaAd="AUDİ"},
            };
            foreach (var item in marka)
            {
                context.Markas.Add(item);
            }
            context.SaveChanges();
            var model = new List<Model>
            {
                new Model() {ModelAd="LEON",MarkaId=1},
                new Model() {ModelAd="A180",MarkaId=2},
                new Model() {ModelAd="Q7",MarkaId=3},
                new Model() {ModelAd="X5",MarkaId=1},

            };
            foreach (var item in model)
            {
                context.Models.Add(item);
            }
            context.SaveChanges();

            var ilan = new List<İlan>
            {
                new İlan() {MarkaId=1, Açıklama="Araba Temiz",İlanId=1, İlanNo="A125",Fiyat=1225000,Tarih="24/02/2021",Kilometre=18000,ModelYılı=2023,YakıtTürü="Benzin",VitesTürü="Otomatik",DurumId=1,Username="kassap",ŞehirId=1,Telefon="05426357844"},
                new İlan() {MarkaId=3, Açıklama="Doktordan", İlanId=2,İlanNo="A126",Fiyat=56000,Tarih="24/02/2021",Kilometre=32500,ModelYılı=2007,YakıtTürü="Dizel",VitesTürü="Otomatik",DurumId=2,Username="bakkal",ŞehirId=2,Telefon="05426357845"}
               };
            foreach (var item in ilan)
            {
                context.İlans.Add(item);
            }
            context.SaveChanges();

            var resim = new List<Resim>()
            {
                new Resim(){ResimAd="araç7.jpeg",İlanId=1},
                new Resim(){ResimAd="araç4.jpeg",İlanId=1},
                new Resim(){ResimAd="a3.jpg",İlanId=2},
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