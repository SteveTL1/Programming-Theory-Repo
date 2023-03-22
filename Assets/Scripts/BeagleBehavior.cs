using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BeagleBehavior : MainDogBehavior
{
    // POLYMORPHISM
    public override void Awake()
    {
        Speed = 10.0f;
        JumpForce = 10.0f;
        MainSceneUIManager.Instance.dogNameText.gameObject.SetActive(false);
        base.Awake();       
    }

    // POLYMORPHISM
    protected override string DogRace()
    {
        return "Beagle";
    }

}
