﻿using Rocket.API.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API.Collections;
using Rocket.API.Providers.Plugins;
using Rocket.API.Serialisation;
using Rocket.Core.Assets;
using Rocket.API.Providers.Translations;

namespace Rocket.Core.Providers.Translation
{
    public class RocketBuiltinTranslationProvider : RocketProviderBase, IRocketTranslationDataProvider
    {
        public override void Load(bool isReload = false)
        {
            throw new NotImplementedException();
        }

        //  Translation = new XMLFileAsset<TranslationList>(String.Format(Environment.TranslationFile, Settings.Instance.LanguageCode), new Type[] { typeof(TranslationList), typeof(TranslationListEntry)



        public void RegisterDefaultTranslations(IRocketPlugin plugin, TranslationList defaultTranslations)
        {
            throw new NotImplementedException();
        }

        public void RegisterDefaultTranslations(TranslationList defaultTranslations)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Translate(string key, string language)
        {
            throw new NotImplementedException();
        }

        public void Translate(IRocketPlugin plugin, string key, string language)
        {
            throw new NotImplementedException();
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
