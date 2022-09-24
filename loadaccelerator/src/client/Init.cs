using LogicAPI.Client;
using LogicWorld.Rendering.Colliders;
using LogicLog;
using HarmonyLib;
using System;
using UnityEngine;
using System.Collections.Generic;
using System.Reflection;
namespace loadaccelerator {
	public class Patcher : ClientMod {
		protected override void Initialize() {
			var harmony = new Harmony("loadaccelerator");
			harmony.PatchAll();
		}
	}
}

[HarmonyPatch]
class PatchPool {
  	static IEnumerable<MethodBase> TargetMethods() {
  		var method = typeof(ColliderPool).GetMethod("GetCollider", BindingFlags.NonPublic | BindingFlags.Static);
    	yield return method.MakeGenericMethod(typeof(BoxCollider));
    	yield return method.MakeGenericMethod(typeof(CapsuleCollider));
    	yield return method.MakeGenericMethod(typeof(MeshCollider));
    	yield return method.MakeGenericMethod(typeof(SphereCollider));
  	}

  	static void Postfix(ref Collider __result) {
        __result.enabled = false;
    }
}

[HarmonyPatch(typeof(ColliderPool))]
[HarmonyPatch("GetBox")]
[HarmonyPatch(new Type[] { typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Transform), typeof(Vector3) })]
class PatchBox {
  	static void Postfix(ref Collider __result) {
        __result.enabled = true;
    }
}

[HarmonyPatch(typeof(ColliderPool))]
[HarmonyPatch("GetCapsule")]
[HarmonyPatch(new Type[] { typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Transform), typeof(Vector3), typeof(float), typeof(float) })]
class PatchCapsule {
  	static void Postfix(ref Collider __result) {
        __result.enabled = true;
    }
}

[HarmonyPatch(typeof(ColliderPool))]
[HarmonyPatch("GetMesh")]
[HarmonyPatch(new Type[] { typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Transform), typeof(Mesh) })]
class PatchMesh {
  	static void Postfix(ref Collider __result) {
        __result.enabled = true;
    }
}

[HarmonyPatch(typeof(ColliderPool))]
[HarmonyPatch("GetSphere")]
[HarmonyPatch(new Type[] { typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Transform), typeof(Vector3), typeof(float) })]
class PatchSphere {
  	static void Postfix(ref Collider __result) {
        __result.enabled = true;
    }
}
