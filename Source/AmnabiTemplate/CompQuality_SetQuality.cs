using HarmonyLib;
using RimWorld;

namespace Amnabi;

[HarmonyPatch(typeof(CompQuality), nameof(CompQuality.SetQuality))]
public static class CompQuality_SetQuality
{
    public static void Postfix(CompQuality __instance)
    {
        __instance.parent.HitPoints = __instance.parent.MaxHitPoints;
    }
}