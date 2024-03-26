using HarmonyLib;

namespace ResolutionFix
{
    [HarmonyPatch]
    public class BookPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Book), "OnEnable")]
        public static void Prefix_OnEnable()
        {
            // low res when opening the book
            Plugin.IsHighRes = false;
        }

        [HarmonyPrefix]
        [HarmonyPatch(typeof(Book), "OnDisable")]
        public static void Prefix_OnDisable()
        {
            Plugin.IsHighRes = true;
        }
    }
}