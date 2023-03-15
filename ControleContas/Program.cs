
using ControleContas.Model;

Conta conta = new Conta("1234");
Conta conta2 = new Conta("4321", 1000.99m);
Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");
