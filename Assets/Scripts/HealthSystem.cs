using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void damageHealth(int damage){
        if(currentHealth-damage < 0){
            currentHealth = 0;
        }else{
            currentHealth-= 10;
        }

        if(currentHealth <=0){
            Die();
        }
    }
    void Die(){
        //Death animation
        Debug.Log(name + " Died");
        Destroy(gameObject);
    }
    public void healHealth(int heal){
        if((currentHealth+heal) > maxHealth){
            currentHealth=maxHealth;
        }else{
            currentHealth+=heal;
        }
    }
}
