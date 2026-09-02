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

    private void OnDrawGizmosSelected()
    {
        switch (type)
        {
            case PieceType.Pawn:
                for(int i = -1; i < 2; i++)
                {
                    Vector3 center = new Vector3(i +0.5f, 1.5f, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    Gizmos.DrawCube(center, size);
                }
                break;
            case PieceType.Bishop:
                for(int i = 0; i < 7; i++)
                {
                    for(int j = 0; j < 7; j++)
                    {

                    }
                }
                break;
            case PieceType.Knight:
                break;
            case PieceType.Rook:
                break;
            case PieceType.Queen:
                break;
            case PieceType.King:
                break;
            default:
                break;
        }
    }

}
