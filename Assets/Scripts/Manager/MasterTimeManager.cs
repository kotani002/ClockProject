using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using E_PrefabNames;

public class MasterTimeManager : SingletonMonoBehaviour<MasterTimeManager>
{
    private DateTime _masterTime = new DateTime();

    public DateTime GetMasterTime()
    {
        return _masterTime;
    }

    private float _elapsedTime = 0f;
    
    void Awake()
    {
        //時間を取得する
        _masterTime = DateTime.Now;
        Debug.Log($"{_masterTime}");

    }

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime <= 1f)
        {
            return;
        }

        _masterTime = _masterTime.AddSeconds(1f);
        _elapsedTime -= 1f;
        
        if(UIPrefabManager.Instance.GetNowLevel() == PrefabName.DigitalClock)
        DigitalClockView.Instance.TimeUpdate(_masterTime);
    }

}
