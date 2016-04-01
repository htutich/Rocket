﻿using Rocket.Core.Assets;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace Rocket.Core.Serialization
{
    public sealed class RemoteConsole
    {
        [XmlAttribute]
        public bool Enabled = false;
        [XmlAttribute]
        public ushort Port = 27115;
        [XmlAttribute]
        public string Password = "changeme";
    }

    public sealed class AutomaticShutdown
    {
        [XmlAttribute]
        public bool Enabled = false;
        [XmlAttribute]
        public int Interval = 86400;
    }

    public sealed class WebPermissions
    {
        [XmlAttribute]
        public bool Enabled = false;
        [XmlAttribute]
        public string Url = "";
        [XmlAttribute]
        public int Interval = 180;
    }

    public sealed class WebConfigurations
    {
        [XmlAttribute]
        public bool Enabled = false;
        [XmlAttribute]  
        public string Url = "";
    }

    public sealed class CommandMapping
    {
        [XmlAttribute]
        public string Name = "";

        [XmlAttribute]
        public bool Enabled = true;

        [XmlText]
        public string Class = "";
        public CommandMapping()
        {

        }
        public CommandMapping(string name,bool enabled,string @class)
        {
            Name = name;
            Enabled = enabled;
            Class = @class;
        }
    }

    public sealed class RocketSettings : IDefaultable
    {
        [XmlElement("RCON")]
        public RemoteConsole RCON = new RemoteConsole();

        [XmlElement("AutomaticShutdown")]
        public AutomaticShutdown AutomaticShutdown = new AutomaticShutdown();

        [XmlElement("WebConfigurations")]
        public WebConfigurations WebConfigurations = new WebConfigurations();

        [XmlElement("WebPermissions")]
        public WebPermissions WebPermissions = new WebPermissions();

        [XmlElement("LanguageCode")]
        public string LanguageCode = "en";

        [XmlElement("MaxFrames")]
        public int MaxFrames = 60;
        
        public void LoadDefaults()
        {
            RCON = new RemoteConsole();
            AutomaticShutdown = new AutomaticShutdown();
            WebConfigurations = new WebConfigurations();
            WebPermissions = new WebPermissions();
            LanguageCode = "en";
            MaxFrames = 60;
        }
    }
}