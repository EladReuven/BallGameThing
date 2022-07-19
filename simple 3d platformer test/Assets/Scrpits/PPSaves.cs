using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPSaves : MonoBehaviour
{
    public string playerName;
    //private string savedName;

    private void Start()
    {
        string savedName = PlayerPrefs.GetString("name");
        if (savedName != null)
        {
            playerName = savedName;
        }
        Debug.Log(playerName);
    }

    [ContextMenu("print name")]
    public void PrintName()
    {
        Debug.Log(playerName);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("name", playerName);
    }

}
