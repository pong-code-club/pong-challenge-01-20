using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody MyRidgidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyRidgidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ControlCharacter();
        int blah;
        blah = 5;
        blah++;
        blah--;
    }

    public void ControlCharacter()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyRidgidbody.MovePosition(transform.position + new Vector3(0,0,5 * Time.deltaTime));
        }
    }
}
