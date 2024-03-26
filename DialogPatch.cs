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
            // low res while dialogue text is showing
            Plugin.IsHighRes = false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Dialog), "Stop")]
        public static void Prefix_Stop()
        {
            Plugin.IsHighRes = true;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Dialog), "SwitchToAudioOnly")]
        public static void Prefix_SwitchToAudioOnly()
        {
            // high res if user skips audio
            Plugin.IsHighRes = true;
        }

    }
}