using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum HoleNumber
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine
}
public class MonsterControl : MonoBehaviour
{
    private HoleNumber hole;
    private Vector3 tempPos;
    private Transform parentTrans;

    public HoleNumber GetHole
    {
        set { hole = value; }
        get { return hole; }
    }

    public Transform GetParent
    {
        set { parentTrans = value; }
        get { return parentTrans; }
    }
    // Start is called before the first frame update
    void Start()
    {
        SetPosition(hole);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetPosition(HoleNumber hole)
    {
        switch(hole)
        {
            case HoleNumber.One:
                tempPos = new Vector3(335,780,-656);
                break;
            case HoleNumber.Two:
                tempPos = new Vector3(550, 780, -656);
                break;
            case HoleNumber.Three:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Four:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Five:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Six:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Seven:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Eight:
                tempPos = new Vector3(335, 780, -656);
                break;
            case HoleNumber.Nine:
                tempPos = new Vector3(335, 780, -656);
                break;
        }
    }
}
