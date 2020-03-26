using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealDmg : MonoBehaviour
{
    
    public float dmg = 6;
    public PlayerHealth pHP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Damage();
        }

       
    }

    public void Damage()
    {
        pHP.hpAtm = pHP.hpAtm - dmg;
        pHP.healthBar.value = pHP.CalculateHP();
        this.gameObject.SetActive(false);
        
    }


}
