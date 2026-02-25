using System;
using System.Xml.Linq;

// README.md를 읽고 아래에 코드를 작성하세요.
int sum = 0;
Product[] product = new Product[3] {
    new Product {Name = "노트북", Price = 1500000, Stock = 5 },
    new Product {Name =  "마우스",Price = 35000, Stock = 20 },
    new Product { Name = "키보드", Price = 89000, Stock = 15 }
};


foreach (var item in product)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 거래 ===");
product[0].Sell(2);
product[1].Sell(5);
product[2].Sell(20);
product[2].AddStock(10);
Console.WriteLine();
Console.WriteLine("=== 최종 상품 목록 ===");
foreach (var item in product)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("=== 총 재고 가치 ===");
product[0].GetTotalValue();
product[1].GetTotalValue();
product[2].GetTotalValue();
Console.Write($"--- \n전체 재고 총 가치: ");

foreach (var item in product)
{
    sum += item.Stock * item.Price;
}
Console.WriteLine(sum);
