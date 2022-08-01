using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finisher : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
            Debug.Log("You've finish the game!");
            gameObject.tag = "Hit";
        }
    }
}
