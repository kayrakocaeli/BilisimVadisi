using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject canvas;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            canvas.gameObject.SetActive(false);
        }
    }
    
}
