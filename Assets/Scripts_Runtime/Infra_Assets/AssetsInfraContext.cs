using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Tilemaps;

namespace Scaffold {

    public class AssetsInfraContext {

        Dictionary<string, GameObject> entityDict;
        public AsyncOperationHandle entityHandle;

        public AssetsInfraContext() {
            entityDict = new Dictionary<string, GameObject>();
        }

        // Entity
        public void Entity_Add(string name, GameObject prefab) {
            entityDict.Add(name, prefab);
        }

        bool Entity_TryGet(string name, out GameObject asset) {
            var has = entityDict.TryGetValue(name, out asset);
            return has;
        }

        public GameObject Entity_GetRole() {
            var has = Entity_TryGet("Entity_Role", out var prefab);
            if (!has) {
                GLog.LogError($"Entity Role not found");
            }
            return prefab;
        }

    }

}