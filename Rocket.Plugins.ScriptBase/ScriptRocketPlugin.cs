﻿using Rocket.API;
using Rocket.API.Plugins;
using Rocket.API.Serialisation;
using Rocket.Plugins.Native;

namespace Rocket.Plugins.ScriptBase
{
    /// <summary>
    /// <p>The RocketPluginBase for a scripting implementation</p>
    /// <p>To be implemented by the script implementation.</p>
    /// </summary>
    public class ScriptRocketPlugin : RocketPluginBase
    {
        public void Awake()
        {
            Name = PluginMeta.Name;
            PluginManager = ScriptPluginProvider;
            base.Initialize();
        }

        public ScriptRocketPluginProvider ScriptPluginProvider => ScriptContext.ScriptEngine.PluginProvider;
        public IScriptContext ScriptContext { get; set; }
        public ScriptPluginMeta PluginMeta { get; set; }
    }

    /// <summary>
    /// <p>The RocketPluginBase with configuration for a scripting implementation</p>
    /// <p>To be implemented by the script implementation.</p>
    /// </summary>
    public class ScriptRocketPlugin<RocketPluginConfiguration> : RocketPluginBase<RocketPluginConfiguration> where RocketPluginConfiguration : class, IRocketPluginConfiguration
    {
        public void Awake()
        {
            Name = PluginMeta.Name;
            PluginManager = ScriptPluginProvider;
            base.Initialize();
        }

        public ScriptRocketPluginProvider ScriptPluginProvider => ScriptContext.ScriptEngine.PluginProvider;
        public IScriptContext ScriptContext { get; set; }
        public ScriptPluginMeta PluginMeta { get; set; }
    }
}