namespace CohesionAndCoupling.Dimentions
{
    public static class FunctionsFor3D
    {
        public static double CalculateVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double GetShapeDiagonalXYZ(double width, double height, double depth)
        {
            double distance = DistanceCalculators.Distance3D(0, 0, 0, width, height, depth);
            return distance;
        }
    }
}
