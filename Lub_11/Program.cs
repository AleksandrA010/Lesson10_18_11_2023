using System;
using System.Collections;
using BankAccountsLibrary.Accounts;
using BankAccountsLibrary.FactoriesAccounts;
using BuildLibrary.FactoriesBuilds;
using BuildLibrary.Builds;

namespace Lub_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtableAccounts = new Hashtable();

            CurrentAccountFactory currentAccountFactory = new CurrentAccountFactory();
            SavingAccountFactory savingAccountFactory = new SavingAccountFactory();

            IAccount currentAccount1 = currentAccountFactory.GetAccount("Joo Peton");
            IAccount savingAccount1 = savingAccountFactory.GetAccount("Peter Gorden");

            hashtableAccounts.Add(currentAccount1.AccountNumber, currentAccount1);
            hashtableAccounts.Add(savingAccount1.AccountNumber, savingAccount1);

            foreach (DictionaryEntry ele1 in hashtableAccounts)
            {
                Console.WriteLine("Номер счёта: {0}\nОбъект {1}\n", ele1.Key, ele1.Value.GetType().Name);
            }

            Console.Write("\nДля закрытия приложения нажмите на любую кнопку: ");
            Console.ReadKey();

            Hashtable hashtableBuildings = new Hashtable();

            Four_storeyBuildingFactory four_storeyBuildingFactory = new Four_storeyBuildingFactory();
            Three_storeyBuildingFactory three_storeyBuildingFactory = new Three_storeyBuildingFactory();

            IBuild four_storeyBuild1 = four_storeyBuildingFactory.GetBuild(3);
            IBuild three_storeyBuild1 = three_storeyBuildingFactory.GetBuild(4);

            hashtableBuildings.Add(four_storeyBuild1.NumberBuild, four_storeyBuild1);
            hashtableBuildings.Add(three_storeyBuild1.NumberBuild, three_storeyBuild1);

            Console.WriteLine("\n");
            foreach (DictionaryEntry ele1 in hashtableBuildings)
            {
                Console.WriteLine("Номер дома: {0}\nОбъект: {1}\n", ele1.Key, ele1.Value.GetType().Name);
            }

            Console.Write("\nДля закрытия приложения нажмите на любую кнопку: ");
            Console.ReadKey();
        }
    }
}
