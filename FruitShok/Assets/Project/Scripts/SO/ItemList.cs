using Project;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu (fileName ="ItemName", menuName = "Configs/ItemList")]

    public class ItemList : ScriptableObject
    {
        public ItemBase[] items;
    }
}
