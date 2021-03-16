using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Server.Application.Struct
{
    public class ShopProductsApplication
    {
        public ShopProductsApplication()
        {
            CreateDefault();

        }
        public List<ApplicationShowCase> ListShowCases = new List<ApplicationShowCase>();

        private void CreateDefault()
        {

            List<ApplicationProduct> classProductsMeat = new List<ApplicationProduct>() { new ApplicationProduct("Говядина", "Мясо", 10, 44.4m), new ApplicationProduct("Свинина", "Мясо", 16, 35.7m), new ApplicationProduct("Баранина", "Мясо", 8, 55.9m), new ApplicationProduct("Курица", "Мясо", 20, 23.1m), new ApplicationProduct("Суповой набор", "Мясо", 30, 35.4m) };
            List<ApplicationProduct> classProductsCheese = new List<ApplicationProduct>() { new ApplicationProduct("Масдам", "Сыр", 3, 56.7m), new ApplicationProduct("Российский", "Сыр", 17, 34.2m), new ApplicationProduct("Пармезан", "Сыр", 23, 98.3m), new ApplicationProduct("Камамбер", "Сыр", 4, 179.4m) };
            List<ApplicationProduct> classProductsVegetables = new List<ApplicationProduct>() { new ApplicationProduct("Картошка", "Овощи", 36, 12.5m), new ApplicationProduct("Морковь", "Овощи", 7, 12.1m), new ApplicationProduct("Помидоры", "Овощи", 13, 43.5m), new ApplicationProduct("Огурцы", "Овощи", 15, 25.6m), new ApplicationProduct("Капуста", "Овощи", 14, 5.4m), new ApplicationProduct("Салат дуболистный", "Овощи", 4, 12.2m) };

            ListShowCases = new List<ApplicationShowCase>() { new ApplicationShowCase(100, "Мясная витрина", "Мясо") { ListClassProducts = classProductsMeat }, new ApplicationShowCase(100, "Сырная витрина", "Сыр") { ListClassProducts = classProductsCheese }, new ApplicationShowCase(100, "Овощная витрина", "Овощи") { ListClassProducts = classProductsVegetables } };
        }

        public List<ApplicationShowCase> GetShowCases()
        {
            return ListShowCases;
        }

    }
}
