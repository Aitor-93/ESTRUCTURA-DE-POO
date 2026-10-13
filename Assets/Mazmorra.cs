using UnityEngine;

public class Mazmorra : MonoBehaviour
{
    //atributos
    private int nivelPeligro;
    private int trampasDesactivadas;


    //propiedades
    public string Nombre { get; set; }
    public Aventurero Aventurero;

    private void Start()
    {
        ComenzarAventura();
    }

    public void ComenzarAventura()
    {
        float distancia = Vector3.Distance(transform.position, Aventurero.transform.position);

        if (distancia <= 50)
        {
            Debug.Log("La aventura ha comenzado.");
        }
    }

}

