using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        for (int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                Vector3 center = new Vector3(i - 0.5f + 1, j - 0.5f + 1, 0);
                Vector3 size = new Vector3(1, 1f, 0);
                Gizmos.DrawWireCube(center, size);
            }
        }
    }
}
