using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Piece))]
public class PieceHandle : Editor
{
    private void OnSceneGUI()
    {
        Piece piece = (Piece)target;
        if (piece == null) return;

        Vector3 center = new Vector3(piece.position.x + 0.5f, piece.position.y + 0.5f, 0);
        Vector3 size = new Vector3(.9f, .9f, 0);
        Handles.DrawWireCube(center, size);
    }
}
