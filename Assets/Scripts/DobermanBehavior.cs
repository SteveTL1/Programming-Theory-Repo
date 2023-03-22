using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobermanBehavior : MainDogBehavior
{
    public override void Awake()
    {              
        MainSceneUIManager.Instance.dogNameText.gameObject.SetActive(true);
        base.Awake();
    }

    protected override string DogRace()
    {
        return "Doberman";
    }

    public override string DogName()
    {
        return "Lucky";
    }

}
