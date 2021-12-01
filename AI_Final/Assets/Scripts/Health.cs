using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int curHealth;

    public float valueIn;

    void Start()
    {
        curHealth = maxHealth;
    }

    public void SubmitSetup()
    {
        HealthBar.instance.SetupHearts(maxHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            HealthBar.instance.RemoveHearts(valueIn);
        }
    }

    void Update()
    {
        if(curHealth == 0)
        {
            Application.Quit();
        }
    }
}
