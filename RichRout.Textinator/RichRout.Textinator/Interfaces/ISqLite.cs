using SQLite;

namespace RichRout.Textinator.Interfaces
{
    public interface ISqLite
    {
        SQLiteConnection GetConnection();
    }
}