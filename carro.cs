public class Carro : Veiculo, IAceleravel, IFreavel
{
    public Carro(string marca, string modelo):base(marca, modelo)
    {
        
    }

    public override void Ligar()
    {
        Console.WriteLine($"O veículo da {Marca} e modelo {Modelo} está ligando!");
    }

    public void Acelerar(){
        Console.WriteLine($"O veículo da {Marca} e modelo {Modelo} está acelerando!");
    }

    public  void Frear()
    {
        Console.WriteLine($"O veículo da {Marca} e modelo {Modelo} está freando!");
    }
}