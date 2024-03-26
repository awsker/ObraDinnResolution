using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    public class IntroPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Intro), "Start")]
        public static void Prefix_Start()
        {
            // low res starting the game intro so it's full screen
            Plugin.IsHighRes = false;
        }

    }
}