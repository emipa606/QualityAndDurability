using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace Amnabi;

[StaticConstructorOnStartup]
public static class Harmony_QualityAndDurability
{
    static Harmony_QualityAndDurability()
    {
        new Harmony("Amnabi.QualityAndDurability").PatchAll(Assembly.GetExecutingAssembly());
    }

    public static float AdjustSwitch(QualityCategory q)
    {
        switch (q)
        {
            case QualityCategory.Awful:
            {
                return QualityAndDurabilityMod.Instance.Settings.Awful;
            }
            case QualityCategory.Poor:
            {
                return QualityAndDurabilityMod.Instance.Settings.Poor;
            }
            case QualityCategory.Normal:
            {
                return QualityAndDurabilityMod.Instance.Settings.Normal;
            }
            case QualityCategory.Good:
            {
                return QualityAndDurabilityMod.Instance.Settings.Good;
            }
            case QualityCategory.Excellent:
            {
                return QualityAndDurabilityMod.Instance.Settings.Excellent;
            }
            case QualityCategory.Masterwork:
            {
                return QualityAndDurabilityMod.Instance.Settings.Masterwork;
            }
            case QualityCategory.Legendary:
            {
                return QualityAndDurabilityMod.Instance.Settings.Legendary;
            }
        }

        return 1.0f;
    }
}