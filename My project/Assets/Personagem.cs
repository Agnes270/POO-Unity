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

public class Cyborg
{
    private string Nome;
    private int Energia;
    private int PoderLaser;
    private int DefesaCibernetica;
    private int Velocidade;
    private bool PossuiJetpack;
    private string Modelo;

    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }

    public string NomeDoCyborg()
    {
        return this.Nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.Energia = energia;
    }

    public int EnergiaDoCyborg()
    {
        return this.Energia;
    }

    public void AtribuirPoderLaser(int poderLaser)
    {
        this.PoderLaser = poderLaser;
    }

    public int PoderLaserDoCyborg()
    {
        return this.PoderLaser;
    }

    public void AtribuirDefesaCibernetica(int defesaCibernetica)
    {
        this.DefesaCibernetica = defesaCibernetica;
    }

    public int DefesaCiberneticaDoCyborg()
    {
        return this.DefesaCibernetica;
    }

    public void AtribuirVelocidade(int velocidade)
    {
        this.Velocidade = velocidade;
    }

    public int VelocidadeDoCyborg()
    {
        return this.Velocidade;
    }

    public void AtribuirPossuiJetpack(bool possuiJetpack)
    {
        this.PossuiJetpack = possuiJetpack;
    }

    public bool PossuiJetpackDoCyborg()
    {
        return this.PossuiJetpack;
    }

    public void AtribuirModelo(string modelo)
    {
        this.Modelo = modelo;
    }

    public string ModeloDoCyborg()
    {
        return this.Modelo;
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"=== STATUS DO CYBORG ===");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Energia: {Energia}");
        Console.WriteLine($"Poder Laser: {PoderLaser}");
        Console.WriteLine($"Defesa Cibernética: {DefesaCibernetica}");
        Console.WriteLine($"Velocidade: {Velocidade}");
        Console.WriteLine($"Jetpack: {(PossuiJetpack ? "SIM" : "NÃO")}");
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