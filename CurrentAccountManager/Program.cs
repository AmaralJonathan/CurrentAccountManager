using System;
using CurrentAccountManager.Accounts;
using CurrentAccountManager.Titular;

namespace ConsoleApp
{

    class program { 
        static void Main(String[] args) {

            // Initializing Classes
            Client client= new Client();
            CurrentAccount Jonathan = new CurrentAccount();
            CurrentAccount Alynne = new CurrentAccount();
            
             
            // Criando novo cliente (Jonathan)
            client.setName("Jonathan");
            client.setCpf("23132231");
            client.setProfissao("Dev c#");

            Jonathan.titular = client;
            Jonathan.agency_number = 14;
            Jonathan.account = "1090-x";
            
            Jonathan.setSaldo(200);

            // Criando nova cliente (Alynne)
            client.setName("Alynne");
            client.setCpf("23132231");
            client.setProfissao("Professora");

            Alynne.titular = client;
            Alynne.agency_number = 424;
            Alynne.account = "7590-y";

            Alynne.setSaldo(400);

            // Saldos
            Console.WriteLine("Saldo de Alynne: " + Alynne.getSaldo());
            Console.WriteLine("Saldo de Jonathan: " + Jonathan.getSaldo());

            //Depositos
            
            Jonathan.Deposit(500);
            Alynne.Deposit(500);
            
            // Saldos
            Console.WriteLine("Saldo de Alynne: " + Alynne.getSaldo());
            Console.WriteLine("Saldo de Jonathan: " + Jonathan.getSaldo());

            //Descontando das contas
            Console.WriteLine("Descontando R$250");
            Jonathan.withdraw(250);
            Alynne.withdraw(250);

            // Saldos
            Console.WriteLine("Saldo de Alynne: " + Alynne.getSaldo());
            Console.WriteLine("Saldo de Jonathan: " + Jonathan.getSaldo());

            //Transferindo $$ das contas
            Console.WriteLine("Transferindo 100 dê Jonathan para Alynne");
            Jonathan.Transfer(100, Alynne);

            // Saldos
            Console.WriteLine("Saldo de Alynne: " + Alynne.getSaldo());
            Console.WriteLine("Saldo de Jonathan: " + Jonathan.getSaldo());
        }
    }
 }





