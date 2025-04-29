using UnityEditor;
using UnityEngine;


public class personagem  : MonoBehaviour
{
    
    [SerializeField]
    public string Nome;
    [SerializeField]
    public int Energia;
    [SerializeField]
    public int forca_ataque;
    [SerializeField]
    public int forca_do_pulo;
    [SerializeField]
    public int velocidade;
    [SerializeField]
    public int numero_de_pes;
    [SerializeField]
    private int numero_de_maos;

    
    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }

    public string getNome()
    {
        return this.Nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.Energia = energia;
    }

    public void AtribuirForca_Ataque(int ataque)
    {
        this.forca_ataque = ataque;
    }

    public void AtribuirForca_Do_pulo(int pulo)
    {
        this.forca_do_pulo = pulo;
    }

    public float NForca_do_pulo()
    {
        return this.forca_do_pulo;
    }

    public void AtribuirVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    public void AtribuirNumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }

    public int Numero_de_pes()
    {
        return this.numero_de_pes;
    }

    public void AtribuirNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }

    public int Numero_de_maos()
    {
        return this.Numero_de_maos();
    }
    
    
}