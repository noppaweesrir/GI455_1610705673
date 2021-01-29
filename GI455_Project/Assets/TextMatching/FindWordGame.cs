using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindWordGame : MonoBehaviour
{
    public Text messageText;
    public InputField findInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartFind()
    {
        string findwordString = findInput.text;
        if (findwordString == "Candy")
        {
            messageText.text = "[ <color=Green>Candy</color> ] is found ";
        }
        if(findwordString == "Notebook")
        {
            messageText.text = "[ <color=Green>Notebook</color> ] is found ";
        }
        if (findwordString == "Nintendo")
        {
            messageText.text = "[ <color=Green>Nintendo</color> ] is found ";
        }
        if (findwordString == "Xbox")
        {
            messageText.text = "[ <color=Green>Xbox</color> ] is found ";
        }
        if (findwordString == "Playstation")
        {
            messageText.text = "[ <color=Green>Playstation</color> ] is found ";
        }
    }
}
