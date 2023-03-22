using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermanShepherdBehavior : MainDogBehavior
{
    public override void Awake()
    {
        Speed = 20.0f;       
        MainSceneUIManager.Instance.dogNameText.gameObject.SetActive(true);
        base.Awake();
    }

    protected override string DogRace()
    {
        return "German Shepherd";
    }

    public override string DogName()
    {
        return "Rex";
    }
}
