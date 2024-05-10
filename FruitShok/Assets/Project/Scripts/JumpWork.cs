using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class JumpWork : WorkBase
    {
        public override void Work()
        {
            
            transform.position += Vector3.up;

        }

    }

}

