using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class itemCollector : MonoBehaviour
{
    int coins = 0;

    [SerializeField] TMP_Text coinsText;
    [SerializeField] AudioSource coinsSound;
    private void OnTriggerEnter(Collider other) 
    {
            if (other.gameObject.CompareTag("coin"))
            {
                coinsSound.Play();
                Destroy(other.gameObject);
                coins++;
                coinsText.text = "Coins: " + coins;
                Debug.Log(coinsText);
            }
    }
}
