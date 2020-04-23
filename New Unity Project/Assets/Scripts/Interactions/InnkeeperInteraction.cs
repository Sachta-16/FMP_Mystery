using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InnkeeperInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject InnkeeperSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        InnkeeperSpeechBubble.gameObject.SetActive(true);
    }
}