using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigiageCeo : MonoBehaviour
{
    public static bool DigiageCeoCam = false;
    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (gameObject.GetComponent<NPC>().enabled = true) && Input.GetKeyDown(KeyCode.F))
        {
            DigiageCeoCam = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        DigiageCeoCam = false;

    }
}
