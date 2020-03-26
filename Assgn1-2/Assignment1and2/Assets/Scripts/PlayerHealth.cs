using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float hpAtm { get; set; }
    public float maxHP { get; set; }

    public Slider healthBar;


    // Start is called before the first frame update
    void Start()
    {
        maxHP = 20f;
        hpAtm = maxHP;

        healthBar.value = CalculateHP();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float dmgVal)
    {
        hpAtm -= dmgVal;

        healthBar.value = CalculateHP();
        
    }


    public void TakeDamage(float dmgAmount)
    {
        hpAtm -= dmgAmount;
    }

    public float CalculateHP()
    {
        return hpAtm / maxHP;
    }

   
}

