using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterChase : MonoBehaviour
{
    public Rigidbody monsterRigidbody;
    public Transform monsterTransform, playerTransform;
    public int monsterSpeed;

    private void FixedUpdate()
    {
        monsterRigidbody.velocity = transform.forward * monsterSpeed * Time.deltaTime;
    }

    private void Update()
    {
        monsterTransform.LookAt(playerTransform);
    }
}