using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GermanShepherdBehavior : MainDogBehavior
{
    // POLYMORPHISM
    public override void Awake()
    {
        Speed = 20.0f;              
        base.Awake();
    }

    // POLYMORPHISM
    protected override string DogRace()
    {
        return "German Shepherd";
    }

    // POLYMORPHISM
    public override string DogName()
    {
        return "Rex";
    }
}
