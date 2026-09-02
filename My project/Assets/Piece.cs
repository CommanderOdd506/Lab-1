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
                    Vector3 center = new Vector3(i +0.5f + position.x, 1.5f+ position.y, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    Gizmos.DrawCube(center, size);
                }
                break;
            case PieceType.Bishop:
                for(int i = -8; i < 7; i++)
                {
                    for(int j = -8; j < 7; j++)
                    {
                        Vector3 center1 = new Vector3(i + 1.5f + position.x, j + 1.5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        if (i == j && (i != -1 && j!= -1))
                        { Gizmos.DrawCube(center1, size); }
                    }
                }
                for (int i = 7; i > -8; i--)
                {
                    for (int j = -7; j < 8; j++)
                    {
                        Vector3 center1 = new Vector3(i + .5f + position.x, j + .5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);
                        
                        if (-i == j && (i != 0 && j != 0))  
                        { Gizmos.DrawCube(center1, size); }
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
