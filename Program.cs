// See https://aka.ms/new-console-template for more information
using Service;

AccountService accS = new AccountServiceImpl();
accS.AddNewAccount(1, "MAD", 5000);
accS.AddNewAccount(2, "MAD", -500);


List<Account> listAccounts = accS.GetAllAccounts();
foreach (Account acc in listAccounts)
{
    Console.WriteLine(acc);
}
Console.WriteLine("---------Debit Account-------------");
List<Account> DebitedAccounts = accS.GetDebitedAccounts();
foreach (Account acc in DebitedAccounts)
{
    Console.WriteLine(acc);
}
Console.WriteLine("----------------------------------------");
Console.WriteLine(accS.GetBalanceAVG());