using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{

    [SerializeField] InputActionProperty pinchAnimAction;
    [SerializeField] InputActionProperty gripAnimAction;

    [SerializeField] Animator handAnimController;

    float triggerValue;
    float gripValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        triggerValue = pinchAnimAction.action.ReadValue<float>();
        handAnimController.SetFloat("Trigger", triggerValue);

        gripValue = gripAnimAction.action.ReadValue<float>();
        handAnimController.SetFloat("Grip", gripValue);

    }
}
