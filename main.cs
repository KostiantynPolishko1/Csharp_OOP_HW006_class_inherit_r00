using C__OOP_HW006_class_inherit_r00;
{
    //===============class point3D===============//
    Point3D point3D = new(0, 0, 0);
    //Console.WriteLine(point3D.ToString());

    //===============class VectorPoint3D(Point3D)===============//
    VectorPoint3D vEarth = new(new Point3D[] {new Point3D(1, 0, 0), new Point3D(3, 1, 0), new Point3D(3, 2, 0), new Point3D(2, 3, 0), new Point3D(1, 3, 0), new Point3D(0, 1, 0) });
    //Console.WriteLine(vEarth.ToString());

    //===============class Material===============//
    Material material = new("Carbon", "Ferum", "Silicium", "Cobalt");
    //Console.WriteLine(material.GetInfo());

    //===============class DataObject===============//
    DataObject dataObject = new(200, "Mars");
    //Console.WriteLine(dataObject.GetInfo());

    //===============class SpaceObject===============//
    SpaceObject spaceObject = new();
    Console.WriteLine($"{spaceObject.GetInfo()}");

    spaceObject.data = dataObject;
    Console.WriteLine($"{spaceObject.GetInfo()}");

    spaceObject.material = material;
    Console.WriteLine($"{spaceObject.GetInfo()}");

    spaceObject.point3D = point3D;
    Console.WriteLine($"{spaceObject.GetInfo()}");

    spaceObject.vector = vEarth;
    Console.WriteLine($"{spaceObject.GetInfo()}");

}