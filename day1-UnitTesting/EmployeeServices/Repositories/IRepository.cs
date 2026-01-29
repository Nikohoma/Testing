namespace EmployeeServices.Repositories
{
    public interface IEmployeeServiceRepository
    {

        int GetId(int id);
        string GetName(string name);

    }
}