using System;

public class Cyborg
{
    public string Nome;
    public int Energia;
    public int forca_ataque;
    public int forca_do_pulo;
    public int Velocidade;
    public bool numero_de_pes;
    public string numero_de_mao;

    public Cyborg(string nome, int energia, int forca_ataque, int forca_do_pulo, int velocidade, bool lnumero_de_pes, string numero_de_mao)
    {
        Nome = nome;
        Energia = energia;
        forca_ataque = forca_ataque;
        forca_do_pulo = forca_do_pulo;
        Velocidade = velocidade;
        numero_de_pes = numero_de_pes;
        numero_de_mao = numero_de_mao;
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"=== CYBORG: {Nome} ===");
        Console.WriteLine($"Modelo: {numero_de_mao}");
        Console.WriteLine($"Energia: {Energia}");
        Console.WriteLine($"forca_ataque: {forca_ataque}");
        Console.WriteLine($"forca_do_pulo: {forca_do_pulo}");
        Console.WriteLine($"Velocidade: {Velocidade}");
        Console.WriteLine($"numero_de_pes: {(numero_de_pes ? "SIM" : "NÃO")}");
    }

    public void Atacar()
    {
        Console.WriteLine($"{Nome} dispara um raio laser com poder {forca_ataque}!");
    }

    public void Defender()
    {
        Console.WriteLine($"{Nome} ativa escudo de defesa cibernética ({forca_do_pulo})!");
    }

    public void Voar()
    {
        if (numero_de_pes)
            Console.WriteLine($"{Nome} decola com seu jetpack!");
        else
            Console.WriteLine($"{Nome} não possui jetpack.");
    }
}