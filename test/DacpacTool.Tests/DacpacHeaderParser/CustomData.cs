﻿using System.Collections.Generic;
using System.Linq;

namespace MSBuild.Sdk.SqlProj.DacpacTool.Tests.DacpacHeaderParser
{
    public class CustomData
    {
        private readonly Dictionary<string, Metadata> _items = new Dictionary<string, Metadata>();
        public readonly string Category;
        public readonly string Type;

        public CustomData(string category, string type)
        {
            Category = category;
            Type = type;
        }

        public List<Metadata> Items
        {
            get { return _items.Values.ToList(); }
        }

        public void AddMetadata(string name, string value)
        {
            _items[name] = new Metadata(name, value);
        }
    }
}