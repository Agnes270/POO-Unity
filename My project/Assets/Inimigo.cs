using UnityEngine;

public class Inimigo: Personagem
{
    private string armadura;
    private string arma;
    
    
    public void AtribuirArmadura(string armadura)
    
    {
        this.armadura = armadura;
    }
    public string Armadura()
    
    {
        return this.armadura;
    }
    public void AtribuirArma(string arma)

    {
        this.arma = arma;
    }
    public string Arma()
    
    
    {
        return this.arma;
    }

    public int DamoInimigo()
    
    {
        int dano = 0;
        
        switch (arma)
    {
        case "Espada":
            dano = forca_ataque() + 10;
            break;
        case "Machado":
            dano = dano = forca_ataque() + 18;
            break;
        case "ADAGA":
            dano = forca_ataque() = 5;
            break;
            
    }
}