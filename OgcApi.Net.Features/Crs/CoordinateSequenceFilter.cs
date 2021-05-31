﻿using NetTopologySuite.Geometries;
using ProjNet.CoordinateSystems.Transformations;

namespace OgcApi.Net.Features.Crs
{
    class CoordinateSequenceFilter : ICoordinateSequenceFilter
    {
        private readonly MathTransform _mathTransform;

        public CoordinateSequenceFilter(MathTransform mathTransform) => _mathTransform = mathTransform;

        public bool Done => false;

        public bool GeometryChanged => true;

        public void Filter(CoordinateSequence seq, int i)
        {
            double x = seq.GetX(i);
            double y = seq.GetY(i);
            double z = seq.GetZ(i);
            _mathTransform.Transform(ref x, ref y, ref z);
            seq.SetX(i, x);
            seq.SetY(i, y);
            seq.SetZ(i, z);
        }
    }
}
