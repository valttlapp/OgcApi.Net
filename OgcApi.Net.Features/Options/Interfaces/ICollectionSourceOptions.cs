﻿using System.Collections.Generic;

namespace OgcApi.Net.Features.Options.Interfaces
{
    public interface ICollectionSourceOptions
    {
        public string Type { get; set; }
        public string GeometryGeoJsonType { get; set; }
        public List<string> Properties { get; set; }

        public bool AllowCreate { get; set; }

        public bool AllowReplace { get; set; }

        public bool AllowUpdate { get; set; }

        public bool AllowDelete { get; set; }

    }
}
