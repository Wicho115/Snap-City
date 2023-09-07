using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public ParticleSystem pointsEffect;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            transform.GetComponent<Animator>().Play("Smashed");
            transform.GetComponent<BoxCollider>().enabled=false;
            GameObject.Find("GameManager").GetComponent<GameManager>().score += 5;
            pointsEffect.Play();

        }
    }
}
