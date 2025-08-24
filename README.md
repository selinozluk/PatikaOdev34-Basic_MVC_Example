# PatikaOdev34 - Basic MVC Example

Bu proje, **ASP.NET Core MVC** ile hazırlanmış basit bir örnektir. 
Amaç: **Customer** ve **Order** verilerini **CustomerOrderViewModel** üzerinden view’da göstermek.

## Proje Yapısı
- **Controllers** → `CustomerOrdersController.cs`
- **Models** → `Customer.cs`, `Order.cs`, `ViewModels/CustomerOrderViewModel.cs`
- **Views** → `Views/CustomerOrders/Index.cshtml`
- **Program.cs** → MVC servisleri ve varsayılan rota

## Çalıştırma
```bash
dotnet run --project ./Basic_MVC_Example.csproj
