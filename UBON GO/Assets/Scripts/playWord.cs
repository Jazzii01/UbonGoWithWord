using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playWord : MonoBehaviour {

    public Text showText;

    public string str = "";

    void Start () {
        
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            string s = showText.text;
            if (s.Length>4)
            {
                showText.text = "";
            }
            else
            {
                showText.text += str;
            }
            
        }
    }
	
	


    
}
