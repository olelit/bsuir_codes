﻿using CodeHollow.FeedReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rssHabr = FeedReader.ReadAsync("https://habr.com/ru/rss/all/all/");
            rssHabr.ConfigureAwait(false);
            var rssInterfax = FeedReader.ReadAsync("https://www.interfax.by/news/feed");
            rssInterfax.ConfigureAwait(false);

            rssList rssList = new rssList();
            rssList.fillByRss(rssHabr.Result.Items, "Habr.com");
            rssList.fillByRss(rssInterfax.Result.Items, "Interfax.by");

            using (DataContext db = new DataContext(@"data source=(localdb)\MSSQLLocalDB;AttachDbFilename=D:\projects\СПП\Ковалевич\881062_Ковалевич_9\TestDB.mdf;initial catalog=TestDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"))
            {
                string result = "";
                ConsoleColor color = ConsoleColor.White;
                foreach (rss item in rssList.GetList())
                {
                    IQueryable<rss> existingRow = from row in db.GetTable<rss>()
                                                  where ((row.date == item.date) && (row.title == item.title))
                                                  select row;
                    if(existingRow.Count() == 0)
                    {
                        db.GetTable<rss>().InsertOnSubmit(item);
                        db.SubmitChanges();
                        color = ConsoleColor.Green;
                        result = " добавлен";
                    }
                    else
                    {
                        existingRow.First().views++;
                        db.SubmitChanges();
                        color = ConsoleColor.DarkRed;
                        result = " уже существует";
                    }
                    Console.Write($"{item.source} : {item.title} : {item.date}");
                    Console.ForegroundColor = color;
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                IEnumerable<ViewsAndSaves> ViewsAndSavesList = (from grouped in db.GetTable<rss>()
                                                                group grouped by grouped.source into newGrouped
                                                                select new ViewsAndSaves
                                                                {
                                                                    Source = newGrouped.Key,
                                                                    CountViews = newGrouped.Sum(item => item.views),
                                                                    CountSaves = newGrouped.Count()
                                                                }).ToList();
                foreach (ViewsAndSaves item in ViewsAndSavesList)
                {
                    Console.WriteLine($"\n{item.Source}\nПрочитано: {item.CountViews}\nСохранено: {item.CountSaves}");
                }
            }
            Console.ReadKey();
        }
    }
}
