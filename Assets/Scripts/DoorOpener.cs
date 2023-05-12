using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public float swingAngle = 90f;  // The angle to swing the door open
    public float swingSpeed = 2f;   // The speed at which the door swings open
    public string keyTag = "key";   // The tag of the object that can open the door

    private bool isOpen = false;   // Indicates whether the door is currently open
    private Quaternion closedRotation;   // The initial rotation of the door
    private Quaternion openRotation;     // The target rotation of the door when it's open

    private void Start()
    {
        // Save the initial rotation of the door as the "closed" rotation
        closedRotation = transform.rotation;

        // Calculate the "open" rotation by adding the swing angle to the closed rotation
        openRotation = Quaternion.Euler(closedRotation.eulerAngles + Vector3.up * swingAngle);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the "key" tag
        if (other.CompareTag(keyTag))
        {
            // If so, start opening the door
            isOpen = true;
        }
    }

    private void Update()
    {
        // If the door is open, swing it open towards the "open" rotation
        if (isOpen)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * swingSpeed);
            this.gameObject.GetComponent<Single_has_been_completed>().activate_has_been_done();
        }
        // Otherwise, swing it closed towards the "closed" rotation
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * swingSpeed);
        }
    }
}
