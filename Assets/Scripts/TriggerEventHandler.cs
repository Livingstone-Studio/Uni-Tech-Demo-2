using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEventHandler : MonoBehaviour
{

    [SerializeField] private List<string> listOfTags = new List<string>();

    [SerializeField] private UnityEvent OnTriggerEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (IsOfTagged(other))
        {
            OnTriggerEvents?.Invoke();
            GetComponent<Collider>().enabled = false;
        }
    }

    private bool IsOfTagged(Collider other)
    {
        bool collided = false;

        foreach (string tag in listOfTags)
        {
            if (other.CompareTag(tag))
            {
                collided = true;
            }
        }

        return collided;
    }
}
