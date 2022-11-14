using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSFX : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, ISelectHandler
{
  public void OnPointerEnter(PointerEventData eventData)
  {
    ButtonsSFXManager.instance.PlayPointerOver();
  }

  public void OnPointerClick(PointerEventData eventData)
  {
    ButtonsSFXManager.instance.PlayClick();
  }

  public void OnSelect(BaseEventData eventData)
  {
    ButtonsSFXManager.instance.PlaySelect();
  }
}
