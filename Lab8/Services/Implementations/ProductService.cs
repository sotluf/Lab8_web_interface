using Lab8.Models;

namespace Lab8.Services.Implementations;

internal class ProductService() :
    ModelService<Product>([
        new Product { Id = Guid.NewGuid(), Name = "Product A", Price = 10.5m, Stock = 100 },
        new Product { Id = Guid.NewGuid(), Name = "Product B", Price = 15.0m, Stock = 200 },
        new Product { Id = Guid.NewGuid(), Name = "Product C", Price = 20.0m, Stock = 300 },
        new Product { Id = Guid.NewGuid(), Name = "Product D", Price = 25.5m, Stock = 400 },
        new Product { Id = Guid.NewGuid(), Name = "Product E", Price = 30.0m, Stock = 500 },
        new Product { Id = Guid.NewGuid(), Name = "Product F", Price = 35.5m, Stock = 600 },
        new Product { Id = Guid.NewGuid(), Name = "Product G", Price = 40.0m, Stock = 700 },
        new Product { Id = Guid.NewGuid(), Name = "Product H", Price = 45.5m, Stock = 800 },
        new Product { Id = Guid.NewGuid(), Name = "Product I", Price = 50.0m, Stock = 900 },
        new Product { Id = Guid.NewGuid(), Name = "Product J", Price = 55.5m, Stock = 1000 },
        new Product { Id = Guid.NewGuid(), Name = "Product K", Price = 60.0m, Stock = 1100 },
        new Product { Id = Guid.NewGuid(), Name = "Product L", Price = 65.5m, Stock = 1200 },
        new Product { Id = Guid.NewGuid(), Name = "Product M", Price = 70.0m, Stock = 1300 },
        new Product { Id = Guid.NewGuid(), Name = "Product N", Price = 75.5m, Stock = 1400 },
        new Product { Id = Guid.NewGuid(), Name = "Product O", Price = 80.0m, Stock = 1500 }
    ]),
    IProductService;
