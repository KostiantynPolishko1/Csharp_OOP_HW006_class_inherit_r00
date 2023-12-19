using C__OOP_HW006_class_inherit_r00.SpaceObject_Base;

namespace C__OOP_HW006_class_inherit_r00.SpaceGrid_Base
{
    public class SpaceGrid
    {
        public readonly char s_grid;
        public char[,] spaceGrid { get; set; }
        public int prev_coordX { get; set; }
        public int prev_coordY { get; set; }

        public SpaceGrid(in char s_grid, in int sizeRow, in int sizeCol)
        {
            spaceGrid = new char[sizeRow, sizeCol];
            this.s_grid = s_grid;
            prev_coordX = 0;
            prev_coordY = 0;
        }


        //public void FillGrid(params SpaceObject[]? celestia_bodies)
        public void FillGrid(in SpaceObject? celestia_bodies)
        {
            /*            if (celestia_bodies == null)
                            return;

                        for (int i = 0; i != celestia_bodies.Length; i++)
                        {

                        }*/
            spaceGrid[prev_coordX, prev_coordY] = '\0';
            spaceGrid[celestia_bodies.point3D.coordX, celestia_bodies.point3D.coordY] = celestia_bodies.s_object;
            prev_coordX = celestia_bodies.point3D.coordX;
            prev_coordY = celestia_bodies.point3D.coordY;
        }

        public void ShowGrid()
        {
            for (int i = 0; i != spaceGrid.GetLength(0); i++)
            {
                for (int j = 0; j != spaceGrid.GetLength(1); j++)
                {
                    if (spaceGrid[i, j] != '\0') { Console.BackgroundColor = ConsoleColor.Red; }
                    Console.Write($" {(spaceGrid[i, j] == '\0' ? s_grid : spaceGrid[i, j])} ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine();
            }
        }
    }
}
