using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NeighbourTwoInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject NeighbourTwoSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        NeighbourTwoSpeechBubble.gameObject.SetActive(true);
    }
}
