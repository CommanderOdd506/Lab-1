using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public enum PieceType { Pawn, Bishop, Knight, Rook, Queen, King}
    [Header("Piece Type")]
    [Tooltip("Change the type of piece this Icon is")]
    public PieceType type;
    
    [Header("Color of Piece")]
    [Tooltip("Change the color of piece this Icon is")]
    public Color color;
    
    [Header("Position")]
    [Tooltip("Change the location of the piece this icon is at in (x,y) coordinates, (0,0) being the square A1")]
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
                        Vector3 center = new Vector3(i + 1.5f + position.x, j + 1.5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        if (i == j && (i != -1 && j!= -1))
                        { Gizmos.DrawCube(center, size); }
                    }
                }
                for (int i = 7; i > -8; i--)
                {
                    for (int j = -7; j < 8; j++)
                    {
                        Vector3 center = new Vector3(i + .5f + position.x, j + .5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);
                        
                        if (-i == j && (i != 0 && j != 0))  
                        { Gizmos.DrawCube(center, size); }
                    }
                }
                break;
            case PieceType.Knight:
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 1; j < 3; j++)
                    {
                        int newY = j;
                        int newX = j == 2? 1 : 2;
                        switch (i)
                        {
                            case 1:
                                newY = -newY;
                                break;
                            case 2:
                                newX = -newX;
                                break;
                            case 3:
                                newX = -newX;
                                newY = -newY;
                                break;
                            default:
                                break;
                        }
                        Vector3 center = new Vector3(newX + .5f + position.x, newY + 0.5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        Gizmos.DrawCube(center, size);
                    }
                }
                break;
            case PieceType.Rook:
                for (int i = -8; i < 8; i++)
                {
                    Vector3 center = new Vector3(i + .5f + position.x, 0.5f + position.y, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    if (i != 0)
                    { Gizmos.DrawCube(center, size); }
                }
                for (int i = -7; i < 8; i++)
                {
                    Vector3 center = new Vector3(.5f + position.x, i + 0.5f + position.y, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    if (i != 0)
                    { Gizmos.DrawCube(center, size); }
                }
                break;
            case PieceType.Queen:
                for (int i = -8; i < 7; i++)
                {
                    for (int j = -8; j < 7; j++)
                    {
                        Vector3 center = new Vector3(i + 1.5f + position.x, j + 1.5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        if (i == j && (i != -1 && j != -1))
                        { Gizmos.DrawCube(center, size); }
                    }
                }
                for (int i = 7; i > -8; i--)
                {
                    for (int j = -7; j < 8; j++)
                    {
                        Vector3 center = new Vector3(i + .5f + position.x, j + .5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        if (-i == j && (i != 0 && j != 0))
                        { Gizmos.DrawCube(center, size); }
                    }
                }
                for (int i = -8; i < 8; i++)
                {
                    Vector3 center = new Vector3(i + .5f + position.x, 0.5f + position.y, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    if (i != 0)
                    { Gizmos.DrawCube(center, size); }
                }
                for (int i = -7; i < 8; i++)
                {
                    Vector3 center = new Vector3(.5f + position.x, i + 0.5f + position.y, 0);
                    Vector3 size = new Vector3(1, 1, 0);
                    if (i != 0)
                    { Gizmos.DrawCube(center, size); }
                }
                break;
            case PieceType.King:
                for (int i = -1; i < 2; i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        Vector3 center = new Vector3(i + .5f + position.x,j+  0.5f + position.y, 0);
                        Vector3 size = new Vector3(1, 1, 0);

                        if (i == 0 && j == 0)
                        {
                            continue;
                        }
                        Gizmos.DrawCube(center, size);
                    }
                }
                break;
            default:
                break;
        }
    }

}
