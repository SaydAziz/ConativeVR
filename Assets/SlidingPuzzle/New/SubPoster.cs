using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPoster : MonoBehaviour
{
    [SerializeField] int subID;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("CONTACT");
        if (other.GetComponentInParent<PuzzlePiece>().getID() == subID)
        {
            Destroy(other.transform.parent.gameObject);
            GetComponentInParent<Poster>().enableSub(subID);
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
