using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterStop : MonoBehaviour
{
    public GameObject monster;
    public Collider collision1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monster"))
        {
            monster.SetActive(false);
            collision1.enabled = false;
        }
    }
}
