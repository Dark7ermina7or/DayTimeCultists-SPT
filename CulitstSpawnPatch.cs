using System.Reflection;
using SPT.Reflection.Patching;

namespace DayTimeCultists
{
    class CulitstSpawnPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return typeof(ZoneLeaveControllerClass).GetMethod("IsDayByHour");
        }
        [PatchPrefix]
        private static bool PatchPrefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
