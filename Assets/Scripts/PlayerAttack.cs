using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour{

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPoss;
    public float attackRange;

    void Update(){ 

        if(timeBtwAttack <= 0){

            if (Input.GetKey(KeyCode.J)) {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, );

            }

            timeBtwAttack = startTimeBtwAttack;
        } else

        {
            timeBtwAttack -= Time.deltaTime;
        }

    }


}
