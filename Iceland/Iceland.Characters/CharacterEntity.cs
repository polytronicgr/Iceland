﻿using System;
using GameplayKit;

using Iceland.Map;
using Iceland.Conversation;

namespace Iceland.Characters
{
    public class CharacterEntity : GKEntity
    {
        public Map.Map.Position CurrentPosition { get; set; }
        public Map.Map Map { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

