using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("=== 계좌 개설 ===");
BankAccount account1 = new BankAccount("1001", "홍길동", 100000);
BankAccount account2 = new BankAccount("1002", "이순신", 50000);
BankAccount.ShowTotalAccounts();
Console.WriteLine();
Console.WriteLine("=== 거래 ===");
account1.Deposit(50000);
account2.Deposit(30000);
account1.Withdraw(200000);
account1.Withdraw(100000);
Console.WriteLine();
Console.WriteLine("=== 최종 계좌 개설 ===");
account1.ShowInfo();
account2.ShowInfo();




