using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinCondition : MonoBehaviour
{
    
    public string finishTag;
    //private bool Win = false;
    public ParticleSystem confetti;

    public UnityEvent instadConfetti;

    private void Start()
    {
        instadConfetti.AddListener(ConfettiOnGoal);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == finishTag)
        {
            gameObject.SetActive(false);
            instadConfetti.Invoke();
            //Win = true;
        }
    }

    public void ConfettiOnGoal()
    {
        Instantiate(confetti, gameObject.transform.position, confetti.transform.rotation);
    }

}
