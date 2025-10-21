# 🌍 Traversal Project

Traversal Project, **.NET 6 MVC + Web API** tabanlı, **katmanlı mimari (Layered Architecture)** yapısına sahip, **seyahat ve tur rezervasyon** yönetim sistemidir.  
Proje, kullanıcıların destinasyonları görüntüleyip turlar hakkında bilgi edinmesini, admin paneli üzerinden ise içeriklerin yönetilmesini sağlar.

---

## 🧩 Proje Mimarisi

Proje, **N Katmanlı Mimari** yapısına sahiptir:
```markdown
📁 TraversalProject
├── Core
│ ├── Entities
│ ├── Interfaces
│ └── DTOs
├── DataAccess
│ ├── Context
│ ├── Repositories
│ └── UnitOfWork
├── Business
│ ├── Services
│ ├── Managers
│ └── Validations
├── WebUI
│ ├── Controllers
│ ├── Views
│ └── Areas (Admin, Member)
└── WebAPI
```
Bu yapı, **SOLID prensipleri** ve **Clean Architecture** yaklaşımıyla inşa edilmiştir.  
Katmanlar birbirinden gevşek bağlıdır ve her biri yalnızca bir sorumluluğa sahiptir.

---

## ⚙️ Kullanılan Teknolojiler

| Katman | Teknolojiler / Kütüphaneler |
|--------|------------------------------|
| Core | Entity, DTO, Interface yapıları |
| DataAccess | Entity Framework Core, LINQ, MSSQL |
| Business | FluentValidation, Dependency Injection, AutoMapper |
| WebUI | ASP.NET Core MVC, Identity, Areas (Admin/Member), ViewComponent, PartialView |
| WebAPI | ASP.NET Core Web API, RESTful yapı |
| Genel | N-Tier Architecture, Repository Pattern, Unit of Work Pattern, SOLID |

---

## 🧱 Mimari Detaylar

- **Entity Framework Core**: Veritabanı işlemleri için kullanılır.  
- **Repository Pattern**: Veri erişimini soyutlayarak yeniden kullanılabilir hale getirir.  
- **Unit of Work**: Transaction yönetimini kolaylaştırır.  
- **AutoMapper**: Entity-DTO dönüşümlerinde kullanılır.  
- **FluentValidation**: Form verilerini sunucu tarafında doğrular.  
- **Identity**: Kullanıcı kayıt, login, roller ve yetkilendirme süreçleri için entegre edilmiştir.  
- **Areas**: `Admin` ve `Member` bölümleri MVC tarafında ayrı yönetim alanları sunar.  
- **WebAPI**: Dış servislerin veri çekebileceği REST API uç noktaları sağlar.  

---

## 🧭 Proje Katmanları

### 🔹 Core Layer
Temel yapı taşlarını barındırır:  
- `Entities` → Veritabanı tablolarının modelleri  
- `Interfaces` → Soyut servis tanımları  
- `DTOs` → Veri transfer nesneleri

### 🔹 DataAccess Layer
Veri tabanı işlemlerinin gerçekleştirildiği katmandır.  
- `Context` → DbContext sınıfı  
- `Repositories` → Generic Repository yapısı  
- `UnitOfWork` → Tüm repository işlemlerini yönetir

### 🔹 Business Layer
Uygulama mantığının işlendiği katmandır.  
- `Services` → Interface implementasyonları  
- `Managers` → Servislerin iş kuralları  
- `Validations` → FluentValidation kuralları

### 🔹 WebUI Layer
Kullanıcı arayüzü katmanıdır.  
- MVC yapısı (Controller, View, ViewModel)  
- `Areas`:  
  - **Admin Area** → Panel, dashboard, içerik yönetimi  
  - **Member Area** → Kullanıcı profili, rezervasyon işlemleri  

### 🔹 WebAPI Layer
Dış dünyaya veri sağlayan RESTful API’dir.  
- `Controllers`: API endpoint’leri  
- `DTOs`: Veri transfer nesneleri  
- `Program.cs`: WebAPI başlangıç dosyası

---

## 🧩 Öne Çıkan Özellikler

✅ Katmanlı mimari ve SOLID prensipleri  
✅ Repository + Unit of Work yapısı  
✅ FluentValidation ile model doğrulama  
✅ ASP.NET Identity ile kimlik yönetimi  
✅ Admin & Member alanları  
✅ RESTful Web API  
✅ ViewComponent, PartialView ve Layout mimarisi  
✅ MSSQL destekli veri tabanı  
✅ AutoMapper ile Entity–DTO dönüşümü  

---
## 🖼️ Screenshots

### Web Site - Home Page
![Home Page](https://github.com/user-attachments/assets/39c11dad-c880-479d-9af2-e02ece7b88e6)
![](https://github.com/user-attachments/assets/c8635749-b15d-4480-a334-1781bf3b344f)
![](https://github.com/user-attachments/assets/f188759b-f082-4f2a-90c0-60639ea473fa)


### WebUI - Admin Panel
![Admin Dashboard](https://github.com/user-attachments/assets/f161cc23-493f-4c3f-ac53-1d0d15abe852)
![](https://github.com/user-attachments/assets/a2aa29da-a2f2-4f81-8e9e-3fe0d0fc8141)
![](https://github.com/user-attachments/assets/5b8b1cd8-e0bc-457e-988b-c441bde2a132)
![](https://github.com/user-attachments/assets/3231312c-a5d5-4fac-92fb-ea3b5904ba1f)


### WebUI - User Panel
![User Dashboard](https://github.com/user-attachments/assets/e7bde8dd-e0dd-4144-814e-96c43341bbbd)
![](https://github.com/user-attachments/assets/153d2f7a-5c0f-4eba-972f-4c3cef27635a)



