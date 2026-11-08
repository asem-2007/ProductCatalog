# ProductCatalog

2-апта тапсырмасы: Razor, Strongly Typed View, ViewBag, Layout және Partial View.

## Іске қосу
```
dotnet run
```
Браузерде консольдағы мекенжайды ашыңыз (мысалы, http://localhost:5000).

## Құрылымы
- Models/Product.cs — Id, Name, Price, Category, IsAvailable
- Controllers/ProductController.cs — тізім және толық ақпарат
- Views/Shared/_Layout.cshtml — Bootstrap негізіндегі ортақ каркас
- Views/Shared/_ProductCard.cshtml — тауар картасы (Partial View)
- Views/Product/Index.cshtml — @model IEnumerable<Product>, `<partial>` арқылы карталар
