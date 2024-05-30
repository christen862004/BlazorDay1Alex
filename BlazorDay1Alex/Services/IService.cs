namespace BlazorDay1Alex.Services
{
    //DIP Abstraction |interface 
    public interface IService<T>
    {
        T GetByID(int id);
        List<T> GetAll();

    }
}
