using UnityEngine;

public class TrampaMagica : MonoBehaviour
{
    //atributos
    private float distanciaDesactivacion = 5;
    private float distanciaActivacion = 2;

    private Guardian guardian;

    //propiedades
    public string Nombre { get; set; }
    public bool Activa { get; set; }
    
    public void ComprobarTrampa(Aventurero aventurero)
    {
        float distancia = Vector3.Distance(transform.position, aventurero.transform.position);

        if (distancia <= distanciaDesactivacion && aventurero.HaDetectadoTrampa)
        {
            Activa = false;
        }

        if (distancia <= distanciaActivacion && Activa)
        {
            guardian.gameObject.SetActive(true);
        }
    }

}
