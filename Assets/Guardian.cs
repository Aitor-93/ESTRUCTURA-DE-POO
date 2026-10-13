using UnityEngine;

public class Guardian : MonoBehaviour
{

    //atributos
    private bool estaEnAlerta;
    private int tiempoProtegiendo;


    //propiedades
    public string Nombre { get; set; }
    public int Daño { get; set; }


    public void Atacar(Aventurero aventurero)
    {
        if (Daño > 0)
        {
            aventurero.RecibirDaño(Daño);
        }
    }
    
}
