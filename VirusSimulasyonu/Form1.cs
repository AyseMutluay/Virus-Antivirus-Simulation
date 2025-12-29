using System;
using System.IO;
using System.Windows.Forms;

namespace VirusSimulasyonu // Proje adın farklıysa burayı düzeltmeyi unutma!
{
    // KURAL: Form1 sınıfı her zaman en üstte olmalı
    public partial class Form1 : Form
    {
        string testKlasoru = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "OdevTest");

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(testKlasoru)) Directory.CreateDirectory(testKlasoru);
        }

        private void btnVirus_Click(object sender, EventArgs e)
        {
            IProgram virus = new ZararliYazilim();
            virus.Calistir(testKlasoru, lstLog);
        }

        private void btnAntivirus_Click(object sender, EventArgs e)
        {
            IProgram antivirus = new AntivirusYazilimi();
            antivirus.Calistir(testKlasoru, lstLog);
        }
    }

    // DİĞER SINIFLAR VE INTERFACE FORMUN ALTINDA OLMALI
    public interface IProgram
    {
        void Calistir(string yol, ListBox liste);
    }

    public class ZararliYazilim : IProgram
    {
        public void Calistir(string yol, ListBox liste)
        {
            liste.Items.Add("Virüs aktifleşti...");
            for (int i = 1; i <= 5; i++)
            {
                string dosyaAdi = $"tehdit_{i}.txt";
                string tamYol = Path.Combine(yol, dosyaAdi);
                File.WriteAllText(tamYol, "VİRÜS_İMZASI_X123");
                liste.Items.Add(dosyaAdi + " oluşturuldu.");
            }
        }
    }

    public class AntivirusYazilimi : IProgram
    {
        public void Calistir(string yol, ListBox liste)
        {
            liste.Items.Add("Tarama başlıyor...");
            string[] dosyalar = Directory.GetFiles(yol);
            int temizlenen = 0;
            foreach (string dosya in dosyalar)
            {
                if (File.ReadAllText(dosya).Contains("VİRÜS_İMZASI_X123"))
                {
                    File.Delete(dosya);
                    liste.Items.Add("SİLİNDİ: " + Path.GetFileName(dosya));
                    temizlenen++;
                }
            }
            liste.Items.Add($"{temizlenen} tehdit yok edildi.");
        }
    }
}