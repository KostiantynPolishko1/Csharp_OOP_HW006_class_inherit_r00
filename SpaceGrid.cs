
namespace C__OOP_HW006_class_inherit_r00
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

        public void FillGrid(in char symbol, in int coordX, in int coordY)
        {
            spaceGrid[prev_coordX, prev_coordY] = '\0';
            spaceGrid[coordX, coordY] = symbol;
            prev_coordX = coordX;
            prev_coordY = coordY;
        }

        public void ShowGrid()
        {
            for (int i = 0; i != spaceGrid.GetLength(0); i++)
            {
                for (int j = 0; j != spaceGrid.GetLength(1); j++)
                {
                    Console.Write($" {(spaceGrid[i, j] == '\0'? s_grid : spaceGrid[i, j])} ");
                }
                Console.WriteLine();
            }
        }
    }
}
