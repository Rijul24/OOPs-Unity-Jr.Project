using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shapes
{
     public string info {get; private set;}
    
  void Awake() {
            shape = "Cylinder";
            name = "Bangles" ;
            info = "most respected cylinder in town";
  }
 void Update()
  {
    DisplayText();
  }

    protected override void DisplayText()
    {
        shapetext.text = "This is " + name + " the " + shape + "\n "+info;
        shapetext.gameObject.SetActive(true);
    }
}
