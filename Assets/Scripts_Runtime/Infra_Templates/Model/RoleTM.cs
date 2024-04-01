using System;
using UnityEngine;

namespace Scaffold {

    [CreateAssetMenu(fileName = "SO_Role", menuName = "Scaffold/RoleTM")]
    public class RoleTM : ScriptableObject {

        public int typeID;
        public AllyStatus allyStatus;
        public AIType aiType;

        public float moveSpeed;

        public Sprite mesh;
    }

}