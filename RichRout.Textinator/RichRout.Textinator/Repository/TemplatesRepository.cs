using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace RichRout.Textinator.Repository
{
    class TemplatesRepository
    {
        static object locker = new object();
        SQLiteConnection database;
        public TemplatesRepository()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<TemplateItem>();
        }
        public IEnumerable<TemplateItem> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<TemplateItem>() select i).OrderBy(c=>c.Name).ToList();
            }
        }
        public TemplateItem GetItem(Guid id)
        {
            lock (locker)
            {
                return database.Table<TemplateItem>().FirstOrDefault(x => x.Id == id);
            }
        }
        public int DeleteItem(Guid id)
        {
            lock (locker)
            {
                return database.Delete<TemplateItem>(id);
            }
        }
        public int Save(TemplateItem item)
        {
            lock (locker)
            {
                return database.InsertOrReplace(item);
            }
        }
    }
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
