using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes
{

    public string info {get; private set;}
    
  void Awake() {
            shape = "Cube";
            name = "Rony" ;
            info = "this is a very useless cube. it does literally nothing";
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
