using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;
using TMPro;

public class RegisterController : MonoBehaviour
{
    [SerializeField] private string code = "2496";
    private string input = "";

    public TMP_Text display;
    private AudioSource audioSource;
    public AudioClip keySound;



    [SerializeField] private GameObject storage;
    public float speed = .05f;
    private Vector3 start;
    private Vector3 des;
    private float fraction = 0;

    public bool canOpen = false;
    bool canPush = true;

    private void Start()
    {
        start = new Vector3(storage.transform.position.x, storage.transform.position.y, storage.transform.position.z);
        des = new Vector3(storage.transform.position.x + -.2f, storage.transform.position.y, storage.transform.position.z);

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.spatialBlend = 1;
        audioSource.volume = .1f;
    }

    private void Update()
    {
        display.SetText(input);

    }


    private void FixedUpdate()
    {
        if (canOpen == true)
        {
            if (fraction < 1)
            {
                fraction += Time.deltaTime * speed;
                storage.transform.position = Vector3.Lerp(start, des, fraction);
            }
        }
        
    }

    public void Pressed1()
    {
        if (input.Length < 5)
        {
            input = input + "1";
        }
    }
    public void Pressed2()
    {
        if (input.Length < 5)
        {
            input = input + "2";
        }
    }
    public void Pressed3()
    {
        if (input.Length < 5)
        {
            input = input + "3";
        }
    }
    public void Pressed4()
    {
        if (input.Length < 5)
        {
            input = input + "4";
        }
    }
    public void Pressed5()
    {
        if (input.Length < 5)
        {
            input = input + "5";
        }
    }
    public void Pressed6()
    {
        if (input.Length < 5)
        {
            input = input + "6";
        }
    }
    public void Pressed7()
    {
        if (input.Length < 5)
        {
            input = input + "7";
        }
    }
    public void Pressed8()
    {
        if (input.Length < 5)
        {
            input = input + "8";
        }
    }
    public void Pressed9()
    {
        if (input.Length < 5)
        {
            input = input += "9";
        }
    }

    public void Pressed0()
    {
        
        if (input.Length < 5)
        {
            input = input + "0";
        }
    }

    public void PressedReset()
    {
        input = "";
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(keySound);
    }

    public void PressedEnter()
    {
        Debug.Log(input);
        if (input.Length == 4)
        {           
            if (input == code)
            {
                canOpen = true;
                Debug.Log("Open");
            }
        }
    }

}
