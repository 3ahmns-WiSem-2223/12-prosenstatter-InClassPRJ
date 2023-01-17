using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetManager : MonoBehaviour
{
    public Text Score;
    private int counter;

    private void Start()
    {
       gameObject.transform.position = Random.insideUnitCircle * 5;
        Score.text = "Score: " + counter;
    }
    private void OnMouseDown()
    {
        
       gameObject.transform.position = Random.insideUnitCircle * 5;
        counter = counter + 1;
        Score.text = "Score: " + counter;


    }

}
