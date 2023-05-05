using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] GameObject[] subList = new GameObject[9];

    public void enableSub(int index)
    {
        subList[index].SetActive(true);
    }
}
