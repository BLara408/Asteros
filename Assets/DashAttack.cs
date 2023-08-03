using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAttack : MonoBehaviour
{
   public Collider2D dashCollider;
    public float damage = 3;
    Vector2 rightAttackOffset;
    public float dashDistance = 10f; 
    void Start()
    {
       rightAttackOffset = transform.localPosition;
       
    }

 
    
   public void AttackRight() {
        dashCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft() {
        dashCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack() {
        print("Stop Dashattack called");
        dashCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "CollisionObjects") {
        print("Collided with collision objects");
        dashCollider.enabled = false;
        StopAttack();
     }

        if(other.tag == "Enemy") {
            // Deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null) {
                enemy.Health -= damage;
            }
        }
    
    }
}
