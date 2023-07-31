using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    Vector2 rightattackOffset;
    Collider2D swordCollider;

    private void Start() {
        swordCollider = GetComponent<Collider2D>();
        rightattackOffset = transform.position;
    }
    public void AttackRight(){
        swordCollider.enabled = true;
        transform.position = rightattackOffset;
    }

    public void AttackLeft(){
        swordCollider.enabled = true;
        transform.position = new Vector3(rightattackOffset.x * -1, rightattackOffset.y);
    }

    public void StopAttack(){
        swordCollider.enabled = false;
    }

}


