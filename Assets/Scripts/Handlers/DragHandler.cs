using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Handlers
{
    public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [NonSerialized]
        public GameObject TargetSlot;
    
        public void OnBeginDrag(PointerEventData eventData)
        {
            TargetSlot = transform.parent.gameObject;
            transform.SetParent(transform.parent.parent.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.DOMove(TargetSlot.transform.position, 0.25f)
                .SetEase(Ease.OutSine)
                .OnComplete(() =>
                {
                    transform.SetParent(TargetSlot.transform);
                    GetComponent<CanvasGroup>().blocksRaycasts = true;
                });
        }
    }
}