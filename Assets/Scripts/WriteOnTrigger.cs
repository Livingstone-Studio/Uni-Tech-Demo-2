using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerEventHandler))]
public class WriteOnTrigger : MonoBehaviour
{

    [SerializeField] private DialogueSO dialogueSO;
    public void SendToSubtitleHandler()
    {
        if (SubtitleHandler.Instance && dialogueSO)
        {
            SubtitleHandler.Instance.AddToSpeechQueue(dialogueSO);
        }
    }
}
