using System.Reflection.Metadata.Ecma335;

namespace C__OOP_HW006_class_inherit_r00
{
    internal class SpaceObject
    {
        private static int _generator;
        public int id { get; }
        public DataObject? data { get; set; }
        public Material? material { get; set; }
        public Point3D? point3D { get; set; }
        public VectorPoint3D? vector { get; set; }

        static SpaceObject()
        {
            _generator = 0;
        }

        //public SpaceObject() : this(new DataObject(), new Material(), new VectorPoint3D()) { }

        public SpaceObject() : this(null, null, null, null) { }

        public SpaceObject(in DataObject data, in Material material) : this(data, material, null, null) { }

        public SpaceObject(in DataObject? data, in Material? material, in Point3D? point3D, in VectorPoint3D? vector)
        {
            id = ++_generator;
            this.data = data;
            this.material = material;
            this.point3D = point3D;
            this.vector = vector;
        }

        public string GetInfo()
        {
            return $"id - {id}" +
                $"\n\t dates: {(data != null ? data.GetInfo() : 0)}" +
                $"\n\t point3D: {(point3D != null ? point3D.ToString() : 0)}" +
                $"\n\tmaterial: {(material != null ? material.GetInfo() : 0)}" +
                $"\n\tvector: {(vector != null ? vector.ToString() : 0)}";
        }
    }
}
