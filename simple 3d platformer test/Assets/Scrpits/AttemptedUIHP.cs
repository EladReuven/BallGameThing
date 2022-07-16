using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttemptedUIHP : MonoBehaviour
{
    public Image[] hearts;
    public int livesRemaining;

    public void loseLife()
    {
        livesRemaining--;


    }

}
