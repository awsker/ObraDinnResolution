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
            if (Plugin.IsHighRes)
                __result = Screen.width;
            else
                __result = 800;
            return false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Resolution), nameof(Resolution.bufferH), MethodType.Getter)]
        public static bool Prefix_BufferH_Get(ref int __result)
        {
            if (Plugin.IsHighRes)
                __result = Screen.height;
            else
                __result = 450;
            return false;
        }
    }
}