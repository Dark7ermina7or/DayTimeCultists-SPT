using System;
using BepInEx;

namespace DayTimeCultists
{
    [BepInPlugin("com.DayTimeCultists", "DayTimeCultists", "1.2.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new CulitstSpawnPatch().Enable();
            Logger.LogDebug("DayTimeCultists is enabled");
        }
    }
}
