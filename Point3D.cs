namespace C__OOP_HW006_class_inherit_r00
{
    internal class Point3D
    {
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(in int coordX, in int coordY, in int coordZ)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.coordZ = coordZ;
        }

        public override string ToString()
        {
            return $"{GetType().Name}\nx = {coordX}, y = {coordY}, z = {coordZ}";
        }
    }
}
