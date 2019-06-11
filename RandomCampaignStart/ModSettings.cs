using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using BattleTech;
using Harmony;
using Newtonsoft.Json;
using System.Linq;

namespace RandomCampaignStart
{
    public class ModSettings
    {
        public List<string> StartingRonin = new List<string>();
        public int NumberRoninFromList = 4;

        public int NumberProceduralPilots = 0;
        public int NumberRandomRonin = 4;

        public bool RemoveAncestralMech = false;
        public bool IgnoreAncestralMech = true;

        public string ModDirectory = string.Empty;
        public bool Debug = false;
    }
}
