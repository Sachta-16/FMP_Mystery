using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpiritInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject SpiritSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        SpiritSpeechBubble.gameObject.SetActive(true);
    }
}
