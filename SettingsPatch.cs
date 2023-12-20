using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    public class SettingsPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Settings), nameof(Settings.outputModeIsFramed), MethodType.Getter)]
        public static bool Prefix_BufferW_Get(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}