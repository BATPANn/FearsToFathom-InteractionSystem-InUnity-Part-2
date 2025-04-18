using UnityEngine;
using UnityEngine.UI;

public class F2FInteractionSystem : MonoBehaviour
{


    public GameObject BSTake;

    public GameObject BSHeld;

    public GameObject BSPlaced;

    // yellow box

    public GameObject YBTake;
    public GameObject YBHeld;
    public GameObject YBPlaced;

    // yellow box

    // black Cylinder

    public GameObject BCTake;
    public GameObject BCHeld;
    public GameObject BCPlaced;

    // black Cylinder

    bool CanDoJob = true;

    public Text InteractionText;

    // inventory 

    bool HaveBlueSphere = false;

    bool HaveYellowBox = false;

    bool HaveBlackCylinder = false;

    // inventory 


    public AudioSource source;

    public AudioClip TakeClip;
    public AudioClip PlaceClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {




        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(CanDoJob == true)
        {


            Ray ray1 = new Ray(transform.position, transform.forward);
            RaycastHit hit1;

            if(Physics.Raycast(ray1, out hit1, 5f))
            {


                if (hit1.collider.CompareTag("BlueSphere") && HaveBlueSphere == false)
                {

                    InteractionText.text = "Take Blue Sphere";

                    if(Input.GetMouseButtonDown(0))
                    {


                        BSTake.SetActive(false);
                        BSHeld.SetActive(true);

                        HaveBlueSphere = true;

                        source.PlayOneShot(TakeClip);


                    }


                }
                else if (hit1.collider.CompareTag("PlaceBlueSphere") && HaveBlueSphere == true)
                {

                    InteractionText.text = "Place Blue Sphere";

                    if(Input.GetMouseButtonDown(0))
                    {


                        BSHeld.SetActive(false);
                        BSPlaced.SetActive(true);

                        HaveBlueSphere = false;

                        source.PlayOneShot(PlaceClip);

                    }



                }
                else if(hit1.collider.CompareTag("YellowBox") && HaveYellowBox == false)
                {


                    InteractionText.text = "Take Yellow Box";

                    if(Input.GetMouseButtonDown(0))
                    {


                        YBTake.SetActive(false);

                        YBHeld.SetActive(true);

                        HaveYellowBox = true;

                        source.PlayOneShot(TakeClip);


                    }


                }
                else if(hit1.collider.CompareTag("PlaceYellowBox") && HaveYellowBox == true)
                {


                    InteractionText.text = "Place Yellow Box";

                    if(Input.GetMouseButtonDown(0))
                    {


                        YBHeld.SetActive(false);
                        YBPlaced.SetActive(true);

                        HaveYellowBox = false;

                        source.PlayOneShot(PlaceClip);

                    }


                }
                else if(hit1.collider.CompareTag("BlackCylinder") && HaveBlackCylinder == false)
                {

                    InteractionText.text = "Take Black Cylinder";

                    if (Input.GetMouseButtonDown(0))
                    {

                        BCTake.SetActive(false);
                        BCHeld.SetActive(true);

                        HaveBlackCylinder = true;

                        source.PlayOneShot(TakeClip);



                    }



                }
                else if(hit1.collider.CompareTag("PlaceBlackCylinder") && HaveBlackCylinder == true)
                {


                    InteractionText.text = "Place Black Cylinder";


                    if (Input.GetMouseButton(0))
                    {


                        BCHeld.SetActive(false);
                        BCPlaced.SetActive(true);

                        HaveBlackCylinder = false;

                        source.PlayOneShot(PlaceClip);


                    }

                    

                }
                else
                {

                    InteractionText.text = "";



                }





            }
            else
            {


                InteractionText.text = "";


            }




        }



    }
}
