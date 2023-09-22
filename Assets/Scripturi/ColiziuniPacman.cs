using UnityEngine;
using UnityEngine.UI;

public class ColiziuniPacman : MonoBehaviour
{
    public ControlPacman controlPacman;

    public FantomeFugDeTine fantomeFugDeTine1;
    public ControlFantome controlFantome1;

    public FantomeFugDeTine fantomeFugDeTine2;
    public ControlFantome controlFantome2;

    public FantomeFugDeTine fantomeFugDeTine3;
    public ControlFantome controlFantome3;

    public FantomeFugDeTine fantomeFugDeTine4;
    public ControlFantome controlFantome4;

    public FantomeFugDeTine fantomeFugDeTine5;
    public ControlFantome controlFantome5;

    public bool superPutere = false;
    public bool numara = false;

    public Text numaratoareInversaTxt;
    float timpCurent = 0f;
    float timpInitial = 10f;

    void Start()
    {
        timpCurent = timpInitial;
    }

    void Update()
    {
        if (numara == true)
        {
            timpCurent -= 1 % Time.deltaTime;
            numaratoareInversaTxt.text = timpCurent.ToString("0");


            if (numaratoareInversaTxt.text == "0")
            {
                controlFantome1.enabled = true;
                fantomeFugDeTine1.enabled = false; ;

                controlFantome2.enabled = true;
                fantomeFugDeTine2.enabled = false;

                controlFantome3.enabled = true;
                fantomeFugDeTine3.enabled = false;

                controlFantome4.enabled = true;
                fantomeFugDeTine4.enabled = false;

                controlFantome5.enabled = true;
                fantomeFugDeTine5.enabled = false;
            }

            if (timpCurent <= 0)
            {
                numaratoareInversaTxt.text = " ";
            }

          
        }
        
        if (timpCurent >= 3.5f)
        {
            numaratoareInversaTxt.color = Color.black;
        }

        if (timpCurent < 3.5f)
        {
            numaratoareInversaTxt.color = Color.red;
        }
    }


        void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Pereti")
        { Debug.Log(collisionInfo.collider.name); }


        if (collisionInfo.collider.tag == "Superputere")
        {

            Debug.Log("Superputere");
            Destroy(collisionInfo.gameObject);

            
            superPutere = true;
            numara = true;

            controlFantome1.enabled = false;
            fantomeFugDeTine1.enabled = true;

            controlFantome2.enabled = false;
            fantomeFugDeTine2.enabled = true;

            controlFantome3.enabled = false;
            fantomeFugDeTine3.enabled = true;

            controlFantome4.enabled = false;
            fantomeFugDeTine4.enabled = true;

            controlFantome5.enabled = false;
            fantomeFugDeTine5.enabled = true;


        }



        if (collisionInfo.collider.tag == "Fantome" && superPutere == false)
        {
            controlFantome1.enabled = false;
            controlFantome2.enabled = false;
            controlFantome3.enabled = false;
            controlFantome4.enabled = false;
            controlFantome5.enabled = false;

            controlPacman.enabled = false;
            FindObjectOfType<PacmanManager>().EndGame();
        }
        else if (collisionInfo.collider.tag == "Fantome" && superPutere == true)
        {
            Destroy(collisionInfo.gameObject);

        }

    }
}

