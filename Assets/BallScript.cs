using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    //reference to the ScoreScript component
    public ScoreScript MyScoreScript;
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

        MyScoreScript = GameObject.Find("ScoreUI").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("hit something");
        //MyScoreScript.AddToScore();
        //checking if colliding with game object with some name
        if (collision.gameObject.name == "Lava")
        {
            Debug.Log("Hit Lava");
            SceneManager.LoadScene("Day4Demo");
        }

        //checking if colliding with game object with a tag
        if (collision.gameObject.tag == "WALL")
        {
            Debug.Log("Hit a Wall");
            Debug.Log("Hit " + collision.gameObject.name);
            MyScoreScript.AddToScore();

            transform.Translate(0, 1, 0, Space.World);
        }

        /*
        if (collision.gameObject.name == "TopWall")
        {
            Debug.Log("Hit TopWall");
        }

        if (collision.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit LeftWall");
        }

        if (collision.gameObject.name == "RightWall")
        {
            Debug.Log("Hit RightWall");
        }
        */
    }
}
