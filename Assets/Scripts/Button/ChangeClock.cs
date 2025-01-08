using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using E_PrefabNames;

public class ChangeClock : MonoBehaviour
{
    [SerializeField]
    private float _magnification = 1.1f;
    public void OnClick()
    {
        switch(UIPrefabManager.Instance.GetNowLevel())
        {
            case PrefabName.AnalogClock:
            UIPrefabManager.Instance.ChangeClock(PrefabName.DigitalClock);
            break;

            case PrefabName.DigitalClock:
            UIPrefabManager.Instance.ChangeClock(PrefabName.AnalogClock);
            break;
            
            case PrefabName.TimeChangeWindow:
            UIPrefabManager.Instance.ChangeClock(PrefabName.DigitalClock);
            break;

            default:
            Debug.LogError("規定外のプレハブを生成しようとしました");
            break;

        }
    }

    public void OnMouseEnter()
    {
        transform.localScale = transform.localScale*_magnification; 
    }
    
    public void OnMouseExit()
    {
        transform.localScale = transform.localScale/_magnification; 
    }
}
