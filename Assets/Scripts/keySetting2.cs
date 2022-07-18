using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySetting2 : MonoBehaviour
{
    public GameObject inticon, key;
    public AudioSource pickup;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                Door2.keyfound2 = true;
                inticon.SetActive(false);
                pickup.Play();
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
}
