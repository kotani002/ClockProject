using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using E_PrefabNames;

public class UIPrefabManager : MonoBehaviour
{
    [SerializeField]
    private Transform _parentCanvasTransform;
    [SerializeField]
    private PrefabName _nowLevel = new PrefabName();

    [SerializeField]
    private List<PrefabContainer>_prefabContainers = new List<PrefabContainer>();
    private Dictionary<PrefabName,PrefabContainer> _prefabContainersDictionary = new Dictionary<PrefabName, PrefabContainer>();
    private Dictionary<PrefabName,GameObject> _existPrefabContainersDictionary = new Dictionary<PrefabName, GameObject>();

    //呼ばれた名前のPrefabを呼び出す
    void Start()
    {
        foreach(var prefabContainer in  _prefabContainers)
        {
            DictionaryRegister(prefabContainer);
        }
        CreatePrefab(PrefabName.DigitalClock,_parentCanvasTransform);
    }

    //ディクショナリーに登録する
    private void DictionaryRegister(PrefabContainer value)
    {
        _prefabContainersDictionary.Add(value.PrefabName,value);
    }

    //Prefabを生成しCanvasの子オブジェクトにする
    public void CreatePrefab(PrefabName key,Transform parentTransform)
    {
        var value = _prefabContainersDictionary[key];
        var createPrefab = Instantiate(value.Prefab,parentTransform);
        _existPrefabContainersDictionary.Add(value.PrefabName,createPrefab);
        _nowLevel = value.PrefabName;
    }

    //ディクショナリーから既存のオブジェクトを破棄する
    public void DestroyPrefab()
    {
        var  prefab = _existPrefabContainersDictionary[_nowLevel];
        Destroy(prefab);
    }
}

//独自クラスでプレハブを管理する
[System.Serializable]
public class PrefabContainer
{
    public PrefabName PrefabName;
    public GameObject Prefab;
}
