using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlText : MonoBehaviour {

    public Text showText;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;

    public string input = "";

	void Start () {
        showText.text = input;
	}
	
	void update()
    {
        showText.text = input;
    }

    public void OnClick() {
        if (input.Length >= 4)
        {
            input = "";
            showText.text = "";
        }
        else
        {
            if (b1.IsActive())
            {
                input += "L";
                showText.text = input;
            }else if (b2.IsActive())
            {
                input += "E";
                showText.text = input;
            }
            else if (b3.IsActive())
            {
                input += "T";
                showText.text = input;
            }
            else if (b4.IsActive())
            {
                input += "F";
                showText.text = input;
            }
        }
        




    }



}
