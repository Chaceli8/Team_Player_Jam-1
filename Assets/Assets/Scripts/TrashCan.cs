using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class TrashCan : MonoBehaviour
{
    ThrowableBounds throwable;
    public string Tag = "Garbage";
    // Start is called before the first frame update
    void Start()
    {
        throwable = GetComponent<ThrowableBounds>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag(Tag))
        {
            throwable.MoveToPerimeter();
            other.GetComponent<GArbageBounds>().MoveToPerimeter();
        }
    }
}

    

