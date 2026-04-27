# 📚 Kutuphane Yönetim Sistemi (C# WinForms & ADO.NET)

## 📌 Proje Açıklaması

Bu proje, C# Windows Forms kullanılarak geliştirilmiş katmanlı mimariye sahip bir kütüphane yönetim sistemidir.

Uygulama, MSSQL veritabanı ile çalışır ve ADO.NET kullanılarak tüm veritabanı işlemleri manuel olarak yönetilmiştir.

En önemli özelliklerinden biri, uygulamanın ilk çalıştırıldığında otomatik olarak:

* Veritabanını oluşturması
* Gerekli tabloları kurması
* Sistem için başlangıç verilerini hazırlamasıdır

## 🏗️ Mimari Yapı

Proje katmanlı mimari ile geliştirilmiştir:

* **DAL (Data Access Layer)** → Veritabanı işlemleri
* **BLL (Business Logic Layer)** → İş kuralları
* **EL (Entity Layer)** → Veri modelleri
* **UI (Windows Forms)** → Kullanıcı arayüzü

## 🚀 Özellikler

* 📊 Kitap ekleme, silme, güncelleme (CRUD)
* 👤 Üye yönetimi
* 🔐 Kullanıcı ve yetki sistemi
* 📚 Kitap ödünç alma ve iade işlemleri
* 💰 Gecikme cezası hesaplama
* 🗄️ MSSQL veritabanı entegrasyonu
* ⚙️ Otomatik veritabanı ve tablo oluşturma
* 🔌 Dinamik bağlantı yönetimi

## 🛠️ Kullanılan Teknolojiler

* C#
* Windows Forms
* MSSQL
* ADO.NET
* SQL (manuel sorgular)

## ⚙️ Otomatik Kurulum Mantığı

Uygulama ilk çalıştırıldığında:

1. MSSQL bağlantısı kontrol edilir
2. Eğer `KutuphaneDB` veritabanı yoksa oluşturulur
3. Gerekli tablolar otomatik olarak oluşturulur:

   * Kitaplar
   * Uyeler
   * Kullanicilar
   * Emanetler
   * Haraketler
4. Sistem başlangıç için hazır hale getirilir

## 💻 Nasıl Çalıştırılır?

1. MSSQL Server kurulu olmalıdır
2. Projeyi klonlayın:

   ```bash
   git clone <repo-link>
   ```
3. Visual Studio ile açın
4. Bağlantı ayarlarını kontrol edin
5. Uygulamayı çalıştırın

## 💡 Öğrendiklerim

Bu proje ile:

* ADO.NET ile manuel veritabanı yönetimi
* Katmanlı mimari kullanımı
* SQL sorguları yazma ve optimize etme
* Gerçek dünya senaryoları için iş mantığı geliştirme

## 📄 Not

Bu proje eğitim ve staj sürecinde geliştirilmiştir.

## 🧠 Developer Notes
This is one of my first projects where I learned how to use ADO.NET and layered architecture.

While developing this project, I focused on understanding how database connections work and how to manage SQL queries manually.

Some parts of the project can be improved, and I plan to refactor it in the future.
