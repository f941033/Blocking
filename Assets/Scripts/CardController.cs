using UnityEngine;

public class CardController : MonoBehaviour
{
    bool yellowCard = false;
    bool orangeCard = false;
    public GameObject yellowDoor, orangeDoor;
    public GameObject linterna;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
                yellowDoor.GetComponent<Animator>().Play("AbrirPuerta");    
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
    }
}
