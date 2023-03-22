using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainDogBehavior : MonoBehaviour
{
    private float d_speed = 5.0f;
    public float Speed
    {
        get { return d_speed; }
        set
        {
            if (value < 5.0f)
            {
                Debug.LogError("You can´t set a Speed below 1.0");
            }
            else
            {
                d_speed = value;
            }
        }
    }
    private float d_jumpForce = 5.0f;
    public float JumpForce
    {
        get { return d_jumpForce; }
        set
        {
            if (value < 5.0f)
            {
                Debug.LogError("You can´t set s JumpForce below 10.0f");
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

    private void Update()
    {
        MoveDog();
    }

    protected void MoveDog()
    {
        transform.Translate(Vector3.forward * CalculateDogForwardBackward());
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            CalculateDogJump();
        }
    }


    protected float CalculateDogForwardBackward()
    {
       
        float verticalInput = Input.GetAxis("Vertical") * d_speed * Time.deltaTime;
        return verticalInput;
    }

    protected private void CalculateDogJump()
    {
        onGround = false;
        dogRb.AddForce(Vector3.up * d_jumpForce, ForceMode.Impulse);
    }

    protected abstract string DogRace();

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
