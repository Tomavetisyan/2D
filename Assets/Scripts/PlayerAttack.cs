using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 1;
    public LayerMask enemyLayers;
    public int attackDamage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Attack();
        }
    }
    void Attack(){
        Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D collider in detectedObjects){
           
            collider.GetComponent<HealthSystem>().damageHealth(attackDamage);
        }
    }
    void OnDrawGizmos(){
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
