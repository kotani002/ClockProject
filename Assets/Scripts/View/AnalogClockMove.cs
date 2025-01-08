using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using System;

public class AnalogClockMove : SingletonMonoBehaviour<AnalogClockMove>
{
    // Start is called before the first frame update
    private TimeClass _nowTimeData = new TimeClass();
    [SerializeField]
    private GameObject _secondNeedle = null;
    [SerializeField]
    private GameObject _minuteNeedle = null;
    [SerializeField]
    private GameObject _hourNeedle = null;
    private Vector3 nextSecondAngle,nextMinuteAngle,nextHourAngle;

    void Start()
    {
        //時間を取得する
        SetAngles();
        
        //その角度の間の角度を補完しながら動作させる
    }
    
    void Update()
    {
       ChangeNextAngles();
    }

    public void SetAngles()
    {
        //時間*(360/60)で角度を割り出して
        //取得した時間の方向に針をセットする
        var setTime = MasterTimeManager.Instance.GetMasterTime();
        var vec = 360/60;
        //変更させたい角度
        _secondNeedle.transform.eulerAngles = new Vector3(0,0,setTime.Second*vec*-1);
        _minuteNeedle.transform.eulerAngles = new Vector3(0,0,setTime.Minute*vec*-1);
        _hourNeedle.transform.eulerAngles = new Vector3(0,0,setTime.Hour*vec*-1);
        //現在の角度と変更後の角度の間の角度を補完しながら動作させる
    }

    public void ChangeNextAngles()
    {
        //変更させたい角度
        _secondNeedle.transform.Rotate(0f,0f,-360f/60f*Time.deltaTime);
        _minuteNeedle.transform.Rotate(0f,0f,-360f/60f/60f*Time.deltaTime);
        _hourNeedle.transform.transform.Rotate(0f,0f,-360f/60f/60f/60f*Time.deltaTime);
    }

    public class TimeClass
    {
        public int _hour = 0;
        public int _minutes = 0;
        public int _second = 0;
    }
}
