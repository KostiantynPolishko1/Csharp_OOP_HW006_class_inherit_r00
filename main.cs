using C__OOP_HW006_class_inherit_r00;

//================================PLANET MARS INIT DATA================================//
DataObject MarsData = new(200, "Mars");
Material MarsMaterial = new("Carbon", "Ferum", "Silicium", "Cobalt");
Point3D Mars_p3D = new(14, 0, 0);
VectorPoint3D Mars_vp3D = new(new Point3D[] { new Point3D(1, 0, 0), new Point3D(3, 1, 0), new Point3D(3, 2, 0), new Point3D(2, 3, 0), new Point3D(1, 3, 0), new Point3D(0, 1, 0) });

//================================STAR SUN INIT DATA================================//
DataObject SunData = new(0, "Sun");
Material SunMaterial = new("Heliy", "Hydrogen", "Others");
Point3D Sun_p3D = new(14, 12, 0);

//================================COMET APOFIZ INIT DATA================================//
DataObject CometData = new(300, "Apofiz");
Material CometMaterial = new("Ice", "Dust", "Gas");
Point3D Comet_p3D = new(14, 2, 0);
VectorPoint3D Comet_vp3D = new(new Point3D[] { new Point3D(2, 1, 0), new Point3D(2, 2, 0), new Point3D(2, 3, 0), new Point3D(1, 2, 0), new Point3D(1, 4, 0), new Point3D(0, 1, 0) });

//================================MAIN================================//
{
    SpaceObject[] CelestialBodies = new SpaceObject[]
    { new Earth(true, true, 'e', MarsData, MarsMaterial, Mars_p3D, Mars_vp3D),  
        new Sun('s', SunData, SunMaterial, Sun_p3D, null),
        new Comet(true, 'c', CometData, CometMaterial, Comet_p3D, Comet_vp3D)};

    foreach(SpaceObject item in CelestialBodies)
    {
        Console.WriteLine(item.GetInfo());
    }

    /*SpaceGrid space_grid = new('.', 30, 30);
    ConsoleKeyInfo press;

    press = Console.ReadKey();

    do
    {
        space_grid.ShowGrid();
        space_grid.FillGrid(earth.s_earth, earth.point3D.coordX, earth.point3D.coordY);
        earth.UpdateP3D();
        Thread.Sleep(200);
        Console.Clear();

    } while (press.Key != ConsoleKey.Escape);*/
}
