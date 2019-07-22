namespace SqliteDemo
{
    public interface IEmployeeProvider
    {
        Employee Get(int id);
    }
}