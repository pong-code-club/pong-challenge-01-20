using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public Transform MyTransform;
    public float MySpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MySpeed = 4.5f;
        MyTransform = GetComponent<Transform>();
        //MyTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {

        //multiply by Time.deltaTime to move per second vs per frame
        //MyTransform.Translate(1 * Time.deltaTime,0,0);

        //skeleton of if statement
        if (true)
        {

        }

        //Time.deltaTime and Input.GetKey are static functions
        //Debug.Log(Input.GetKey(KeyCode.RightArrow));

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyTransform.Translate(MySpeed * Time.deltaTime, 0, 0);
        }

        //change this to move paddle left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //change this to move paddle left
            MyTransform.Translate(-MySpeed * Time.deltaTime, 0, 0);
        }
    }
}
