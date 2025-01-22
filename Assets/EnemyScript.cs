using UnityEngine;

//declaring EnemyScript class
//this is just a template and does NOT do anything
//until you add it as a component to a game object
public class EnemyScript : MonoBehaviour
{
    //4 main ideas of code
    //variables - data or things you need to keep track
    //     - data types: numbers, strings, boolean, objects
    //     - health, damage, reference the hitbox, name, points, movement speed
    //functions - instructions/recipes
    //     - move(), run(), jump(), attack(), die()
    //classes - classes are containers for related variables and functions
    //control flow/conditional logic - if else statements
    //     - if it is raining I will bring an umbrella
    //     - if health is 0, then enemy should die
    //operators - ways to change data
    //     - comparison: <=, >=, ==
    //     - math operations: + - * /
    //     - assignment operator: =
    //          - health = 100

    //declared variables
    //primitive data types
    //declaring primitive data type variables
    public int MyHealth;
    public string MyName;
    public float MySpeed;
    public bool MyIsGrounded;

    //declaring reference data type variables
    public Transform MyTransform;
    public Rigidbody MyRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //declaring a function/function declaration
    //Start life cycle method (function)
    void Start()
    {
        MyTransform.localScale = new Vector3(MyHealth, MyHealth, MyHealth); 
    }

    //Update is called once per frame
    //Update life cycle method (function)
    void Update()
    {
        //MyTransform.Translate(0,0.01f,0);
    }

    private void OnMouseDown()
    {
        MyHealth = MyHealth - 1;
        MyTransform.localScale = new Vector3(MyHealth, MyHealth, MyHealth);
    }

    //declaring function
    void Attack()
    {

    }

    void Run()
    {

    }

    void Walk()
    {

    }
}
