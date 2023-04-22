using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggCeo : MonoBehaviour
{
    public static bool ToggCeoCam = false;
    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (gameObject.GetComponent<NPC>().enabled = true) && Input.GetKeyDown(KeyCode.F))
        {
            ToggCeoCam = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ToggCeoCam = false;

    }
}
