using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[CreateAssetMenu]
public class Key : Item
{
    public float distance = 2f;
    public TMP_Text attention;
    private float timeToHide;
    [SerializeField] private AudioSource doorOpenAudioSource;
    
    public override void Use()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        if (!Physics.Raycast(ray, out var hit, distance)) return;
        if (!hit.collider.CompareTag("Interactable")) return;
        var door = hit.collider.GetComponent<Door>();
        if (!door.isInteractable)
        {
            var inventory = GameObject.Find("Player").GetComponentInChildren<Inventory>();
            if (id == door.id)
            {
                door.isInteractable = true;
                inventory.RemoveItem(door.id);
                var audioSource = Instantiate(doorOpenAudioSource, GameObject.Find("Player").transform.position,
                    Quaternion.identity);
                audioSource.Play();
            }
                    
            /*if (door.isLocked)
            {
                attention.alpha = 1;
                timeToHide = 0;
            }*/
        }
        /*if (attention.alpha > 0)
        {
            timeToHide += Time.deltaTime;
            if (timeToHide >= 3)
                attention.alpha -= Time.deltaTime;
        }
        else
        {
            timeToHide = 0;
        }*/
    }
}
