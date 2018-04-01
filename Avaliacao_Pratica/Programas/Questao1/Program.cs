using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;

/*
 *  Questão 1
 *  Faça um programa que liste na console todos os pedidos de venda (SalesOrder) de todos os usuários (User). 
 * 
 * Output esperado
 * User 1
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User 2
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User N
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * 
 * Onde "User N" pode ser substituído pelo campo Name da tabela User e SalesOrderNumber, TotalValue, ItensCount os campos da tabela SalesOrder.
 * 
 * O mais importante é conseguirmos analisar a maneira que você codifica, não tem problema se não for possível terminar tudo.
 *
 */

using Questao1.Business;
using Questao1.Business.Impl;
using Questao1.Models;
using Microsoft.Data.Sqlite;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseBusiness databaseBusiness = BusinessFactory.GetInstance().CreateBusiness<DatabaseBusiness>();
            databaseBusiness.CreateDatabase();
            IUserBusiness userBusiness = BusinessFactory.GetInstance().CreateBusiness<UserBusiness>();
            var users = userBusiness.GetUsersWithSalesOrder();
            Console.WriteLine("Questão 1 - Listagem de pedidos de vendas de todos os usuários: ");
            foreach(var user in users) {
                Console.WriteLine(user);    
            }
            Console.ReadKey();

        }
    }
}
