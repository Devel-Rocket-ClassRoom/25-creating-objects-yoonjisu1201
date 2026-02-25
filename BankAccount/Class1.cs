using System;
using System.Collections.Generic;
using System.Text;

class BankAccount
{
    private static int TotalAccounts;
    private string AccountNumber;
    private string OwnerName;
    private int Balance;

    public BankAccount(string number, string name, int balance)
    {
        TotalAccounts++;
        AccountNumber = number;
        OwnerName = name;
        Balance = balance;
        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설되었습니다.");
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금 완료. 잔액: {Balance}원");
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
        }
        else 
        {
            Balance -= amount;
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금 완료. 잔액: {Balance}원");
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, 잔액: {Balance}원");
    }

    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}개");
    }

}