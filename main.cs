using C__OOP_HW006_class_inherit_r00;
{
    DataObject EarthData = new(200, "Mars");
    Material EarthMaterial = new("Carbon", "Ferum", "Silicium", "Cobalt");
    Point3D Earth_p3D = new(0, 0, 0);
    VectorPoint3D Earth_vp3D = new(new Point3D[] {new Point3D(1, 0, 0), new Point3D(3, 1, 0), new Point3D(3, 2, 0), new Point3D(2, 3, 0), new Point3D(1, 3, 0), new Point3D(0, 1, 0) });

    Earth earth = new(true, EarthData, EarthMaterial, Earth_p3D, Earth_vp3D);
    Console.WriteLine($"{earth.point3D.coordX} - {earth.point3D.coordY}\n");

    int i = 0;
    do
    {
        earth.UpdateP3D();
        Console.Write($"{earth.orbit.indexV} -> {earth.orbit.phase} : {earth.orbit.MFACTORS[earth.orbit.phase, 0]} | {earth.orbit.MFACTORS[earth.orbit.phase, 1]} : ");
        Console.WriteLine($"{earth.point3D.coordX} - {earth.point3D.coordY}");

        i += 1;
        if (i % 6 == 0)
            Console.WriteLine();

    } while (i < 60);
}
