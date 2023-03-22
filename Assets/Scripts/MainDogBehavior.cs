using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainDogBehavior : MonoBehaviour
{
    // ENCAPSULATION
    private float d_speed = 5.0f;
    public float Speed
    {
        get { return d_speed; }
        set
        {
            if (value < 5.0f || value > 20.0f)
            {
                Debug.LogError("You can´t set a Speed below 1.0 or above 20.0f");
            }
            else
            {
                d_speed = value;
            }
        }
    }
    // ENCAPSULATION
    private float d_jumpForce = 5.0f;
    public float JumpForce
    {
        get { return d_jumpForce; }
        set
        {
            if (value < 5.0f || value > 10.0f)
            {
                Debug.LogError("You can´t set s JumpForce below 5.0f or above 10.0f");
            }
            else
            {
                d_jumpForce = value;
            }
        }
    }
    private Rigidbody dogRb;
    private bool onGround;


    public virtual void Awake()
    {       
        onGround = true;
    }

    private void Start()
    {
        dogRb = GetComponent<Rigidbody>();        
        MainSceneUIManager.Instance.ChangeRace(DogRace());
        MainSceneUIManager.Instance.ChangeName(DogName());
        MainSceneUIManager.Instance.OnAwakeChangeUI();       
    }
    // ABSTRACTION
    private void Update()
    {
        MoveDog();
    }
    // ABSTRACTION
    protected void MoveDog()
    {
        transform.Translate(Vector3.forward * CalculateDogForwardBackward());
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            CalculateDogJump();
        }
    }

    // ABSTRACTION
    protected float CalculateDogForwardBackward()
    {
       
        float verticalInput = Input.GetAxis("Vertical") * d_speed * Time.deltaTime;
        return verticalInput;
    }
    // ABSTRACTION
    protected private void CalculateDogJump()
    {
        onGround = false;
        dogRb.AddForce(Vector3.up * d_jumpForce, ForceMode.Impulse);
    }
    // POLYMORPHISM
    protected abstract string DogRace();
    // POLYMORPHISM
    public virtual string DogName()
    {  
    return "";
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }           
    }

}
