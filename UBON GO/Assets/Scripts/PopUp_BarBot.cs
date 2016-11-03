using UnityEngine;
using System.Collections;

public class PopUp_BarBot : MonoBehaviour {

    public float speed;



    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.GetTouch(0).position);
        }
        
        //transform.Translate(0, speed * Time.deltaTime, 0);
	}
}
