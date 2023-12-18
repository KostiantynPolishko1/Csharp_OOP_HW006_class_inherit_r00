using System.Reflection.Metadata.Ecma335;

namespace C__OOP_HW006_class_inherit_r00
{
    public class SpaceObject
    {
        private static int _generator;
        public int id { get; }
        public DataObject? data { get; set; }
        public Material? material { get; set; }
        public Point3D? point3D { get; set; }
        public VectorPoint3D? vector { get; set; }
        public OrbitAuxData? orbit { get;}

        static SpaceObject()
        {
            _generator = 0;
        }
        public SpaceObject() : this(null, null, null, null) { }

        public SpaceObject(in DataObject data, in Material material) : this(data, material, null, null) { }

        public SpaceObject(in DataObject? data, in Material? material, in Point3D? point3D, in VectorPoint3D? vector)
        {
            id = ++_generator;
            this.data = data;
            this.material = material;
            this.point3D = point3D;
            this.vector = vector;

            orbit = new(this.vector.ArrVectors.Length);
        }

        public string GetInfo()
        {
            return $"id - {id}" +
                $"\n\t dates: {(data != null ? data.GetInfo() : 0)}" +
                $"\n\t point3D: {(point3D != null ? point3D.ToString() : 0)}" +
                $"\n\tmaterial: {(material != null ? material.GetInfo() : 0)}" +
                $"\n\tvector: {(vector != null ? vector.ToString() : 0)}";
        }

        public virtual void UpdateP3D()
        {
            orbit.IndexV();
            int i = orbit.indexV;
            point3D.coordX += vector.ArrVectors[i].coordX * orbit.MFACTORS[orbit.phase, 0];
            point3D.coordY += vector.ArrVectors[i].coordY * orbit.MFACTORS[orbit.phase, 1];
        }
    }
}
