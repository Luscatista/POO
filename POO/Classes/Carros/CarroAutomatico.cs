using POO.Interfaces;

namespace POO.Classes.Carros;

class CarroAutomatico : ICarro
{
    public void TrocarMarcha()
    {
        Console.WriteLine("Trocando a marcha!"); 
    }
}
