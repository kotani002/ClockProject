using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalNumberView : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _digitalBar = new List<GameObject>();

    public void SetUp()
    {
        for(int i = 0; i < this.transform.parent.childCount-1;i++)
        {
            _digitalBar.Add(this.transform.GetChild(i).gameObject);
        }
    }

    public void ChangeNumber(int num)
    {
        //Debug.Log(num);
        switch(num)
        {
            case 0:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(false);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(true);
            _digitalBar[6].SetActive(true);
            break;

            case 1:
            _digitalBar[0].SetActive(false);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(false);
            _digitalBar[3].SetActive(false);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(false);
            break;

            case 2:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(false);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(false);
            _digitalBar[5].SetActive(true);
            _digitalBar[6].SetActive(true);
            break;

            case 3:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(false);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(true);
            break;

            case 4:
            _digitalBar[0].SetActive(false);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(false);
            break;

            case 5:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(false);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(true);
            break;

            case 6:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(false);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(true);
            _digitalBar[6].SetActive(true);
            break;

            case 7:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(false);
            _digitalBar[3].SetActive(false);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(false);
            break;

            case 8:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(true);
            _digitalBar[6].SetActive(true);
            break;

            case 9:
            _digitalBar[0].SetActive(true);
            _digitalBar[1].SetActive(true);
            _digitalBar[2].SetActive(true);
            _digitalBar[3].SetActive(true);
            _digitalBar[4].SetActive(true);
            _digitalBar[5].SetActive(false);
            _digitalBar[6].SetActive(true);
            break;

            default:

            break;

        }
    }
}
