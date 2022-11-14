using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSFXManager : MonoBehaviour
{
  public AudioSource audioSourceClick;
  public AudioSource audioSourceSelect;
  public AudioSource audioSourcePointerOver;

  public static ButtonsSFXManager instance { get; private set; }

  private void Awake()
  {
    if (instance == null)
      instance = this;
  }

  public void PlayClick()
  {
    audioSourceClick.Play();
  }
  public void PlaySelect()
  {
    audioSourceSelect.Play();
  }
  public void PlayPointerOver()
  {
    audioSourcePointerOver.Play();
  }
}
