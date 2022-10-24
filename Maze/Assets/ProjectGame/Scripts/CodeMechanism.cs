using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class CodeMechanism : MonoBehaviour
{
    [SerializeField] public List<CodeMechButton> buttons;
    [SerializeField] public UnityEvent onSolve;
    [SerializeField] public string rightSeq;
    [SerializeField] public float delayTime;
    private List<int> curSeq = new List<int>();
    private float curTimer;

    public void ButtonPressed(int id)
    {
        curSeq.Add(id);
    }

    public void Test()
    {
        Debug.Log("Right");
    }

    private void Update()
    {
        if (curSeq.Count == buttons.Count)
        {
            curTimer += Time.deltaTime;
            if (!(curTimer >= delayTime)) return;
            if (rightSeq == string.Join("", curSeq))
            {
                onSolve.Invoke();
                curSeq.Clear();
            }
            else
            {
                foreach (var button in buttons)
                {
                    button.ResetPos();
                }

                curSeq.Clear();
            }

            curTimer = 0;
        }
    }
}
