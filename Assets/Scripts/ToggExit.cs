using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToggExit : MonoBehaviour
{
    public bool InArea = false;
    private void Update()
    {

        if ((Input.GetKeyDown(KeyCode.F)))
        {
            if (InArea == true)
            {
                Debug.Log("F ye basýldý");
                SceneManager.LoadScene("Main_Scene_Togg_Exit");
            }

        }
        if ((Input.GetKeyDown(KeyCode.P)))
        {
            
                SceneManager.LoadScene("Togg");
           

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("girdi");
            InArea = true;


            //EnterText.SetActive(true);
            //EnterButton.SetActive(true);
            //CarEnterExit.outsideCar = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InArea = false;
            //EnterText.SetActive(false);
            //EnterButton.SetActive(false);
            //CarEnterExit.outsideCar = false;
        }
    }
}
