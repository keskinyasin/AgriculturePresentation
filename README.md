# 🌾 Agriculture Presentation

Modern ve ölçeklenebilir tarım yönetim sistemi. N-Katmanlı mimariye dayalı profesyonel bir .NET uygulamasıdır.

## 📋 İçindekiler

- [Proje Hakkında](#proje-hakkında)
- [Teknolojiler](#teknolojiler)
- [Proje Yapısı](#proje-yapısı)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Katkıda Bulunma](#katkıda-bulunma)

## 🎯 Proje Hakkında

Agriculture Presentation, tarım işletmelerinin yönetimi ve veri analitiğini sağlamak amacıyla geliştirilmiş bir web uygulamasıdır. 

### Temel Özellikler

- ✅ Katmanlı mimari (Entity, Business, Data Access)
- ✅ Veritabanı operasyonları
- ✅ İş mantığı yönetimi
- ✅ Kolay genişletilme yapısı

## 🛠️ Teknolojiler

| Teknoloji | Versiyon | Kullanım |
|-----------|---------|---------|
| **.NET** | 8.0+ | Framework |
| **C#** | Modern | Programlama Dili |
| **Visual Studio** | 2022+ | IDE |
| **SQL Server** | - | Veritabanı |

## 📁 Proje Yapısı

```
AgriculturePresentation/
├── AgriculturePresentation/        # Sunum Katmanı (Presentation Layer)
│   └── AgriculturePresentation.csproj
├── EntityLayer/                    # Varlık Katmanı (Entity Models)
│   └── EntityLayer.csproj
├── BussinessLayer/                 # İş Mantığı Katmanı (Business Logic)
│   └── BussinessLayer.csproj
├── DataAccessLayer/                # Veri Erişim Katmanı (Data Access)
│   └── DataAccessLayer.csproj
└── AgriculturePresentation.sln     # Solution Dosyası
```

### Katmanların Açıklaması

#### 🎨 **Presentation Layer** (Sunum Katmanı)
- Kullanıcı arayüzü
- Veri gösterimi
- Kullanıcı etkileşimleri

#### 🏗️ **Business Layer** (İş Mantığı Katmanı)
- Uygulamanın iş kuralları
- Veri işleme
- Doğrulama ve kontrol

#### 💾 **Data Access Layer** (Veri Erişim Katmanı)
- Veritabanı işlemleri
- CRUD operasyonları
- Sorgu yönetimi

#### 📦 **Entity Layer** (Varlık Katmanı)
- Veri modelleri
- Sınıf tanımları
- Entity nesneleri

## 🚀 Kurulum

### Ön Koşullar
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) veya üzeri
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) veya Visual Studio Code
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (SQL Server Express yeterli)

### Adımlar

1. **Repoyu Klonlayın**
```bash
git clone https://github.com/keskinyasin/AgriculturePresentation.git
cd AgriculturePresentation
```

2. **Dependency'leri Yükleyin**
```bash
dotnet restore
```

3. **Projeyi Açın**
```bash
# Visual Studio ile
start AgriculturePresentation.sln

# veya CLI ile
dotnet build
```

4. **Veritabanını Oluşturun**
```bash
# Veritabanı migration'larını çalıştırın
dotnet ef database update
```

5. **Uygulamayı Çalıştırın**
```bash
cd AgriculturePresentation
dotnet run
```

Uygulama `http://localhost:5000` adresinde çalışacaktır.

## 💻 Kullanım

### Temel Komutlar

**Build İşlemi:**
```bash
dotnet build
```

**Projeyi Çalıştırma:**
```bash
dotnet run
```

**Testleri Çalıştırma:**
```bash
dotnet test
```

**Release Build:**
```bash
dotnet build --configuration Release
```

### Geliştirme Workflow

1. Yeni bir branch oluşturun
```bash
git checkout -b feature/yeni-ozellik
```

2. Değişiklikleri yapın ve commit edin
```bash
git add .
git commit -m "Yeni özellik: Açıklama"
```

3. Push yapın
```bash
git push origin feature/yeni-ozellik
```

4. Pull Request oluşturun

## 📚 API Uç Noktaları

API kullandığınız takdirde, temel uç noktalar burada dokumente edilecektir.

## 🐛 Hata Bildirimi

Hata bulduğunuz takdirde, lütfen [Issues](https://github.com/keskinyasin/AgriculturePresentation/issues) bölümünde bir issue açınız.

## 🤝 Katkıda Bulunma

Katkılarınız hoş geldiniz! Lütfen bu adımları izleyin:

1. Projeyi fork edin
2. Özellik branchi oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişiklikleri commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Brancha push yapın (`git push origin feature/AmazingFeature`)
5. Pull Request açın

## 📄 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakınız.

## 👤 Yazar

**Keşkin Yasin**
- GitHub: [@keskinyasin](https://github.com/keskinyasin)
- Repository: [AgriculturePresentation](https://github.com/keskinyasin/AgriculturePresentation)

## 📞 İletişim

Sorularınız için:
- Issues bölümüne yazabilirsiniz
- GitHub üzerinden mesaj gönderebilirsiniz

---

⭐ Projeyi beğendiyseniz lütfen star verin!
