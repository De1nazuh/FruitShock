using UnityEngine;

namespace Project
{
    public class Bomb : ItemBase
    {
        public override void OnCatch()
        {
            base.OnCatch();
            Debug.Log("-1 score");
            score=score-2.5f;
        }


    }
}
