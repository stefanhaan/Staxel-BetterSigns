﻿using Plukit.Base;
using System;

namespace BetterSigns.Staxel.Rendering
{
    class VectorHelper
    {
        public static Vector3D RotatePosition(uint rotation, Vector3D vec)
        {
            switch (rotation)
            {
                case 0u:
                    return vec;
                case 1u:
                    return new Vector3D(vec.Z, vec.Y, 0.0 - vec.X);
                case 2u:
                    return new Vector3D(0.0 - vec.X, vec.Y, 0.0 - vec.Z);
                case 3u:
                    return new Vector3D(0.0 - vec.Z, vec.Y, vec.X);
                default:
                    throw new Exception();
            }
        }

		public static float GetRotationInRadians(uint rotation)
		{
			return (float)(1.5707963267948966 * (double)rotation);
		}
	}
}