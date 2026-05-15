using BepInEx;

namespace CXS
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        // Put this snippet of code in your BaseUnityPlugin
        void Start() => CXS.LoadCXS();
    }
}
