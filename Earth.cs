
namespace C__OOP_HW006_class_inherit_r00
{
    public sealed class Earth: SpaceObject
    {
        public readonly bool gravity;
        public readonly char s_earth;

        public Earth(in bool gravity, in char s_earth, in DataObject? dataObj, in Material? material,
            in Point3D? p3D, in VectorPoint3D vp3D) : base(dataObj, material, p3D, vp3D)
        {
            this.gravity = gravity;
            this.s_earth = s_earth;
        }
    }
}