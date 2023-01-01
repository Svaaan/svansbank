using TYPES;
using DATABASE;
namespace LOGIC;
public class BankService : IBankService
{ 
    IBankHandeler _ibankHandeler;
    List <BankOffice> bankOffices = new();
    public BankService (IBankHandeler ibankHandeler)
    {
        _ibankHandeler = ibankHandeler;
    }
    
    public void ShowOffice()
    {
        List<BankOffice> bankOffices = _ibankHandeler.GetOffices();
        foreach (BankOffice item in bankOffices)
        {
            System.Console.WriteLine(item.ToString());
        }

    }
}