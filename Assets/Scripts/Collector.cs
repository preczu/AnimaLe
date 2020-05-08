using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter (Collider target)
    {
        if (target.tag == "Bananas" || target.tag == "Cube") {
            target.gameObject.SetActive(false);  
		}
    }
}
