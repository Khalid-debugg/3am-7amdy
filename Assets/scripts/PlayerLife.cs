using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private bool dead = false;

    private void Update()
    {
        if (transform.position.y < -15f && !dead) Death();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy body"))
        {
            Death();
        }
    }

    void Death() 
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        Invoke(nameof(Respawn), 1.5f);
        dead = true;
    }

    void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
