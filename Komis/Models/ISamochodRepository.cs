using System.Collections.Generic;


namespace Komis.Models
{
    public interface ISamochodRepository                //interface ma być publiczny
    {                                       
        IEnumerable<Samochod> PobierzWszystkieSamochody();   //metoda która będzie zwracać wszystkie samochody
        Samochod PobierzSamochodOId(int samochodId);        //metoda ktora zwraca 1 samochod
    }
}
