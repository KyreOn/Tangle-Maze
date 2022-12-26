using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObjects : MonoBehaviour
{
    [SerializeField] public float speed;
    public bool isActivated;
    
    protected void Move(Vector3 startPos, Vector3 endPos)
    {
        var curPos = transform.localPosition;
        var newPos = isActivated
            ? new Vector3(
                Mathf.Clamp(curPos.x + speed * Time.deltaTime, startPos.x, endPos.x),
                Mathf.Clamp(curPos.y + speed * Time.deltaTime, startPos.y, endPos.y),
                Mathf.Clamp(curPos.z + speed * Time.deltaTime, startPos.z, endPos.z)
            )
            : new Vector3(
                Mathf.Clamp(curPos.x - speed * Time.deltaTime, startPos.x, endPos.x),
                Mathf.Clamp(curPos.y - speed * Time.deltaTime, startPos.y, endPos.y),
                Mathf.Clamp(curPos.z - speed * Time.deltaTime, startPos.z, endPos.z)
            );
        transform.localPosition = newPos;
    }

    protected void Rotate(Vector3 startRot, Vector3 endRot)
    {
        var curRot = transform.localRotation.eulerAngles;
        var newRot = isActivated
            ? new Vector3(
                Mathf.Clamp(curRot.x + speed * Time.deltaTime, startRot.x, endRot.x),
                Mathf.Clamp(curRot.y + speed * Time.deltaTime, startRot.y, endRot.y),
                Mathf.Clamp(curRot.z + speed * Time.deltaTime, startRot.z, endRot.z)
            )
            : new Vector3(
                Mathf.Clamp(curRot.x - speed * Time.deltaTime, startRot.x, endRot.x),
                Mathf.Clamp(curRot.y - speed * Time.deltaTime, startRot.y, endRot.y),
                Mathf.Clamp(curRot.z - speed * Time.deltaTime, startRot.z, endRot.z)
            );
        transform.localRotation = Quaternion.Euler(newRot);
    }
}
