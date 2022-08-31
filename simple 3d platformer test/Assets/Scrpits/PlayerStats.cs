using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Lives;
    public Text Death;
    public Image[] heart;
    public int MaxHP;
    public int CurrentHP { get; private set; }
    
    void Start()
    {
        CurrentHP = MaxHP;
        Death.enabled = false;
        Lives.enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            CurrentHP -= 1;
            heart[CurrentHP].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHP <= 0)
        {
            Death.enabled = true;
            gameObject.SetActive(false);
        }
    }
}
