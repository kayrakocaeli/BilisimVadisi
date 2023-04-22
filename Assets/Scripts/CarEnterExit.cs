using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarEnterExit : MonoBehaviour
{
    
    public GameObject EnterText;
    public GameObject ExitText;
   
    public GameObject CarCamera;
    public GameObject playerCamera;
    public GameObject TriggerObject;
    

    public GameObject playerMain;

    public Transform carTransform;

    public Transform EnterPlayerPosition;
    public Transform ExitPlayerPosition;

    public static bool insideCar = false;
    public static bool outsideCar = false;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Enter Car
        if (Input.GetKeyDown(KeyCode.F) && outsideCar == true)
        {
           
            
            EnterText.SetActive(false);
        
            ExitText.SetActive(true);
            //playerCamera.SetActive(false);
            //playerMain.transform.SetParent(carTransform);
            //playerMain.SetActive(false);


            //this.gameObject.GetComponent<HoverController>().enabled = true;
            //this.gameObject.GetComponent<CarUserControl>().enabled = true;
            //this.gameObject.GetComponent<CarAudio>().enabled = true;
            //insideCar = true;


            //StartCoroutine(PauseForCamera());
            




        }

            //Exit Car
            if (Input.GetKeyDown(KeyCode.G) && insideCar == true)
            {

          
            
                ExitText.SetActive(false);



               
            //this.gameObject.GetComponent<HoverController>().enabled = false;
            //this.gameObject.GetComponent<CarUserControl>().enabled = false;
            //this.gameObject.GetComponent<CarAudio>().enabled = false;
            //insideCar = false;


                
                //StartCoroutine(ExitCourotine());
            }


        }


    /*
        IEnumerator PauseForCamera()
        {
            //yield return new WaitForSeconds(5);
            
            //CarCamera.SetActive(true);

            
        }

        IEnumerator ExitCourotine()
        {
            //yield return new WaitForSeconds(5);
            
           
            //playerMain.transform.SetParent(carTransform, false);
            //playerCamera.SetActive(true);
            //playerMain.SetActive(true);
        }
    */



        //For Buttons
        public void EnterCarFunction()
        {

            //EnterText.SetActive(false);
            //ExitText.SetActive(true);
            //playerCamera.SetActive(false);
            //playerMain.transform.SetParent(carTransform);
            //playerMain.SetActive(false);
            

       // this.gameObject.GetComponent<HoverController>().enabled = true;
        //this.gameObject.GetComponent<CarUserControl>().enabled = true;
        //this.gameObject.GetComponent<CarAudio>().enabled = true;
        //insideCar = true;

       
            //StartCoroutine(PauseForCamera());
        }

        public void ExitCarFunction()
        {
   
       
           // ExitText.SetActive(false);



           
        //this.gameObject.GetComponent<HoverController>().enabled = true;
        //this.gameObject.GetComponent<CarUserControl>().enabled = false;
        //this.gameObject.GetComponent<CarAudio>().enabled = false;

        // insideCar = false;


        //StartCoroutine(ExitCourotine());
        }
    } 
