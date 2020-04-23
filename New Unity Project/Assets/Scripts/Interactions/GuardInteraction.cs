using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GuardInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject GuardSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        GuardSpeechBubble.gameObject.SetActive(true);
    }
}
