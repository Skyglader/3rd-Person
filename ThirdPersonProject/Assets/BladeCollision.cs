using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeCollision : MonoBehaviour
{
    [Range(0f, 30f)]
    public float range;

    public LayerMask enemy;
    public GameObject sword;
  
    void FixedUpdate()
    {
        
        activateBladeCollider();
    }

    public void activateBladeCollider()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, range, enemy))
        {
            Debug.Log("Hit enemy");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.up * range);
    }
}
