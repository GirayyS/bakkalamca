﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bakkalamca.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BakkalDbEntities : DbContext
    {
        public BakkalDbEntities()
            : base("name=BakkalDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<kategori_log_ins_del> kategori_log_ins_del { get; set; }
        public virtual DbSet<kategori_log_up> kategori_log_up { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<kullanici_log_ins_del> kullanici_log_ins_del { get; set; }
        public virtual DbSet<kullanici_log_up> kullanici_log_up { get; set; }
        public virtual DbSet<marka> marka { get; set; }
        public virtual DbSet<marka_log_ins_del> marka_log_ins_del { get; set; }
        public virtual DbSet<marka_log_up> marka_log_up { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_log_ins_del> rol_log_ins_del { get; set; }
        public virtual DbSet<rol_log_up> rol_log_up { get; set; }
        public virtual DbSet<satis> satis { get; set; }
        public virtual DbSet<satis_log_ins_del> satis_log_ins_del { get; set; }
        public virtual DbSet<satis_log_up> satis_log_up { get; set; }
        public virtual DbSet<satis_maddeleri> satis_maddeleri { get; set; }
        public virtual DbSet<smaddeleri_log_ins_del> smaddeleri_log_ins_del { get; set; }
        public virtual DbSet<smaddeleri_log_up> smaddeleri_log_up { get; set; }
        public virtual DbSet<stok> stok { get; set; }
        public virtual DbSet<stok_log_ins_del> stok_log_ins_del { get; set; }
        public virtual DbSet<stok_log_up> stok_log_up { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<urun> urun { get; set; }
        public virtual DbSet<urun_log_ins_del> urun_log_ins_del { get; set; }
        public virtual DbSet<urun_log_up> urun_log_up { get; set; }
    
        public virtual ObjectResult<Fatura_Result> Fatura(Nullable<int> satis_id)
        {
            var satis_idParameter = satis_id.HasValue ?
                new ObjectParameter("satis_id", satis_id) :
                new ObjectParameter("satis_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Fatura_Result>("Fatura", satis_idParameter);
        }
    
        public virtual ObjectResult<Giris_Result> Giris(string k_adi, string parola)
        {
            var k_adiParameter = k_adi != null ?
                new ObjectParameter("k_adi", k_adi) :
                new ObjectParameter("k_adi", typeof(string));
    
            var parolaParameter = parola != null ?
                new ObjectParameter("parola", parola) :
                new ObjectParameter("parola", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Giris_Result>("Giris", k_adiParameter, parolaParameter);
        }
    
        public virtual int KategoriEkle(string k_adi)
        {
            var k_adiParameter = k_adi != null ?
                new ObjectParameter("k_adi", k_adi) :
                new ObjectParameter("k_adi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KategoriEkle", k_adiParameter);
        }
    
        public virtual ObjectResult<KategoriGetir_Result> KategoriGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KategoriGetir_Result>("KategoriGetir");
        }
    
        public virtual ObjectResult<KategoriGetirSecili_Result> KategoriGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KategoriGetirSecili_Result>("KategoriGetirSecili", idParameter);
        }
    
        public virtual int KategoriGuncelle(Nullable<int> id, string ad)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KategoriGuncelle", idParameter, adParameter);
        }
    
        public virtual int KategoriSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KategoriSil", idParameter);
        }
    
        public virtual int KullaniciEkle(string k_adi, string parola, string ad, string soyad, string eposta, string telefon, Nullable<bool> durum, Nullable<int> rol_id)
        {
            var k_adiParameter = k_adi != null ?
                new ObjectParameter("k_adi", k_adi) :
                new ObjectParameter("k_adi", typeof(string));
    
            var parolaParameter = parola != null ?
                new ObjectParameter("parola", parola) :
                new ObjectParameter("parola", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("soyad", soyad) :
                new ObjectParameter("soyad", typeof(string));
    
            var epostaParameter = eposta != null ?
                new ObjectParameter("eposta", eposta) :
                new ObjectParameter("eposta", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("telefon", telefon) :
                new ObjectParameter("telefon", typeof(string));
    
            var durumParameter = durum.HasValue ?
                new ObjectParameter("durum", durum) :
                new ObjectParameter("durum", typeof(bool));
    
            var rol_idParameter = rol_id.HasValue ?
                new ObjectParameter("rol_id", rol_id) :
                new ObjectParameter("rol_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KullaniciEkle", k_adiParameter, parolaParameter, adParameter, soyadParameter, epostaParameter, telefonParameter, durumParameter, rol_idParameter);
        }
    
        public virtual ObjectResult<KullaniciGetir_Result> KullaniciGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KullaniciGetir_Result>("KullaniciGetir");
        }
    
        public virtual ObjectResult<KullaniciGetirSecili_Result> KullaniciGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KullaniciGetirSecili_Result>("KullaniciGetirSecili", idParameter);
        }
    
        public virtual int KullaniciGuncelle(Nullable<int> k_id, string k_adi, string parola, string ad, string soyad, string eposta, string telefon, Nullable<bool> durum, Nullable<int> rol_id)
        {
            var k_idParameter = k_id.HasValue ?
                new ObjectParameter("k_id", k_id) :
                new ObjectParameter("k_id", typeof(int));
    
            var k_adiParameter = k_adi != null ?
                new ObjectParameter("k_adi", k_adi) :
                new ObjectParameter("k_adi", typeof(string));
    
            var parolaParameter = parola != null ?
                new ObjectParameter("parola", parola) :
                new ObjectParameter("parola", typeof(string));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            var soyadParameter = soyad != null ?
                new ObjectParameter("soyad", soyad) :
                new ObjectParameter("soyad", typeof(string));
    
            var epostaParameter = eposta != null ?
                new ObjectParameter("eposta", eposta) :
                new ObjectParameter("eposta", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("telefon", telefon) :
                new ObjectParameter("telefon", typeof(string));
    
            var durumParameter = durum.HasValue ?
                new ObjectParameter("durum", durum) :
                new ObjectParameter("durum", typeof(bool));
    
            var rol_idParameter = rol_id.HasValue ?
                new ObjectParameter("rol_id", rol_id) :
                new ObjectParameter("rol_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KullaniciGuncelle", k_idParameter, k_adiParameter, parolaParameter, adParameter, soyadParameter, epostaParameter, telefonParameter, durumParameter, rol_idParameter);
        }
    
        public virtual int KullaniciSil(Nullable<int> k_id)
        {
            var k_idParameter = k_id.HasValue ?
                new ObjectParameter("k_id", k_id) :
                new ObjectParameter("k_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KullaniciSil", k_idParameter);
        }
    
        public virtual int MarkaEkle(string m_adi)
        {
            var m_adiParameter = m_adi != null ?
                new ObjectParameter("m_adi", m_adi) :
                new ObjectParameter("m_adi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MarkaEkle", m_adiParameter);
        }
    
        public virtual ObjectResult<MarkaGetir_Result> MarkaGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MarkaGetir_Result>("MarkaGetir");
        }
    
        public virtual ObjectResult<MarkaGetirSecili_Result> MarkaGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MarkaGetirSecili_Result>("MarkaGetirSecili", idParameter);
        }
    
        public virtual int MarkaGuncelle(Nullable<int> id, string ad)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MarkaGuncelle", idParameter, adParameter);
        }
    
        public virtual int MarkaSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MarkaSil", idParameter);
        }
    
        public virtual int RolEkle(string r_adi)
        {
            var r_adiParameter = r_adi != null ?
                new ObjectParameter("r_adi", r_adi) :
                new ObjectParameter("r_adi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolEkle", r_adiParameter);
        }
    
        public virtual ObjectResult<RolGetir_Result> RolGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetir_Result>("RolGetir");
        }
    
        public virtual ObjectResult<RolGetirSecili_Result> RolGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetirSecili_Result>("RolGetirSecili", idParameter);
        }
    
        public virtual int RolGuncelle(Nullable<int> id, string ad)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adParameter = ad != null ?
                new ObjectParameter("ad", ad) :
                new ObjectParameter("ad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolGuncelle", idParameter, adParameter);
        }
    
        public virtual int RolSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RolSil", idParameter);
        }
    
        public virtual int SatisEkle(Nullable<System.DateTime> s_tarih, string s_durum, Nullable<int> k_id)
        {
            var s_tarihParameter = s_tarih.HasValue ?
                new ObjectParameter("s_tarih", s_tarih) :
                new ObjectParameter("s_tarih", typeof(System.DateTime));
    
            var s_durumParameter = s_durum != null ?
                new ObjectParameter("s_durum", s_durum) :
                new ObjectParameter("s_durum", typeof(string));
    
            var k_idParameter = k_id.HasValue ?
                new ObjectParameter("k_id", k_id) :
                new ObjectParameter("k_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SatisEkle", s_tarihParameter, s_durumParameter, k_idParameter);
        }
    
        public virtual ObjectResult<SatisGetir_Result> SatisGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SatisGetir_Result>("SatisGetir");
        }
    
        public virtual ObjectResult<SatisGetirSecili_Result> SatisGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SatisGetirSecili_Result>("SatisGetirSecili", idParameter);
        }
    
        public virtual int SatisGuncelle(Nullable<int> id, Nullable<System.DateTime> tarih, string durum, Nullable<int> k_id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("tarih", tarih) :
                new ObjectParameter("tarih", typeof(System.DateTime));
    
            var durumParameter = durum != null ?
                new ObjectParameter("durum", durum) :
                new ObjectParameter("durum", typeof(string));
    
            var k_idParameter = k_id.HasValue ?
                new ObjectParameter("k_id", k_id) :
                new ObjectParameter("k_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SatisGuncelle", idParameter, tarihParameter, durumParameter, k_idParameter);
        }
    
        public virtual int SatisSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SatisSil", idParameter);
        }
    
        public virtual int SMEkle(Nullable<double> miktar, Nullable<double> fiyat, Nullable<double> iskonto, Nullable<int> satis_id, Nullable<int> urun_id)
        {
            var miktarParameter = miktar.HasValue ?
                new ObjectParameter("miktar", miktar) :
                new ObjectParameter("miktar", typeof(double));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(double));
    
            var iskontoParameter = iskonto.HasValue ?
                new ObjectParameter("iskonto", iskonto) :
                new ObjectParameter("iskonto", typeof(double));
    
            var satis_idParameter = satis_id.HasValue ?
                new ObjectParameter("satis_id", satis_id) :
                new ObjectParameter("satis_id", typeof(int));
    
            var urun_idParameter = urun_id.HasValue ?
                new ObjectParameter("urun_id", urun_id) :
                new ObjectParameter("urun_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SMEkle", miktarParameter, fiyatParameter, iskontoParameter, satis_idParameter, urun_idParameter);
        }
    
        public virtual ObjectResult<SMGetir_Result> SMGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SMGetir_Result>("SMGetir");
        }
    
        public virtual ObjectResult<SMGetirSecili_Result> SMGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SMGetirSecili_Result>("SMGetirSecili", idParameter);
        }
    
        public virtual int SMGuncelle(Nullable<int> sm_id, Nullable<double> miktar, Nullable<double> fiyat, Nullable<double> iskonto, Nullable<int> satis_id, Nullable<int> urun_id)
        {
            var sm_idParameter = sm_id.HasValue ?
                new ObjectParameter("sm_id", sm_id) :
                new ObjectParameter("sm_id", typeof(int));
    
            var miktarParameter = miktar.HasValue ?
                new ObjectParameter("miktar", miktar) :
                new ObjectParameter("miktar", typeof(double));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(double));
    
            var iskontoParameter = iskonto.HasValue ?
                new ObjectParameter("iskonto", iskonto) :
                new ObjectParameter("iskonto", typeof(double));
    
            var satis_idParameter = satis_id.HasValue ?
                new ObjectParameter("satis_id", satis_id) :
                new ObjectParameter("satis_id", typeof(int));
    
            var urun_idParameter = urun_id.HasValue ?
                new ObjectParameter("urun_id", urun_id) :
                new ObjectParameter("urun_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SMGuncelle", sm_idParameter, miktarParameter, fiyatParameter, iskontoParameter, satis_idParameter, urun_idParameter);
        }
    
        public virtual int SMSil(Nullable<int> sm_id)
        {
            var sm_idParameter = sm_id.HasValue ?
                new ObjectParameter("sm_id", sm_id) :
                new ObjectParameter("sm_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SMSil", sm_idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int StokEkle(Nullable<int> id, Nullable<int> adet, Nullable<System.DateTime> giris, Nullable<System.DateTime> bitis)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adetParameter = adet.HasValue ?
                new ObjectParameter("adet", adet) :
                new ObjectParameter("adet", typeof(int));
    
            var girisParameter = giris.HasValue ?
                new ObjectParameter("giris", giris) :
                new ObjectParameter("giris", typeof(System.DateTime));
    
            var bitisParameter = bitis.HasValue ?
                new ObjectParameter("bitis", bitis) :
                new ObjectParameter("bitis", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StokEkle", idParameter, adetParameter, girisParameter, bitisParameter);
        }
    
        public virtual ObjectResult<StokGetir_Result> StokGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StokGetir_Result>("StokGetir");
        }
    
        public virtual ObjectResult<StokGetirSecili_Result> StokGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StokGetirSecili_Result>("StokGetirSecili", idParameter);
        }
    
        public virtual int StokGuncelle(Nullable<int> id, Nullable<int> adet, Nullable<System.DateTime> giris, Nullable<System.DateTime> bitis)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var adetParameter = adet.HasValue ?
                new ObjectParameter("adet", adet) :
                new ObjectParameter("adet", typeof(int));
    
            var girisParameter = giris.HasValue ?
                new ObjectParameter("giris", giris) :
                new ObjectParameter("giris", typeof(System.DateTime));
    
            var bitisParameter = bitis.HasValue ?
                new ObjectParameter("bitis", bitis) :
                new ObjectParameter("bitis", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StokGuncelle", idParameter, adetParameter, girisParameter, bitisParameter);
        }
    
        public virtual int StokSil(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StokSil", idParameter);
        }
    
        public virtual int UrunEkle(string adi, string barkod, Nullable<System.DateTime> uretim, Nullable<System.DateTime> tuketim, Nullable<double> fiyat, Nullable<double> agirlik, string renk, Nullable<int> marka_id, Nullable<int> kategori_id, Nullable<int> stok_id)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("adi", adi) :
                new ObjectParameter("adi", typeof(string));
    
            var barkodParameter = barkod != null ?
                new ObjectParameter("barkod", barkod) :
                new ObjectParameter("barkod", typeof(string));
    
            var uretimParameter = uretim.HasValue ?
                new ObjectParameter("uretim", uretim) :
                new ObjectParameter("uretim", typeof(System.DateTime));
    
            var tuketimParameter = tuketim.HasValue ?
                new ObjectParameter("tuketim", tuketim) :
                new ObjectParameter("tuketim", typeof(System.DateTime));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(double));
    
            var agirlikParameter = agirlik.HasValue ?
                new ObjectParameter("agirlik", agirlik) :
                new ObjectParameter("agirlik", typeof(double));
    
            var renkParameter = renk != null ?
                new ObjectParameter("renk", renk) :
                new ObjectParameter("renk", typeof(string));
    
            var marka_idParameter = marka_id.HasValue ?
                new ObjectParameter("marka_id", marka_id) :
                new ObjectParameter("marka_id", typeof(int));
    
            var kategori_idParameter = kategori_id.HasValue ?
                new ObjectParameter("kategori_id", kategori_id) :
                new ObjectParameter("kategori_id", typeof(int));
    
            var stok_idParameter = stok_id.HasValue ?
                new ObjectParameter("stok_id", stok_id) :
                new ObjectParameter("stok_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UrunEkle", adiParameter, barkodParameter, uretimParameter, tuketimParameter, fiyatParameter, agirlikParameter, renkParameter, marka_idParameter, kategori_idParameter, stok_idParameter);
        }
    
        public virtual ObjectResult<UrunGetir_Result> UrunGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UrunGetir_Result>("UrunGetir");
        }
    
        public virtual ObjectResult<UrunGetirSecili_Result> UrunGetirSecili(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UrunGetirSecili_Result>("UrunGetirSecili", idParameter);
        }
    
        public virtual int UrunGuncelle(Nullable<int> urun_id, string adi, string barkod, Nullable<System.DateTime> uretim, Nullable<System.DateTime> tuketim, Nullable<double> fiyat, Nullable<double> agirlik, string renk, Nullable<int> marka_id, Nullable<int> kategori_id, Nullable<int> stok_id)
        {
            var urun_idParameter = urun_id.HasValue ?
                new ObjectParameter("urun_id", urun_id) :
                new ObjectParameter("urun_id", typeof(int));
    
            var adiParameter = adi != null ?
                new ObjectParameter("adi", adi) :
                new ObjectParameter("adi", typeof(string));
    
            var barkodParameter = barkod != null ?
                new ObjectParameter("barkod", barkod) :
                new ObjectParameter("barkod", typeof(string));
    
            var uretimParameter = uretim.HasValue ?
                new ObjectParameter("uretim", uretim) :
                new ObjectParameter("uretim", typeof(System.DateTime));
    
            var tuketimParameter = tuketim.HasValue ?
                new ObjectParameter("tuketim", tuketim) :
                new ObjectParameter("tuketim", typeof(System.DateTime));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("fiyat", fiyat) :
                new ObjectParameter("fiyat", typeof(double));
    
            var agirlikParameter = agirlik.HasValue ?
                new ObjectParameter("agirlik", agirlik) :
                new ObjectParameter("agirlik", typeof(double));
    
            var renkParameter = renk != null ?
                new ObjectParameter("renk", renk) :
                new ObjectParameter("renk", typeof(string));
    
            var marka_idParameter = marka_id.HasValue ?
                new ObjectParameter("marka_id", marka_id) :
                new ObjectParameter("marka_id", typeof(int));
    
            var kategori_idParameter = kategori_id.HasValue ?
                new ObjectParameter("kategori_id", kategori_id) :
                new ObjectParameter("kategori_id", typeof(int));
    
            var stok_idParameter = stok_id.HasValue ?
                new ObjectParameter("stok_id", stok_id) :
                new ObjectParameter("stok_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UrunGuncelle", urun_idParameter, adiParameter, barkodParameter, uretimParameter, tuketimParameter, fiyatParameter, agirlikParameter, renkParameter, marka_idParameter, kategori_idParameter, stok_idParameter);
        }
    
        public virtual int UrunSil(Nullable<int> urun_id)
        {
            var urun_idParameter = urun_id.HasValue ?
                new ObjectParameter("urun_id", urun_id) :
                new ObjectParameter("urun_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UrunSil", urun_idParameter);
        }
    }
}
