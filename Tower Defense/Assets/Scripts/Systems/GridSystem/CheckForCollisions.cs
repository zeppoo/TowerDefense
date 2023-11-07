using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollisions : MonoBehaviour
{
    public LayerMask collisionLayer; // Layer to check for collisions.
    public Vector2 colliderSize;

    public bool CheckForCollision(Vector2 position)
    {
        colliderSize = GameManager.selectedUnit.GetComponent<BoxCollider2D>().size;// pakt de collider grootte van de huidige unit
        Collider2D[] colliders = Physics2D.OverlapBoxAll(position, colliderSize, 0, collisionLayer);

        if(colliders.Length > 0 )
        {
            foreach (Collider2D collider in colliders)
            {
                Debug.Log("Collision detected with: " + collider.gameObject.name);
                // Handle the collision here.
            }
            return false;
        }
        return true;
    }
}

