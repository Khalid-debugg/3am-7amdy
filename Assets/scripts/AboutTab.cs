using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutTab : MonoBehaviour
{
    public void aboutTab()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }
}
