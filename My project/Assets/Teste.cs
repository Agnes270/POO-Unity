using Unity.VisualScripting.FullSerializer;
using UnityEngine;
public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    Caminhao caminhao = new Caminhao();

    Personagem joao = new Personagem();
    Inimigo ork = new Inimigo();
    void Start()
    {

        fusca.AtribuirNome("Fusca de Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumeroDeRodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("O " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + " ten " + fusca.NumeroDeRodas() +
                  " e custa R$" + fusca.Preco());

        
        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumeroDeRodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O " + gol.NomeDoCarro());

        if (fusca.ComparPreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());

        }

        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumeroDeRodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("caminhão do falstão");
            
            //fusca.AtribuirTipoDeCarroceria("Larga");
        
        if (fusca.ComparPreco(caminhao))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o " + caminhao.NomeDoCarro());

        }

        
        joao.AtribuirNome("João Roberto II");
        joao.AtribuirEnergia(10);
        joao.AtribuirForca_Ataque(12);
        joao.AtribuirForca_Do_pulo(6);
        joao.AtribuirVelocidade (8);
        joao.AtribuirNumero_de_pes(2);
        joao.AtribuirNumero_de_maos(2);

        ork.AtribuirNome("Ork Gob");
        ork.AtribuirEnergia (23);
        ork.AtribuirForca_Ataque (15);
        ork.AtribuirForca_Do_pulo (8);
        ork.AtribuirVelocidade (6);
        ork.AtribuirNumero_de_pes(2);
        ork.AtribuirNumero_de_maos(4);
        
        
    }
    
    }