using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    internal class OneBitPatch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(OneBit), "OnEnable")]
        public static void Postfix_OnEnable(OneBit __instance)
        {
            __instance.linedSettings.distortFringe = false;
        }
    }
}