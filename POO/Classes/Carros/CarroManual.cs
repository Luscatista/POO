using POO.Interfaces;

namespace POO.Classes.Carros;

class CarroManual : ICarro
{
    public void TrocarMarcha()
    {
        Console.WriteLine("Trocando marcha manualmente..."); 
    }
}
