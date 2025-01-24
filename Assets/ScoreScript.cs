using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    //varialbe declaration
    //[public or private] [data type] [identifier/name of variable]
    public TextMeshProUGUI MyScoreUI;
    public int MyScoreAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyScoreAmount = 0;
        MyScoreUI = GetComponent<TextMeshProUGUI>();

        //MyScoreUI.text = "Hello There " + MyScoreAmount;
    }

    // Update is called once per frame
    //function declaration
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //increment up score by 1
            //multiline comment
            /*
            MyScoreAmount = MyScoreAmount + 1;
            //short cut
            //MyScoreAmount += 1;
            //update the text field
            MyScoreUI.text = "Score: " + MyScoreAmount;
            */

            //calling function
            AddToScore();
        }
    }

    //function declaration
    //[public or private] [void OR return data type] [identifier/name] [(] [data type] [identifier] [)] [{] Code to execture goes here [}]
    public void AddToScore()
    {
        //code goes in here
        //increment up score by 1
        MyScoreAmount = MyScoreAmount + 1;
        //short cut
        //MyScoreAmount += 1;
        //update the text field
        MyScoreUI.text = "Score: " + MyScoreAmount;
    }

    //function declaration that takes in two parameters and returns an int
    public int AddTwoNumber(int num1, int num2)
    {
        //declaring a local variable, notice you do not need public or private keyword
        //sumOfTwoNumbers is only accessible from inside this function
        int sumOfTwoNumbers = num1 + num2;
        return sumOfTwoNumbers;
    }
}
