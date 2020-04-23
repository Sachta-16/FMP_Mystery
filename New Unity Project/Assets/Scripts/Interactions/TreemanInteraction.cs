using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TreemanInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject TreemanSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        TreemanSpeechBubble.gameObject.SetActive(true);
    }
}