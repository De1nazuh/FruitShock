using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Project
{
    public class Fruit : ItemBase
    {
        public override void OnCatch()
        {
            base.OnCatch();
            Debug.Log("+1 score");
            score= score + 0.5f;
            
           // PlaySound(sounds[UnityEngine.Random.Range(0, 1)]);
            
        }


    }
}
