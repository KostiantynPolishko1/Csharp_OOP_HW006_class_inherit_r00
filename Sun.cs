
namespace C__OOP_HW006_class_inherit_r00
{
    public sealed class Sun : SpaceObject
    {
        public readonly char s_object;

        public Sun(in char s_object, in DataObject? dataObj, in Material? material,
            in Point3D? p3D, in VectorPoint3D vp3D) : base(dataObj, material, p3D, vp3D)
        {
            this.s_object = s_object;
        }

        public sealed override string GetInfo()
        {
            return base.GetInfo()
                + $"\n\torbit -> {(vector != null ? "yes" : "no")}";
        }
    }
}
