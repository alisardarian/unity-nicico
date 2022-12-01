using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IDragHandler
{
    public Transform platformTransform;
    
    public void OnDrag(PointerEventData eventData)
    {
        var delta = eventData.delta;
        delta.y = 0;
        
        platformTransform.Translate(delta*Time.deltaTime);
    }
}
