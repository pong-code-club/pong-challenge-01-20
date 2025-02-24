using UnityEngine;
//declare enum data type with identifier "WeaponType"
public enum WeaponType
{
    None = 0,
    Axe = 1,
    Sword = 2,
    Whip = 3
}

public class CodingExampleScript : MonoBehaviour
{
    //public CodingExampleScript MyCodingExampleScript;
    public WeaponType MyWeaponType;

    //declaring an array
    public int[] MyIntArray;
    public Transform[] MyTransformArray;

    //declaring vector3 data type variable with identifier/name "MyVector3"
    public Vector3 MyVector3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assigning a value to my MyWeaponType variable
        MyWeaponType = WeaponType.Sword;
        //assigning value to MyVector3
        //have to use "new" keyword
        MyVector3 = new Vector3(5, 5, 5);
        //for loop
        //[for] [(] [int i = 0]; [number you want to count up to]; [i++]
        //for loop example
        for (int i = 0; i < MyIntArray.Length; i++)
        {
            Debug.Log(MyIntArray[i]);     
        }

        for (int i = 0; i < MyTransformArray.Length; i++)
        {
            MyTransformArray[i].Translate(0, 1, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < MyTransformArray.Length; i++)
        {
            MyTransformArray[i].Translate(0, 1 * Time.deltaTime, 0);
        }
    }
}
