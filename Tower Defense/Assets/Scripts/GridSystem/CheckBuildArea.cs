using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBuildArea : MonoBehaviour
{
    public LayerMask buildableArea;

    public bool IsPositionBuildable(Vector2 position)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero, Mathf.Infinity, buildableArea);

        if (hit.collider != null)
        {
            return true; // Position is within the buildable area.
        }

        return false; // Position is outside the buildable area.
    }
}
