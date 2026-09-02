using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public enum PieceType { Pawn, Bishop, Knight, Rook, Queen, King}

    public PieceType type;
    public Color color;
    public Vector2 position;
    private void OnDrawGizmos()
    {
        Vector3 center = new Vector3(position.x - .5f + 1, position.y - .5f + 1);
        string name = type.ToString();
        Gizmos.DrawIcon(center, name, true,color);
    }
}
