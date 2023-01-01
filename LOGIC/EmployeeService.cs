using TYPES;
using DATABASE;
namespace LOGIC;
public class EmployeeService
{
    IEmployeeHandeler _IemployeeHandeler;

    public EmployeeService (IEmployeeHandeler Iemployeehandeler)
    {
        _IemployeeHandeler = Iemployeehandeler;
    }

    public void AddEmployee(Employee employee)
    {
        _IemployeeHandeler.AddEmployee(employee);
    }
}
