using UnityEngine;

public class Aventurero : MonoBehaviour
{
    //atributos
    private int experiencia;

    //propiedades
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public bool HaDetectadoTrampa { get; set; }

    public void RecibirDaño(int cantidad)
    {
        if (cantidad > 0)
        {
            Vida -= cantidad;
        }
    }
    
}
//gracias a este esquema sugerido he aprendido de que iba eso de get y set que no habia visto antes ;)