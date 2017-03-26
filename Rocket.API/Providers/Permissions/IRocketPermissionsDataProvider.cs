﻿using Rocket.API.Commands;
using Rocket.API.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using Rocket.API.Player;

namespace Rocket.API.Providers.Permissions
{
    [RocketProvider]
    public interface IRocketPermissionsDataProvider : IRocketDataProviderBase
    {
            List<RocketPermissionsGroup> GetGroups(IRocketPlayer player);

            List<string> GetPermissions(IRocketPlayer player);

            RocketPermissionsGroup GetGroup(string groupId);

            bool AddGroup(RocketPermissionsGroup group);

            bool SaveGroup(RocketPermissionsGroup group);

            bool DeleteGroup(RocketPermissionsGroup group);
        }
    }