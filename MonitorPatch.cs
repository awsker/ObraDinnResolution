using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    internal class MonitorPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Monitor), "OnEnable")]
        public static void Postfix_OnEnable(Monitor __instance)
        {
            __instance.blurAtEdges = false;
            __instance.borderTexture = null;
        }
    }
}
