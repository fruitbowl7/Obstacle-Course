using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisonEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.tag = "Hit";
        }
    }
}
