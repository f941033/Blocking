using TMPro;
using UnityEngine;

public class CardController : MonoBehaviour
{
    bool yellowCard = false;
    bool orangeCard = false;
    public GameObject yellowDoor, orangeDoor;
    public GameObject linterna;
    public GameObject mirilla, visorTraje;
    bool mirillaEnPantalla=false;
    public GameObject proyectil;
    public TextMeshProUGUI textoFinal, textoPuertaAmarilla;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visorTraje.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
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
                textoPuertaAmarilla.enabled = false;
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
    }
}
