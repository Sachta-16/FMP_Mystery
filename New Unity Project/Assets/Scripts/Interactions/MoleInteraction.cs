using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoleInteraction : MonoBehaviour, IPointerClickHandler
{
    public GameObject MoleSpeechBubble;
    public void OnPointerClick(PointerEventData eventData)
    {
        MoleSpeechBubble.gameObject.SetActive(true);
    }
}

