using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Scale_Work : WorkBase
    {
        public override void Work()
        {
            base.Work();
            transform.localScale += Vector3.one;

        }
    }
}