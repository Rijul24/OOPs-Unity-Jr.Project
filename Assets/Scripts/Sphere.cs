using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere :  Shapes
{
     public string info {get; private set;}
    
  void Awake() {
            shape = "Sphere";
            name = "Jony" ;
            info = "this is a very useless sphere. as you would expect";
  }
 void Update()
  {
    DisplayText();
  }

    protected override void DisplayText()
    {
        shapetext.text = "This is " + name + " the " + shape + " \n "+info;
        shapetext.gameObject.SetActive(true);
    }
}
