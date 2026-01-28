using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Demo
{
    public interface IPolygon
    {
        int NumberOfSides { get; }
        double GetAngleOfCorners();
    }
}
