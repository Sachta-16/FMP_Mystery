using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SuspectInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject SuspectSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        SuspectSpeechBubble.gameObject.SetActive(true);
    }
}
