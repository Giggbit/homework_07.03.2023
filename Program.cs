using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_homework_07._03._2023
{
    class Firma {
        public string name { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public string director_full_name { get; set; }
        public string adress { get; set; }
        public int employees_amount { get; set; }

        public Firma() { }
        public Firma(string name, int year, string type, string director_full_name, string adress, int employees_amount) {
            this.name = name;
            this.year = year;
            this.type = type;
            this.director_full_name = director_full_name;
            this.adress = adress;
            this.employees_amount = employees_amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firma> firmas = new List<Firma>()
            {
                new Firma("Dunder Miflin", 2001, "paper", "Mikle Scot", "Springfield", 14),
                new Firma("Microsoft", 1998, "it", "Arnold Bush", "New York", 152),
                new Firma("Crodo", 1931, "soda", "Cristian White", "Grado", 45),
                new Firma("Nike", 1992, "shoes", "Fill Nite", "Stanford", 72),
                new Firma("Food Store", 2017, "food", "Jon Killy", "London", 205),
                new Firma("Go", 2021, "marketing", "Polly Mall", "Los Angeles", 89)
            };

            #region Получить информацию обо всех фирмах
            /*var all_firmas = from firma in firmas 
                             select firma;
            foreach(var firm in all_firmas) { 
                Console.WriteLine("{0} ({1})\nType: {2}\nDirector: {3}\nPlace: {4}\nAmount: {5}\n\n", firm.name, firm.date, firm.type, firm.director_full_name, firm.adress, firm.employees_amount);
            }*/

            // Метод расширений
            /*var all_firmas = from firma in firmas
                             select firma.name;
            all_firmas = firmas.Select(f => f.name);
            foreach (var n in all_firmas) { 
                Console.WriteLine(n);
            }*/
            #endregion

            #region Получить фирмы, у которых в названии есть слово Food
            /*var search_name = from firm in firmas
                              where firm.name.Contains("Food") 
                              select firm;
            foreach(var firm in search_name) { 
                Console.WriteLine("{0}", firm.name);
            }*/
            #endregion

            #region Получить фирмы, которые работают в области маркетинга
            /*var search_type = from firma in firmas
                              where firma.type == "marketing"
                              select firma;
            foreach(var i in search_type) {
                Console.WriteLine(i.name);
            }*/
            #endregion

            #region Получить фирмы, которые работают в области маркетинга или IT
            /*var search_type = from firma in firmas
                              where firma.type == "marketing" || firma.type == "it"
                              select firma;
            foreach(var i in search_type) {
                Console.WriteLine(i.name);
            }*/
            #endregion

            #region Получить фирмы с количеством сотрудников, большем 100
            /*var amount_employees = from firma in firmas
                                   where firma.employees_amount > 100
                                   select firma;
            foreach(var i in amount_employees) {
                Console.WriteLine(i.name);
            }*/
            #endregion

            #region Получить фирмы с количеством сотрудников в диапазоне от 100 до 300
            /*var amount_employees = from firma in firmas
                                  where firma.employees_amount >= 100 && firma.employees_amount <= 300
                                  select firma;
           foreach(var i in amount_employees) {
               Console.WriteLine(i.name);
           }*/
            #endregion

            #region Получить фирмы, которые находятся в Лондоне
            /*var search_london = from firma in firmas
                                where firma.adress == "London"
                                select firma;
            foreach(var i in search_london) {
                Console.WriteLine("{0} - London", i.name);
            }*/
            #endregion

            #region Получить фирмы, у которых фамилия директора White
            /*var search_surname = from firma in firmas
                                 where firma.director_full_name.Contains("White")
                                 select firma;
            foreach (var i in search_surname) {
                Console.WriteLine(i.name);
            }*/
            #endregion

            #region Получить фирмы, которые основаны больше двух лет назад
            /*var search_firm = from firm in firmas
                              where firm.year < 2021
                              select firm;
            foreach (var i in search_firm) {
                Console.WriteLine(i.name);
            }*/
            #endregion

            #region Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White
            /*var search_director = from firma in firmas
                                  where firma.director_full_name.Contains("Black") && firma.name.Contains("White")
                                  select firma;
            foreach (var i in search_director) {
                Console.WriteLine(i.name);
            }*/
            #endregion



        }
    }
}
