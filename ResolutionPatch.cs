using HarmonyLib;
using UnityEngine;

namespace ResolutionFix
{
    [HarmonyPatch]
    public class ResolutionPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Resolution), nameof(Resolution.bufferW), MethodType.Getter)]
        public static bool Prefix_BufferW_Get(ref int __result)
        {
            __result = Screen.width;
            return false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Resolution), nameof(Resolution.bufferH), MethodType.Getter)]
        public static bool Prefix_BufferH_Get(ref int __result)
        {
            __result = Screen.height;
            return false;
        }
    }
}