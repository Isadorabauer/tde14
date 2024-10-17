public class Bicicleta : Veiculo, IAceleravel, IFreavel
{
    public Bicicleta(string marca, string modelo):base(marca, modelo)
    {
        
    }

    public override void Ligar()
    {
        Console.WriteLine($"A bicicleta da marca {Marca} e do modelo {Modelo} está pronto para uso!");
    }
    public void Acelerar()
    {
        Console.WriteLine($"A bicicleta da marca {Marca} e do modelo {Modelo} está pedalando mais rápido");
    }




}