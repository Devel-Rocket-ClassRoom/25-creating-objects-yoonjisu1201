using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public string Name;
    public int Price;
    public int Stock;

 

    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}개 재고 추가. 현재 재고: {Stock}개");
    }

    public void Sell(int quantity)
    {
        if (quantity > Stock)
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock}개)");
        }
        else
        {
            Stock -= quantity;
            Console.WriteLine($"{Name} {quantity}개 판매 완료. 남은 재고: {Stock}개");
        }
    }

    public int GetTotalValue()
    {
        return Stock * Price;
    }

    public override string ToString()
    {
       return $"[{Name}] {Price}원 (재고: {Stock}개)";
    }
}


