using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] int ppID;

    public int getID() { return ppID; }
}
