using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickierPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "7amdy")
        {
            collision.gameObject.transform.SetParent(transform); 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "7amdy")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
