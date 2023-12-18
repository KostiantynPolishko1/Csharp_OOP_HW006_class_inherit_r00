using C__OOP_HW006_class_inherit_r00;
{
    DataObject EarthData = new(200, "Mars");
    Material EarthMaterial = new("Carbon", "Ferum", "Silicium", "Cobalt");
    Point3D Earth_p3D = new(14, 0, 0);
    VectorPoint3D Earth_vp3D = new(new Point3D[] { new Point3D(1, 0, 0), new Point3D(3, 1, 0), new Point3D(3, 2, 0), new Point3D(2, 3, 0), new Point3D(1, 3, 0), new Point3D(0, 1, 0) });

    Earth earth = new(true, 'e', EarthData, EarthMaterial, Earth_p3D, Earth_vp3D);

    SpaceGrid space_grid = new('.', 30, 30);
    ConsoleKeyInfo press;
    press = Console.ReadKey();

    do
    {
        space_grid.ShowGrid();
        space_grid.FillGrid(earth.s_earth, earth.point3D.coordX, earth.point3D.coordY);
        earth.UpdateP3D();
        Thread.Sleep(200);
        Console.Clear();
    } while (press.Key != ConsoleKey.Escape);
}
