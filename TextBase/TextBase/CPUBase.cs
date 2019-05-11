using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBase
{
    public class CPU
    {
        public CPU() {
            Name_of_vendor = 0;
            Release_date = DateTime.Now;
            Name_of_CPU = "";
            Soket = "";
            Numbers_of_cores = 0;
            Numbers_of_threads = 0;
            Base_frequency = 0.0;
            Size_of_cacheL1 = "";
            Size_of_cacheL2 = "";
            Size_of_cacheL3 = "";
        }
        /*CPU()
            { }*/
        /// <summary>
        /// характеристики процессора
        /// </summary>
            public Vendor Name_of_vendor { get; set; }
            public DateTime Release_date { get; set; }
            public string Name_of_CPU { get; set; }
            public string Soket { get; set; }
            public int Numbers_of_cores { get; set; }
            public int Numbers_of_threads { get; set; }
            public double Base_frequency { get; set; }
            public string Size_of_cacheL1 { get; set; }
            public string Size_of_cacheL2 { get; set; }
            public string Size_of_cacheL3 { get; set; }
        }

        /// <summary>
        /// Статьи
        /// </summary>
        public class Articles
        {
            /// <summary>
            /// Заголовок статьи
            /// </summary>
            public string Headline { get; set; }

            /// <summary>
            /// Дата публикации статьи
            /// </summary>
            public DateTime Publication_date { get; set; }

            /// <summary>
            /// Тип статьи
            /// </summary>
            public Articles_Type Type_of_articles { get; set; }

            /// <summary>
            /// Прошла ли статья проверку
            /// </summary>
            public bool Articlec_check { get; set; }

            /// <summary>
            /// Текст статьи. Временная замена вместо ХМL
            /// </summary>
            public string Articlec_text { get; set; }
        }

        /// <summary>
        /// Продавец/изготавитель процессора
        /// </summary>
        public enum Vendor { AMD, Intel }

        /// <summary>
        /// Типы пользователей
        /// </summary>
        public enum UserType
        {
            /// <summary>
            /// Пользователь
            /// </summary>
            User,

            /// <summary>
            /// Админ
            /// </summary>
            Admin
        }

        /// <summary>
        /// Тип процессора
        /// </summary>
        public enum CPU_Type
        {
            /// <summary>
            /// Мобильный(ноутбук)
            /// </summary>
            Mobile,
            /// <summary>
            /// Десктопный
            /// </summary>
            Desktop,
            /// <summary>
            /// Серверный
            /// </summary>
            Server
        }

        /// <summary>
        /// Типы статей
        /// </summary>
        public enum Articles_Type
        {
            /// <summary>
            /// Новинки
            /// </summary>
            New,
            /// <summary>
            /// Старые мощные процессоры
            /// </summary>
            Old_but_powerful,
            /// <summary>
            /// Бюджетные
            /// </summary>
            Budgetary,
            /// <summary>
            /// Среднего класса
            /// </summary>
            Midddle_price,
            /// <summary>
            /// Дорогие
            /// </summary>
            Over_price,
        }
    }
