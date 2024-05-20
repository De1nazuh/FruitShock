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
            count++;
        }


    }
}
