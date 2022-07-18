using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySetting3 : MonoBehaviour
{
    public GameObject inticon, key;
    public AudioSource pickup;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                key.SetActive(false);
                Door3.keyfound3 = true;
                inticon.SetActive(false);
                pickup.Play();
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            inticon.SetActive(false);
        }
    }
}
