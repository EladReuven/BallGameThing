using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartOptions : MonoBehaviour
{
    public KeyCode buttonRestart;
    public string layerTag;

    void Update()
    {
        if (Input.GetKeyUp(buttonRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == layerTag)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
