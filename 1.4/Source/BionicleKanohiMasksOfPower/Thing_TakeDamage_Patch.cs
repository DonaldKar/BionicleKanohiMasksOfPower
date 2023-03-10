using HarmonyLib;
using Verse;

namespace BionicleKanohiMasksOfPower
{
    [HarmonyPatch(typeof(Thing), "TakeDamage")]
	public static class Thing_TakeDamage_Patch//kaukau sos2 patch + universum
	{
		public static bool Prefix(Thing __instance, DamageInfo dinfo)
		{
			if (__instance is Pawn pawn && pawn.Wears(BionicleDefOf.BKMOP_Kaukau, out var apparel) && apparel.IsMasterworkOrLegendary() && (dinfo.Def?.defName == "VacuumDamage"|| dinfo.Def?.defName == "Universum_Decompression_Damage"))
            {
				return false;
			}
			return true;
		}
	}
}