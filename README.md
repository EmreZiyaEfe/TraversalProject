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
![Admin Dashboard](path/to/admin-dashboard.png)

### WebUI - User Panel
![User Dashboard](path/to/user-dashboard.png)


