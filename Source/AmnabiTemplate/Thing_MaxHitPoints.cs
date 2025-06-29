using HarmonyLib;
using RimWorld;
using Verse;

namespace Amnabi;

[HarmonyPatch(typeof(Thing), nameof(Thing.MaxHitPoints), MethodType.Getter)]
public static class Thing_MaxHitPoints
{
    public static void Postfix(Thing __instance, ref int __result)
    {
        if (!__instance.def.IsWeapon && !__instance.def.IsApparel)
        {
            return;
        }

        var qualityComp = __instance.TryGetComp<CompQuality>();
        if (qualityComp != null)
        {
            __result = (int)(__result * Harmony_QualityAndDurability.AdjustSwitch(qualityComp.Quality));
        }
    }
}