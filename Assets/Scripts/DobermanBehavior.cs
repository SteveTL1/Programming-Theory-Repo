using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class DobermanBehavior : MainDogBehavior
{   
    // POLYMORPHISM
    protected override string DogRace()
    {
        return "Doberman";
    }

    // POLYMORPHISM
    public override string DogName()
    {
        return "Lucky";
    }

}
