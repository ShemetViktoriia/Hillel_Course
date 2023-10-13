namespace Plugin
{
    internal class PluginManager
    {
        public void LoadPlugin(IPlugin plugin)
        {
            plugin.Execute();
            plugin.Print();
        }
    }
}
