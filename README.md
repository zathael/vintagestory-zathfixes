## Zathfixes
===
These fixes are intended to be used with a particular 100+ mod server configuration, and modify the base game.

If you are using a modpack that does not use any of these mods, the individual mod patches will throw an exception during server load, but can be ignored.

### Vanilla Chisel Recovery Reduction
- Metal Plates now return 20 bits instead of 40
- Most metal recovery recipes with Chisels now return 10 bits.

### CombatOverhaul Changes
- Bears have been reduced from tiers (4, 5, 4, 4, 5) to (2, 3, 2, 2, 3) to be in line with base-game
- This patch WILL FAIL if you do not have [Combat Overhaul](https://mods.vintagestory.at/combatoverhaul), but is not destructive if you lack it.

### Rust Magic Changes
- Elemental Sentries damage has been reduced from 3.5 to 2.5, to be in line with other damage reduction changes
- This patch WILL FAIL if you do not have [Rustbound Magic](https://mods.vintagestory.at/rustboundmagic), but it is not destructive if you lack it.

### Vintage Engineering Changes
- Metal Press now requires 2 INGOTS to make plates.
	- This is thanks to a discovered exploit within vanilla+vintage-engineering. 
	- You will need to pre-stack the heated ingots 