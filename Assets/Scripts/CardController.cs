using TMPro;
using UnityEngine;

public class CardController : MonoBehaviour
{
    bool yellowCard = false;
    bool orangeCard = false;
    bool tarjetaBlanca = false;
    public GameObject yellowDoor, orangeDoor, puertaTraje1, puertaTraje2;
    public GameObject linterna;
    public GameObject mirilla, visorTraje;
    bool mirillaEnPantalla=false;
    public GameObject dron, proyectil, textoPuertaAmarilla, textoPuertaNaranja, textoPressE;
    public TextMeshProUGUI textoFinal;
    bool tengoTaser = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visorTraje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && tengoTaser)
        {
            mirillaEnPantalla = !mirillaEnPantalla;
            mirilla.SetActive(mirillaEnPantalla);            
        }

        if(mirillaEnPantalla && Input.GetMouseButtonDown(0))
        {
            GameObject bala = Instantiate(proyectil, mirilla.transform.position,Quaternion.identity);
            bala.GetComponent<Rigidbody>().linearVelocity = mirilla.transform.forward * 20f;
            Destroy(bala,3f);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "YellowCard")
        {
            yellowCard = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "YellowDoor")
        {
            if (yellowCard)
            {
                yellowDoor.GetComponent<Animator>().Play("AbrirPuertaAmarilla"); 
                textoPuertaAmarilla.SetActive(false) ;
                dron.GetComponent<AudioSource>().Stop();
            }
        }

        if (other.tag == "OrangeCard")
        {
            orangeCard = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "OrangeDoor")
        {
            if(orangeCard)
            {
                orangeDoor.GetComponent<Animator>().Play("AbrirPuertaNaranja");
                textoPuertaNaranja.SetActive(false);
            }
        }

        if (other.tag == "Linterna")
        {
            Destroy(other.gameObject);
            linterna.SetActive(true);
        }

        if (other.tag == "Botiquin")
        {
            Destroy(other.gameObject);
        }

        if (other.tag == "Taser")
        {
            tengoTaser = true;
            textoPressE.SetActive(true) ;
            Invoke("QuitarMirilla", 3f);
            Destroy(other.gameObject);
            mirillaEnPantalla = !mirillaEnPantalla;
            mirilla.SetActive(mirillaEnPantalla);
        }

        if (other.tag == "Traje")
        {
            Destroy(other.gameObject);
            visorTraje.SetActive(true);
            textoFinal.text = "FIN DEL JUEGO";
        }

        if (other.tag == "TarjetaBlanca")
        {
            tarjetaBlanca = true;
            Destroy(other.gameObject);
        }

        if (other.tag == "LectorBlanco")
        {
            if (tarjetaBlanca)
            {
                puertaTraje1.GetComponent<Animator>().Play("PuertaTraje1");
                
            }
        }

        if (other.tag == "LectorBlanco2")
        {
            if (tarjetaBlanca)
            {
                puertaTraje2.GetComponent<Animator>().Play("PuertaTraje2");
            }
        }
    }

    private void QuitarMirilla()
    {
        textoPressE.SetActive(false) ;    
    }


}
