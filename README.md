# Virus & Antivirus Simulation 

Bu proje, Nesne Yönelimli Programlama (OOP) dersi kapsamında, basit bir virüsün çalışma mantığını ve antivirüs yazılımlarının imza tabanlı tarama süreçlerini simüle etmek amacıyla geliştirilmiştir.

## 📌 Proje Özeti
Bu yazılım, sistem dosyalarına zarar vermeyen, tamamen güvenli bir simülasyon aracıdır. Belirlenen bir hedef klasör (Masaüstü/OdevTest) içerisinde özel dijital imzalara sahip sahte dosyalar oluşturur ve bu dosyaları tarayarak sistemden temizler.

> **Not:** Bu proje bir üniversite ödevidir. Gerçek bir zararlı yazılım içermez ve sadece eğitim amaçlı geliştirilmiştir.

## 🛠 Kullanılan Teknolojiler
- **Dil:** C#
- **Platform:** .NET WinForms
- **IDE:** Visual Studio 2022

## 🏗 OOP Prensipleri ve Mimari
Proje, dersin gerekliliklerine uygun olarak aşağıdaki Nesne Yönelimli Programlama kavramlarını temel alır:

*   **Interface (Arayüz):** `IProgram` arayüzü ile hem virüs hem de antivirüs için ortak bir `Calistir` metodu tanımlanmıştır. Bu sayede kodun genişletilebilirliği artırılmıştır.
*   **Polymorphism (Çok Biçimlilik):** Virüs ve Antivirüs nesneleri, aynı `IProgram` referansı üzerinden farklı davranışlar (dosya oluşturma vs. dosya silme) sergiler.
*   **Abstraction (Soyutlama):** Kullanıcı sadece butona basar; arka plandaki karmaşık dosya okuma, yazma ve silme işlemleri sınıflar içinde soyutlanmıştır.
*   **Encapsulation (Kapsülleme):** Virüs imzası ve hedef klasör yolları gibi kritik veriler sınıf içerisinde muhafaza edilir.

## Çalıştırma Adımları

#### 1. En Son Sürümü İndirin:
- Bu sayfanın sağ tarafında bulunan **"Releases"** bölümüne gidin.
- `VirusSimülasyonu.zip` dosyasına tıklayarak indirin.

#### 2. ZIP Dosyasını Çıkartın:
- İndirdiğiniz `.zip` dosyasına sağ tıklayın.
- Windows'ta **"Tümünü Ayıkla..."** (Extract All...) seçeneğini seçin ve dosyaları istediğiniz bir klasöre çıkartın.
