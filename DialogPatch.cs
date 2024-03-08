using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    public class DialogPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Dialog), "Play")]
        public static void Prefix_Play()
        {
            Plugin.IsHighRes = false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Dialog), "Stop")]
        public static void Prefix_Stop()
        {
            Plugin.IsHighRes = true;
        }
    }
}