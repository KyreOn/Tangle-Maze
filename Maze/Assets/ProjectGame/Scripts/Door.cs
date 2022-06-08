using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

/*public class Door : MonoBehaviour
{   [SerializeField]
    float openDoor;
    [SerializeField]
    float closeDoor;
    [SerializeField] 
    float speed = 1;
    


    public bool isOpen;
    public bool isLocked;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }

    void OpenDoor()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, openDoor, transform.rotation.z), speed * Time.deltaTime);
    }

    void CloseDoor()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, closeDoor, transform.rotation.z), speed * Time.deltaTime);
    }
}*/

public class Door : Interactable
{
    [SerializeField] float openDoor;
    [SerializeField] float closeDoor;
    [SerializeField] float speed = 1;
    [SerializeField] private AudioSource interactSound;

    void Update()
    {
        if (isActivated)
            transform.rotation = Quaternion.Slerp(transform.rotation, 
                Quaternion.Euler(transform.rotation.x, openDoor, transform.rotation.z), speed * Time.deltaTime);
        if (!isActivated)
            transform.rotation = Quaternion.Slerp(transform.rotation, 
                Quaternion.Euler(transform.rotation.x, closeDoor, transform.rotation.z), speed * Time.deltaTime);

    }

    public override void OnInteract()
    {
        if (isInteractable)
        {
            interactSound.Play();
            isActivated = !isActivated;
        }
    }
}