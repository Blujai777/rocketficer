using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace rocketficer
{


[BepInPlugin("blujai.Rocketficer", "Rocketficer", "0.1.0" )]
    public class Rocketficer : BaseUnityPlugin
    {
    public const string PLUGIN_GUID = "Blujai.rocketficer"; // This should be the same as the id in modinfo.json!
    public const string PLUGIN_NAME = "Rocketficer"; // This should be a human-readable version of your mod's name. This is used for log files and also displaying which mods get loaded. In general, it's a good idea to match this with your modinfo.json as well.
    public const string PLUGIN_VERSION = "0.1.0"; // This follows semantic versioning. For more information, see https://semver.org/ - again, match what you have in modinfo.json
                                                  // It should go without saying, but for this to benefit other modders, the class *and* these const strings must be public.

    public void Onenable()
        {
            On.Player.ClassMechanicsArtificer += Player_ClassMechanicsArtificer;

        }

        private void Player_ClassMechanicsArtificer(On.Player.orig_ClassMechanicsArtificer orig, Player self)
        {
            orig(self);
            self.pyroJumpped = false;
        }
    }
}
