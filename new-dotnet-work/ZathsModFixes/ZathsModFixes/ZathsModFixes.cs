using HarmonyLib;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace ZathsModFixes
{
    public class ZathsModFixes : ModSystem
    {
        private Harmony harmony;
        public static ICoreAPI API;
        

        // Exposes the API to all methods and gets Harmony ready to patch
        public override void Start(ICoreAPI api)
        {
            API = api;
            if (!Harmony.HasAnyPatches(Mod.Info.ModID))
            {
                harmony = new Harmony(Mod.Info.ModID);
                harmony.PatchAll();
                api.Logger.Notification("ZathsModFixes: Harmony patches applied.");
            }
        }

        // Handles order in which things occur at each server stage. 1.0 is when recipes are modified.
        // Likely, you need to modify recipe values BEFORE anything is loaded into a config.
        // This is why metalbit.json is a JSON Patch instead of a Harmony patch.
        public override double ExecuteOrder() => 1.0;

        // Runs anything we need during the AssetsLoaded phase.
        // Likely if we do need to run something down the line it will be during the WorldLoaded phase.
        public override void AssetsLoaded(ICoreAPI api)
        {
            
        }

        public override void Dispose()
        {
            harmony?.UnpatchAll(Mod.Info.ModID);
        }
    }
}
