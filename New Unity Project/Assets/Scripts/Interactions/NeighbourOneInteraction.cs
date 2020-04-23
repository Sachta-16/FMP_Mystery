using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NeighbourOneInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject NeighbourOneSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        NeighbourOneSpeechBubble.gameObject.SetActive(true);
    }
}
