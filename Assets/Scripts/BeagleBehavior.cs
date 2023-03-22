using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeagleBehavior : MainDogBehavior
{
    public override void Awake()
    {
        Speed = 10.0f;
        JumpForce = 10.0f;
        MainSceneUIManager.Instance.dogNameText.gameObject.SetActive(false);
        base.Awake();
    }

    protected override string DogRace()
    {
        return "Beagle";
    }

}
