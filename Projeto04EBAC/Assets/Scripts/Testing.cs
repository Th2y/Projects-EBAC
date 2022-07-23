using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Animals animal = Animals.None;

    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeAnimal(Animals.Cat);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ChangeAnimal(Animals.Dog);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeAnimal(Animals.Fish);
        }
    }

    private void ChangeAnimal(Animals newAnimal)
    {
        animal = newAnimal;
        CheckAnimal();
    }

    private void CheckAnimal()
    {
        switch (animal)
        {
            case Animals.Cat:
                AnimalCat();
                break;
            case Animals.Dog:
                AnimalDog();
                break;
            case Animals.Fish:
                AnimalFish();
                break;
            default:
                DebugActualAnimal();
                break;
        }
    }

    private void DebugActualAnimal()
    {
        Debug.Log(animal);
    }

    private void AnimalCat()
    {
        DebugActualAnimal();
    }

    private void AnimalDog()
    {
        DebugActualAnimal();
    }

    private void AnimalFish()
    {
        DebugActualAnimal();
    }
}

public enum Animals
{
    Cat,
    Dog,
    Fish,
    None
}
