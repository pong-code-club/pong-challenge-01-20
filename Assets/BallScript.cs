using UnityEngine;

public class BallScript : MonoBehaviour
{
    //declaring variable
    //[public or private]_[data type]_[identifier]
    public int MyScore;

    public Rigidbody MyRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //function declaration
    void Start()
    {
        //initializing variables
        //assigning value to variable
        MyScore = 10;
        //use GetComponent to grab the reference to a component
        MyRigidbody = GetComponent<Rigidbody>();

        //Dot notation
        MyRigidbody.useGravity = false;
        //Calling a function
        MyRigidbody.AddForce(300, 300, 0);

        //Physics.gravity = new Vector3(0, 9.81f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
