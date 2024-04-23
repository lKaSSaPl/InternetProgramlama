using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;

namespace İlan_Sitesi.Models
{
    public class İlan
    {
        public int İlanId { get; set; }
        public string İlanNo {  get; set; }
        public string Açıklama { get; set; }
        public double Fiyat {  get; set; }
        public string Tarih{ get; set; }
        public int Kilometre { get; set; }
        public int ModelYılı {  get; set; }
        public string YakıtTürü {  get; set; }
        public string VitesTürü { get; set; }
        public string Username {  get; set; }
        public string Telefon {  get; set; }
        public int DurumId { get; set; }
        public Durum Durum {  get; set; }
        public int MarkaId {  get; set; }
        public int ModelId {  get; set; }
        public Model Model { get; set; }
        public int ŞehirId { get; set; }
        public Şehir Şehir { get; set; }
        public List<Resim> Resims{ get; set;}
    }
}