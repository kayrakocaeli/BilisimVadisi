using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircarCeo : MonoBehaviour
{
    public static bool AirCarCeoCam = false;
    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (gameObject.GetComponent<NPC>().enabled = true) && Input.GetKeyDown(KeyCode.F))
        {
            AirCarCeoCam = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        AirCarCeoCam = false;

    }
}
