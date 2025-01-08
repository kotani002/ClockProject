using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DigitalClockView : SingletonMonoBehaviour<DigitalClockView>
{
    [SerializeField]
    private List<DigitalNumberView> _digitalClockView = new List<DigitalNumberView>();
    
    void Start()
    {
        OnEnable();
    }

    void OnEnable()
    {
        SetUp();
        TimeUpdate(MasterTimeManager.Instance.GetMasterTime());
    }

    public void SetUp()
    {
        foreach (var item in _digitalClockView)
        {
            item.SetUp();
        }
    }

    public void TimeUpdate(DateTime setTime)
    {
        for(int i=0; i <= _digitalClockView.Count;i++)
        {
            if(i == 0)
            {
            _digitalClockView[i].ChangeNumber(setTime.Second % 10);
            }
            if(i == 1)
            {
            _digitalClockView[i].ChangeNumber(setTime.Second / 10);
            }
            if(i == 2){
            _digitalClockView[i].ChangeNumber(setTime.Minute % 10);
            }
            if(i == 3){
            _digitalClockView[i].ChangeNumber(setTime.Minute / 10);
            }
            if(i == 4){
            _digitalClockView[i].ChangeNumber(setTime.Hour % 10);
            }
            if(i == 5){
            _digitalClockView[i].ChangeNumber(setTime.Hour / 10);
            }

        }
    }
}
